<?php include("constantes.php"); ?>
<?php include(CHEMIN_LIBRARY."fonction.php"); ?>
<?php includeModeleUser(); ?>
<?php includeModeleTrajet(); ?>
<?php include(CHEMIN_GLOBAL."head.html"); ?>

<?php
startSession();
if(!empty($_SESSION['email'])) {
	getUserByEmail($_SESSION['email']);
	include(CHEMIN_GLOBAL."menuConnecte.php");
}
else
	include(CHEMIN_GLOBAL."menu.html");
?>

<?php
if(!empty($_GET['page'])) {
	switch ($_GET['page']) {
		case 'accueil':
		include(CHEMIN_MODULE_USER_VUE."main.php");
		break;
		case 'verifie':
		include(CHEMIN_MODULE_USER_CONTROLEUR."verification.php");
		break;
		case 'connexion':
		include(CHEMIN_MODULE_USER_CONTROLEUR."connexion.php");
		break;
		case 'inscription':
		include(CHEMIN_MODULE_USER_CONTROLEUR."inscription.php");
		break;
		case 'incident':
		include(CHEMIN_MODULE_TRAJET_CONTROLEUR."incident.php");
		break;
		case 'search':
		include(CHEMIN_MODULE_TRAJET_CONTROLEUR."itineraire.php");
		break;
		case 'profil':
		include(CHEMIN_MODULE_USER_CONTROLEUR."profil.php");
		break;
		case 'historique':
		include(CHEMIN_MODULE_TRAJET_CONTROLEUR."historique.php");
		break;
		case 'deconnexion':
		include(CHEMIN_MODULE_USER_CONTROLEUR."deconnexion.php");
		break;
		default:
		header('location: index.php?page=accueil');
		break;
	}
}
else {
	header('location: index.php?page=accueil');
}
echo "<script type='text/javascript' src='".CHEMIN_JS."function.js'></script>";
?>
<?php include(CHEMIN_GLOBAL."footer.html"); ?>
