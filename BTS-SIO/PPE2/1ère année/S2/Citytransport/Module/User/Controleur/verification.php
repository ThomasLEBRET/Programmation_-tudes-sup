<?php
	if(!empty($_SESSION['tmpMail'])) {
		if(userVerified($_SESSION['tmpMail'])) {
			if(!empty($_GET['token'])) {
				if(isVerified($_GET['token'])) {
					if(connectUser($_SESSION['tmpMail'], $_SESSION['tmpPassword'])) {
						header('Location: index.php?page=accueil');
					}
				}
			} else {
				if(!empty($_POST) && $_POST['repost'] == 'mail') {
					generateToken($_SESSION['tmpMail']);
					include(CHEMIN_MODULE_USER_VUE."verification.php");
				} else {
					if($_SESSION['verifie'] == 0) {
						include(CHEMIN_MODULE_USER_VUE."verification.php");
					}
					else {
						if(connectUser($_SESSION['tmpMail'], $_SESSION['tmpPassword'])) {
							header('Location: index.php?page=accueil');
						} else {
							include(CHEMIN_MODULE_USER_VUE."verification.php");
						}
					}
				}
			}
		} else {
			createTokenForUser($_SESSION['tmpMail']);
			header('Location: index.php?page=verifie');
		}
	} else {
		echo "Erreur lors de la connexion, veuillez tenter de vous reconnecter !";
		sleep(3);
		header('Location: index.php?page=connexion');
	}
