<?php
if($_POST) {
	$mail = $_POST['email'];
	$rue = $_POST['rue'];
	$cdp = $_POST['cdp'];
	$ville = $_POST['ville'];
	$nom = $_POST['nom'];
	$prenom = $_POST['prenom'];
	$psw = $_POST['password'];
	if(!empty($rue) && !empty($cdp) && !empty($ville)) {
		if(updateAdresse($_SESSION['email'], $rue, $cdp, $ville)) {
			success("adresse physique");
		} else {
			danger("adresse physique");
		}
	}

	if(!empty($mail)) {
		if(updateEmail($_SESSION['email'], $mail)) {
			success("adresse email");
		} else {
			danger("adresse email");
		}
	}

	if(!empty($psw)) {
		if(updatePassword($_SESSION['email'], $psw)) {
			success("mot de passe");
		} else {
			danger("mot de passe");
		}
	}

	if(!empty($nom) && !empty($prenom)) {
		if(updateNomPrenom($_SESSION['email'], $nom, $prenom)) {
			success("nom / prénom");
		} else {
			danger("nom / prénom");
		}
	}

	include(CHEMIN_MODULE_USER_VUE."profil.php");
}
else {
	if(empty($_SESSION['email'])) {
		header("location: index.php?page=accueil");
	} else {
		include(CHEMIN_MODULE_USER_VUE."profil.php");
	}
}
