<?php

/**
* Vérifie qu'un email existe dans la base de données
* @param  string $email une adresse email
* @return bool        	true si la requête a aboutie ou si un email existe, false sinon
*/
function checkEmail($email) {
	$con = dbConnect();
	$req = "	SELECT email
	FROM utilisateur
	WHERE email = '$email' ";
	$res = mysqli_query($con, $req);
	if($ligne = mysqli_fetch_array($res)){
		dbDisconnect($con);
		return true;
	}
	else {
		dbDisconnect($con);
		return false;
	}
}

/**
* Connecte un utilisateur grâce à son adresse mail
* @param  string $email une adresse mail utilisateur
* @return bool        	true si la requête a abouti, false sinon
*/
function getUserByEmail($email) {
	if (!regexMail($email)) {
		return false;
	}
	$con = dbConnect();
	if($con) {
		$req =   "SELECT email, sexe, nom, prenom, DATE_FORMAT(date_de_naissance,'%d/%m/%Y') AS ddn, rue, code_postal, ville, DATE_FORMAT(derniere_connexion,'%d/%m/%Y') AS derniere_connexion, derniere_ip_connue, solde
		FROM utilisateur
		WHERE email = '$email' ";
		$res = mysqli_query($con,$req);
		if($ligne = mysqli_fetch_array($res)) {
			$_SESSION['email'] = $ligne['email'];
			$_SESSION['sexe'] = $ligne['sexe'];
			$_SESSION['nom'] = $ligne['nom'];
			$_SESSION['prenom'] = $ligne['prenom'];
			$_SESSION['ddn'] = $ligne['ddn'];
			$_SESSION['rue'] = $ligne['rue'];
			$_SESSION['code_postal'] = $ligne['code_postal'];
			$_SESSION['ville'] = $ligne['ville'];
			$_SESSION['derniere_connexion'] = $ligne['derniere_connexion'];
			$_SESSION['derniere_ip_connue'] = $ligne['derniere_ip_connue'];
			$_SESSION['solde'] = $ligne['solde'];
			dbDisconnect($con);
			return true;
		}
	}
	dbDisconnect($con);
	return false;
}

/**
* Connecte un utilisateur grâce à son token
* @param  string $token un token utilisateur existant
* @return bool        	true si la requête a abouti, false sinon
*/
function getUserBytoken($token) {
	$con = dbConnect();
	if($con) {
		$req =   "SELECT email
		FROM verification
		WHERE token = '$token' ";
		$res = mysqli_query($con,$req);
		if($ligne = mysqli_fetch_array($res)) {
			$email = $ligne['email'];
		} else {
			dbDisconnect($con);
			return false;
		}
		if($res) {
			$req =   "SELECT email, sexe, nom, prenom, DATE_FORMAT(date_de_naissance,'%d/%m/%Y') AS ddn, rue, code_postal, ville, DATE_FORMAT(derniere_connexion,'%d/%m/%Y') AS derniere_connexion, connexion_recente, derniere_ip_connue, solde
			FROM utilisateur
			WHERE email = '$email' ";
			$res = mysqli_query($con,$req);
			if($res) {
				if($ligne = mysqli_fetch_array($res)) {
					$_SESSION['email'] = $ligne['email'];
					$_SESSION['sexe'] = $ligne['sexe'];
					$_SESSION['nom'] = $ligne['nom'];
					$_SESSION['prenom'] = $ligne['prenom'];
					$_SESSION['ddn'] = $ligne['ddn'];
					$_SESSION['rue'] = $ligne['rue'];
					$_SESSION['code_postal'] = $ligne['code_postal'];
					$_SESSION['ville'] = $ligne['ville'];
					$_SESSION['connexion_recente'] = $ligne['connexion_recente'];
					$_SESSION['derniere_connexion'] = $ligne['derniere_connexion'];
					$_SESSION['derniere_ip_connue'] = $ligne['derniere_ip_connue'];
					$_SESSION['solde'] = $ligne['solde'];
					dbDisconnect($con);
					return true;
				}
			}
		}
	}
	dbDisconnect($con);
	return false;
}

