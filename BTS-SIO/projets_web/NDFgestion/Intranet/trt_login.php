<?php
	//si un utilisateur essaye d'accéder à ce script sans passer par le formulaire de connexion on le redirige vers la page de login
	if(!isset($_POST['validLogin'])) {
		header("location:login.php");
	}
	//sinon on traite les informations saisies dans le formulaire de connexion
	else {
		include("fonctions.php");
		$userConnecte = verifConnect($_POST['log'], $_POST['mdp']);
		//si les login/mot de passe provenant du formulaires de connexion ne correspondent pas à un utilisateur de la bdd
		//alors on le redirige vers la page de connexion
		if ($userConnecte==0){
			//header("location:login.php");
		}
		//sinon on crée les variables de session pour son login, son mot de passe et son type de compte
		//et on redirige vers index.php
		else {
			session_start();
			$_SESSION['idUser'] = $_POST['log'];
			$_SESSION['mdpUser'] = $_POST['mdp'];
			$_SESSION['typeCompte'] = $userConnecte['nomTC'];
			$_SESSION['service'] = $userConnecte['nomService'];
			header("location:index.php");
		}
	}
?>