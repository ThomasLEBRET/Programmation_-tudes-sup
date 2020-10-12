<?php
/**
* Inclue le modèle user
*/
function includeModeleUser() {
	include(CHEMIN_MODULE_USER_MODELE."user.php");
}

/**
* Inclue le modèle trajet
*/
function includeModeleTrajet() {
	include(CHEMIN_MODULE_TRAJET_MODELE."trajet.php");
}

/**
* Réalise une connexion de type mysqli
* @return $con une connexion mysqli
*/
function dbConnect() {
	$host = 'localhost';
	$user = "root";
	$pwd = "root";
	$dbname = "citytransports";
	$con = mysqli_connect($host,$user,$pwd,$dbname);
	if(!$con) {
		return false;
	}
	return $con;
}

/**
* Déconnection de la base de données
* @param  mysqli $con 	une connexion mysqli
* @return bool 		true
*/
function dbDisconnect($con) {
	mysqli_close($con);
	return true;
}

/**
* Démarre une session si elle n'existe pas
*/
function startSession() {
	if(empty($_SESSION)) {
		session_start();
	}
	return true;
}

/**
* @param $mail
* @return bool
* Détruit une session en déchargeant le tableau $_SESSION. Met l'activité de l'utilisateur à 0
*/
function closeSession() {
	if($_SESSION) {
		session_unset();
		session_destroy();
		return true;
	} else {
		return false;
	}
}

/**
* Vérifie qu'une adresse email est au bon format
* @param  string $mail 	une adresse mail
* @return bool      	true si le maile est au bon format, false sinon
*/
function regexMail($mail) {
	if(!empty($mail)) {
		$regex = "#[a-zA-Z0-9]+@[a-zA-Z0-9]+.[a-zA-Z]+#"; //vérification de l'e-mail en prenant en compte les valeurs : a-z, A-Z, 0-9, @(pour le 2ème caractère), .(pour le 3ème caractère)
		if (preg_match ($regex, $mail))
		return true;
	}
	return false;
}

/**
* Vérifie qu'un code postal est au bon format
* @param int $cdp 	un code postal
* @return bool 	true si le code postal est au bon format, false sinon
*/
function regexCdp($cdp) {
	if(!empty($cdp)) {
		if ( preg_match ( "#^[0-9]{5,5}$#" , $cdp ) ) {
			return true;
		}
	}
	return false;
}

/**
* Vérifie qu'une date de naissance est au bon format
* @param string $ddn 	un code postal
* @return bool 		true si la date de naissance est au bon format, false sinon
*/
function regexDdn($ddn) {
	if(!empty($ddn) && strlen($ddn) == 10 ) {
		$day = substr($ddn, -2);
		$month = substr($ddn, -5, 2);
		$year = substr($ddn, 0, 4);
		if (checkdate($month, $day, $year)) {
			return true;
		}
	}
	return false;
}

/**
* Vérifie qu'un nom, prenom, ville est au bon format
* @param int $cdp 	un code postal
* @return bool 	true si le code postal est au bon format, false sinon
*/
function regexNom($nom) {
	if(!empty($nom)) {
		if ( preg_match ( "#^[a-zA-Z]#" , $nom ) ) {
			return true;
		}
	}
	return false;
}

/**
* Compare 2 mots de passe en brut
* @param  string $p1 	mot de passe 1
* @param  string $p2 	mot de passe 2
* @return bool     	true si les mots de passes correspondent et ne sont pas vides, false sinon
*/
function comparePassword($p1, $p2) {
	if($p1 == $p2 && !empty($p1) && !empty($p2))
	return true;
	return false;
}

/**
* Génère un sel
* @return string $sel un sel
*/
function salt() {
	$sa = substr(uniqid(mt_rand(), true), 8, 6);
	$n = mt_rand(33,126);
	$o = mt_rand(33,126);
	$l = chr($n);
	$t = chr($o);
	$salt = $t.$sa.$l;
	while(!checkSalt($salt)) {
		salt();
	}
	return $salt;
}

/**
* Vérifie qu'un sel n'existe pas déjà dans la base de données
* @param  string $salt 	un sel
* @return bool      	true quand le sel sera unique, false sinon
*/
function checkSalt($salt) {
	if(strlen($salt) != 8) {
		return false;
	}
	$con = dbConnect();
	$req = "	SELECT sel
	FROM utilisateur
	WHERE sel = '$salt' ";
	$res = mysqli_query($con, $req);
	while($ligne = mysqli_fetch_array($res)) {
		return false;
	}
	dbDisconnect($con);
	return true;
}

/**
* inclue un message de confirmation
* @param  string $param un paramètre correspondant à une donnée utilisateur
*/
function success($param) {
	include CHEMIN_MODULE_USER_VUE."success.php";
}

/**
* inclue un message d'erreur
* @param  string $param un paramètre correspondant à une donnée utilisateur
*/
function danger($param) {
	include CHEMIN_MODULE_USER_VUE."danger.php";
}
