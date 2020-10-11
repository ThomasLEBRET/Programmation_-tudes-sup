<?php
include(CHEMIN_LIBRARY.'dbfunction.php');
include(CHEMIN_MODULE_FORM_MODEL."m_formulaire.php");

function getUserById($id) {
	$con = dbConnect();
	if($con) {
		$req =   "SELECT *
		FROM user
		WHERE id = '$id' ";
		$res = mysqli_query($con,$req);
		if($ligne = mysqli_fetch_array($res)) {
			$_SESSION['nom'] = $ligne['nom'];
			$_SESSION['prenom'] = $ligne['prenom'];
			$_SESSION['ddn'] = $ligne['ddn'];
			$_SESSION['imgprofil'] = $ligne['imgprofil'];
			$_SESSION['mail'] = $ligne['mail'];
			$_SESSION['password'] = $ligne['password'];
			$_SESSION['no_tel'] = $ligne['no_tel'];
			$_SESSION['presentation'] = $ligne['presentation'];
		}
	}
	dbDisconnect($con);
}
/* getAllUser() */
function getAllUser() {
	$con = dbConnect();
	if($con) {
		$req =
		"SELECT * FROM user";
		$res = mysqli_query($con,$req);
		if($res) {
			$tab = [];
			while($ligne = mysqli_fetch_array($res)) {
				$tab[] = $ligne;
			}
		}
	}
	dbDisconnect($con);
	return $tab;
}

/* getUsersByName() */
function getUsersByName($name) {
	$con = dbConnect();
	if($con) {
		$req =
		"SELECT * FROM user WHERE nom = '$name'";
		$res = mysqli_query($con,$req);
		if($res) {
			$tab = [];
			while($ligne = mysqli_fetch_array($res)) {
				$tab[] = $ligne;
			}
		}
	}
	dbDisconnect($con);
	return $tab;
}

function insertUser($con, $nom, $prenom, $ddn, $mail, $password, $no_tel, $presentation) {
	$req = "INSERT INTO user(nom,prenom,ddn,imgprofil,mail,password,no_tel,presentation)
	VALUES('$nom','$prenom','$ddn','default.jpg','$mail','$password','$no_tel','$presentation')";
	$res = mysqli_query($con,$req);
	if($res) {
		return $res;
	}
	return false;
}

/* deleteUser */
function deleteUser($con, $id) {
	if($con) {
		$req = "DELETE FROM user WHERE id = '$id'";
		$res = mysqli_query($con,$req);
		if($res) {
			return $res;
		}
	}
	return false;
}

/* updateUser */
function modifUser($con, $id, $postNom, $postPrenom, $postDdn, $postMail, $postNoTel, $postPresentation) {
	if($con) {
		$req = "	UPDATE user
		SET 	nom = '$postNom',
		prenom = '$postPrenom',
		ddn = '$postDdn',
		mail = '$postMail',
		no_tel = '$postNoTel',
		presentation = '$postPresentation'
		WHERE id = '$id' ";
		$res = mysqli_query($con,$req);
		if($res) {
			return $res;
		}
	}
	return false;
}
?>