/**
* Ajoute un utilisateur à la base de données
* @param  string 	$email  adresse mail
* @param  string 	$sexe   sexe (1 caractère)
* @param  string 	$nom    un nom
* @param  string 	$prenom un prénom
* @param  string 	$ddn    une date de naissance
* @param  string 	$rue    une rue
* @param  int 	$cdp    un code postal
* @param  string 	$sel    un sel
* @param  string 	$ville  une ville
* @param  int 	$solde  un solde (vaut 0 par défaut)
* @param  string 	$psw    un mot de passe en brut
* @return bool         	   true si la requête a abouti, false sinon
*/
function insertUser($email, $sexe, $nom, $prenom, $ddn, $rue, $cdp, $sel, $ville, $solde, $psw) {
	$tab[] = $email;
	$tab[] = $sexe;
	$tab[] = $nom;
	$tab[] = $prenom;
	$tab[] = $ddn;
	$tab[] = $rue;
	$tab[] = $cdp;
	$tab[] = $sel;
	$tab[] = $ville;
	if(strlen($sexe) != 1 && ($sexe != "H" || $sexe != "F" || $sexe !="A")) {
		return false;
	}
	if(!regexMail($email) || checkEmail($email) || !regexCdp($cdp) || !regexDdn($ddn) || !regexNom($nom) || !regexNom($prenom) || !regexNom($ville) || $solde != 0) {
		return false;
	}
	$con = dbConnect();
	$ip = file_get_contents("http://api.ipify.org");
	$req = "	INSERT INTO utilisateur
	VALUES('$email', '$sexe', '$nom', '$prenom', '$ddn',
		'$rue', '$cdp', '$sel', '$ville','$psw', NOW(), NOW(),
		'$ip', '$solde')";
		$res = mysqli_query($con, $req);
		if($res) {
			dbDisconnect($con);
			return true;
		}
		dbDisconnect($con);
		return false;
	}

	/**
	* Vérifie qu'un token appartient bien à un utilisateur
	* @param  string  $token un token
	* @return boolean        true si la requête a abouti, false sinon
	*/
	function isVerified($token) {
		$con = dbConnect();
		$req = "	SELECT v.verifie, v.token
		FROM utilisateur u, verification v
		WHERE u.email = v.email
		AND v.token = '$token'";
		$res = mysqli_query($con,$req);
		if($ligne = mysqli_fetch_array($res)) {
			if($ligne['verifie'] == 0) {
				$req = "UPDATE verification
				SET verifie = 1
				WHERE token = '$token'";
				if(mysqli_query($con,$req)) {
					return true;
				}
			}
		}
		return false;
	}

	/**
	* Créé un token pour un utilisateur eet l'insère dans la base de données
	* @param  string $mail 	l'adresse email de l'utilisateur
	* @return bool       	true si la requête a abouti, false sinon
	*/
	function createTokenForUser($mail) {
		if(empty($mail) || !regexMail($mail)) {
			return false;
		}
		if(checkEmail($mail) == false) {
			return false;
		}
		$con = dbConnect();
		$token = uniqid(mt_rand(), true);
		$req = "	INSERT INTO verification(email, token, dt_enregistrement, verifie)
		VALUES('$mail', '$token', NOW(), 0)";
		if($req) {
			$res = mysqli_query($con,$req);
			if($res) {
				//sendMail($mail, $token);
				dbDisconnect($con);
				return true;
			}
		}
		return false;
	}

	/**
	* Met à jour un token d'authentification pour un utilisateur et renvoi un mail à l'utilisateur
	* @param  void
	* @return bool true si la requête a abouti, false sinon
	*/
	function generateToken($mail) {
		if(!checkEmail($mail)){
			return False;
		}
		$con = dbConnect();
		$token = uniqid(mt_rand(), true);
		$req = "	UPDATE verification
		SET token = '$token'
		WHERE email = '$mail'";
		if($req) {
			$res = mysqli_query($con,$req);
			sendMail($mail, $token);
			dbDisconnect($con);
			return true;
		}
		return false;
	}

	/**
	* Envoi un mail de vérification de compte en fonction d'un token associé à une adresse mail
	* @param string $mail une adresse mail utilisateur
	* @param string $token un token d'authentification
	* @return void
	*/
	function sendMail($mail, $token) {
		$url = "citytransports/index.php?page=verifie&token=$token";
		$to = $mail;
		$subject = "Vérifiez votre compte Citytransport";
		$body = file_get_contents(CHEMIN_MODULE_USER_VUE."mail/auth1.html").$url.file_get_contents(CHEMIN_MODULE_USER_VUE."mail/auth2.html");
		$headers[] = 'MIME-Version: 1.0';
		$headers[] = 'Content-type: text/html; charset=utf-8';
		mail($to, $subject, $body, implode("\r\n", $headers));
	}

	/**
	* Met à jour la session en fonction de l'état de vérification du compte
	* @param string $mail 	une adresse mail utilisateur
	* @return bool			true si la requête a abouti, false sinon
	*/
	function userVerified($mail) {
		$con = dbConnect();
		if($con) {
			$req = "	SELECT verifie
			FROM verification
			WHERE email = '$mail'";
			$res = mysqli_query($con,$req);
			if($ligne = mysqli_fetch_array($res)) {
				$_SESSION['verifie'] = $ligne['verifie'];
				dbDisconnect($con);
				return true;
			}
		}
		dbDisconnect($con);
		return false;
	}

	/**
	* Connecte un utilisateur
	* @param  string $mail 	email utilisateur
	* @param  string $psw  	mot de passe en brut utilisateur
	* @return bool       	true si la requête s'est bien passée, false sinon
	*/
	function connectUser($mail, $psw) {
		$con = dbConnect();
		$req = "	SELECT *
		FROM utilisateur
		WHERE email = '$mail'";
		$res = mysqli_query($con,$req);
		if($ligne = mysqli_fetch_array($res)) {
			$password = htmlentities($ligne['sel'].$psw);
			if(password_verify($password, $ligne['password'])) {
				$ip = file_get_contents("http://api.ipify.org");
				if(!$ip) {
					$ip = "unknow";
				}
				$conRec = $ligne['connexion_recente'];
				$req = "	UPDATE utilisateur
				SET derniere_ip_connue = '$ip',
				derniere_connexion = '$conRec',
				connexion_recente = NOW()
				WHERE email = '$mail'";
				$res = mysqli_query($con,$req);
				if($res) {
					getUserByEmail($mail);
					dbDisconnect($con);
					return true;
				}
			} else {
				dbDisconnect($con);
				return false;
			}
			dbDisconnect($con);
		}
		return false;
	}

	/**
	* Met à jour l'adresse physique d'un utilisateur connecté
	* @param string $mail 	mail utilisateur
	* @param string $rue 	rue de l'adresse de l'utilisateur
	* @param int    $cdp 	code postal de l'adresse de l'utilisateur
	* @param string $ville 	ville de l'adresse de l'utilisateur
	* @return bool		true si la requête a abouti, false sinon
	*/
	function updateAdresse($mail, $rue, $cdp, $ville) {
		if(!isset($mail) && !isset($rue) && !isset($cdp) && !isset($ville)) {
			return false;
		}
		$con = dbConnect();
		if($con) {
			$req = "	UPDATE utilisateur
			SET 	rue = '$rue',
			code_postal = '$cdp',
			ville = '$ville'
			WHERE email = '$mail'";
			$res = mysqli_query($con,$req);
			if($res) {
				$_SESSION['rue'] = $rue;
				$_SESSION['code_postal'] = $cdp;
				$_SESSION['ville'] = $ville;
				dbDisconnect($con);
				return true;
			}
		}
		dbDisconnect($con);
		return false;
	}

	/**
	* Met à jour l'adresse email d'un utilisateur connecté grâce à son ancien mail
	* @param  string $oldMail mail utilisateur avant modification
	* @param  string $mail    nouvelle adresse mail utilisateur
	* @return bool            true si la requête a aboutie, false sinon
	*/

	function updateEmail($oldMail, $mail) {
		if (mailExist($mail)){
			return false;
		}
		$con = dbConnect();
		if($con) {
			$req = "	UPDATE utilisateur
			SET 	email = '$mail'
			WHERE email = '$oldMail'";
			$res = mysqli_query($con,$req);
			if($res) {
				$_SESSION['email'] = $mail;
				dbDisconnect($con);
				return true;
			}
		}
		return false;
		dbDisconnect($con);
	}

	/**
	* Vérifie qu'un mail existe bien dans la base de donnée
	* @param  string $mail 	un email
	* @return bool       	true si la requête a abouti et retourne un email, false sinon
	*/

	function mailExist($mail) {
		$con = dbConnect();
		if($con) {
			$req = "	SELECT email
			FROM utilisateur
			WHERE email = '$mail'";
			$res = mysqli_query($con,$req);
			if($ligne = mysqli_fetch_array($res)) {
				dbDisconnect($con);
				return true;
			} else {
				return false;
			}
		}
		dbDisconnect($con);
		return false;
	}

	/**
	* Met à jour le nom et le prénom de l'utilisateur connecté grâce à son adresse mail
	* @param  string $mail   	email utilisateur
	* @param  string $nom    	nom utilisateur
	* @param  string $prenom 	prénom utilisatuer
	* @return bool         		true si la requête s'est bien passée, false sinon
	*/

	function updateNomPrenom($mail, $nom, $prenom) {
		$con = dbConnect();
		if($con) {
			$req = "	UPDATE utilisateur
			SET 	nom = '$nom',
			prenom = '$prenom'
			WHERE email = '$mail'";
			$res = mysqli_query($con,$req);
			if($res) {
				$_SESSION['nom'] = $nom;
				$_SESSION['prenom'] = $prenom;
				dbDisconnect($con);
				return true;
			}
		}
		return false;
		dbDisconnect($con);
	}

	/**
	* Met à jour le mot de passe d'un utilisateur connecté en fonction de son mail et mot de passe
	* @param  string $mail     	email utilisateur
	* @param  string $password 	mot de passe brut utilisateur
	* @return bool   			true si la requête s'est bien passée, false sinon
	*/
	function updatePassword($mail, $password) {
		$con = dbConnect();
		if($con) {
			$sel = salt();
			$psw = password_hash($sel.$password, PASSWORD_DEFAULT);
			$req = "	UPDATE utilisateur
			SET 	password = '$psw',
			sel = '$sel'
			WHERE email = '$mail'";
			$res = mysqli_query($con,$req);
			if($res) {
				dbDisconnect($con);
				return true;
			}
		}
		return false;
		dbDisconnect($con);
	}
