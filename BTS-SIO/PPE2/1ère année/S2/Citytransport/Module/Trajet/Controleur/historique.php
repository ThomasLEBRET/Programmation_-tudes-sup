<?php
	if(!empty($_SESSION['email'])) {
		$tab = getHistoriqueByUser($_SESSION['email']);
		echo "<div class='justify'>";
		if(empty($tab)) {
			echo "<h1 class='display-4 text-light'>Votre historique est tristement vide</h1>";
		} else {
			echo "<h1 class='display-4 text-light'>Voici les résultats de vos dernières recherches</h1>";
		}
		foreach ($tab as $key => $ligne) {
			include(CHEMIN_MODULE_TRAJET_VUE."historique.php");
		}
		echo "</div>";
	} else {
		header("location: index.php?page=accueil");
	}
