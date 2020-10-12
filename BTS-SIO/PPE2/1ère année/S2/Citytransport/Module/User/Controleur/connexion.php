<?php
	if(!empty($_SESSION['email'])) {
		header('Location: index.php?page=accueil');
	} elseif(!isset($_POST['valid'])) {
		include(CHEMIN_MODULE_USER_VUE."connexion.html");
	} else {
		if(!empty($_POST)) {
			$mail = $_POST['mail'];
			$psw = $_POST['psw'];
			if (checkEmail($mail) && regexMail($mail)) {
				if(userVerified($mail)) {
					$_SESSION['tmpMail'] = $mail;
					$_SESSION['tmpPassword'] = $psw;
					header('location: index.php?page=verifie');
				}
				else
					echo "Votre mot de passe est incorrect ou la redirection n'est pas automatique";
			}
			else {
				echo "Vous n'êtes pas inscrit !";
			}
		}
		else {
			echo "Une erreur inconnue est survenue";
		}
	}
