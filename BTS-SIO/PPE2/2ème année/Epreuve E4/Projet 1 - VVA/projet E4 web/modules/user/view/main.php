<?php
if(!isset($_SESSION['USER'])) {
	include_once(CHEMIN_MODULE_USER_V."form.php");
} else {
	include_once(CHEMIN_MODULE_USER_V."profil.php");
	if ($_SESSION['TYPEPROFIL'] == "VA") {
		$tab = listeActivitesInscrites($_SESSION['USER']);
		foreach($tab as $key => $ligne) {
			include(CHEMIN_MODULE_USER_V."activitesInscrit.php");
		}
	}
	if($_SESSION['TYPEPROFIL'] == "EN" ) {
		$tab = listeActivitesCreees($_SESSION['USER']);
		foreach($tab as $key => $ligne) {
			include(CHEMIN_MODULE_USER_V."activitesCreees.php");
		}
	}
}
