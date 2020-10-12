<?php
if(!empty($_SESSION['email'])) {
	header('Location: index.php?page=accueil');
} elseif(!isset($_POST['valid'])) {
	include(CHEMIN_MODULE_USER_VUE."inscription.php");
}
else {
	if(!$_POST){
		header("Location: index.php?page=accueil");
	} else {
		foreach ($_POST as $key => $value) {
			if(empty($_POST[$key])){
				echo "Un des champs n'est pas rempli !";
				header('Location: index.php?page=accueil');
				exit();
			}
		}
		if(empty($_POST['sexe'])) {
			echo "Un des champs n'est pas rempli !";
			header('Location: index.php?page=accueil');
			exit();
		}
		$email = $_POST['email'];
		$sexe = $_POST['sexe'];
		$nom = $_POST['nom'];
		$prenom = $_POST['prenom'];
		$ddn = $_POST['ddn'];
		$rue = $_POST['rue'];
		$cdp = $_POST['cdp'];
		$sel = salt();
		$ville = $_POST['ville'];
		$solde = 0;
		$psw = $_POST['psw'];
		$psw2 = $_POST['psw2'];
		if(comparePassword($psw, $psw2) && !checkEmail($email) && regexMail($email)) {
			$psw = password_hash($sel.$_POST['psw'], PASSWORD_DEFAULT);
			if(insertUser($email, $sexe, $nom, $prenom, $ddn, $rue, $cdp, $sel, $ville, $solde, $psw)) {
				createTokenForUser($email);
				$_SESSION['tmpMail'] = $email;
				$_SESSION['tmpPassword'] = $_POST['psw'];
				$_SESSION['verifie'] = 0;
				header('Location: index.php?page=verifie');
			} else {
				echo "L'utilisateur n'a pas pu être inscrit !";
			}
		} else {
			echo "Les mots de passe ne correspondent pas ou cette adresse mail existe déjà !";
			header("Location: index.php?page=inscription");
		}
	}
}
