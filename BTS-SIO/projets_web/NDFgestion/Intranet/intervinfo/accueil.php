<?php
if (verifConnect($_SESSION['idUser'], $_SESSION['mdpUser'])==0){
	header("location:login.php");
}
else
{
	if(isset($_GET['menu']) && $_GET['menu'] == 'intervinfo'){
		if(isset($_GET['sousmenu'])) {
			switch($_GET['sousmenu']){
				case "creerticket":
					include("intervinfo/creerticket.php");
				break;
				//Autres cas correspondant aux autres applications disponibles
				case "saisirCrInterv":
					include("intervinfo/saisirCrInterv.php");
				break;
			}
		}
	}
	else {
		echo "Veuillez choisir l'application que vous souhaitez utiliser dans le menu";
	}
}
?>	