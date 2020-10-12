<?php
	$res = listeIncident();
	if($res) {
		while($ligne = mysqli_fetch_array($res)) {
			if($ligne['importance'] == "GRAND")
				$imp = "alert-danger";
			else if($ligne['importance'] == "PETIT")
				$imp = "alert-info";
			else
				$imp = "alert-warning";
			include(CHEMIN_MODULE_TRAJET_VUE."incident.php");
		}
	}
	else
		echo "Erreur inconnue., veuillez réessayer plus tard.";
