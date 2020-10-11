<?php include("constantes.php") ?>
<?php include(CHEMIN_MODULE_USER_MODEL."m_userfunction.php"); ?>
<?php include(CHEMIN_GLOBAL."head.html"); ?>
<?php
startSession();
if($_SESSION) {
	getUserById($_SESSION['iduser']);
	$id = $_SESSION['iduser'];
	$nom = $_SESSION['nom'];
	$prenom = $_SESSION['prenom'];
	$ddn = $_SESSION['ddn'];
	$mail = $_SESSION['mail'];
	$noTel = $_SESSION['no_tel'];
	$presentation = $_SESSION['presentation'];
	$imgname = $_SESSION['imgprofil'];
	include(CHEMIN_GLOBAL."menu.html");
	include(CHEMIN_MODULE_USER_VUE."v_profil.php");
}
if(!empty($_GET['page'])){
	switch($_GET['page']) {
		case "connexion":
		include(CHEMIN_MODULE_USER_CONTROLER."c_connexion.php");
		break;
		case "inscription":
		include(CHEMIN_MODULE_USER_CONTROLER."c_inscription.php");
		break;
	}
}
else {
	header("location: index.php?page=connexion");
}
?>

<?php include(CHEMIN_GLOBAL."footer.html"); ?>
