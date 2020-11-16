<?php
if (verifConnect($_SESSION['idUser'], $_SESSION['mdpUser'])==0){
	header("location:login.php");
}
else
{
	echo "
		<a href='index.php?menu=intervinfo&sousmenu=creerticket'>Créer un ticket d'intervention</a><br/>
		... Autres sous-menus disponibles aux employés ...<br/>
	";
	if($_SESSION['service']=='Informatique' && $_SESSION['typeCompte']=='Gestionnaire') {
		echo "
			<a href='index.php?menu=intervinfo&sousmenu=saisirCrInterv'>Compte-rendu d'intervention</a><br/>
			... Autres sous-menus disponibles aux gestionnaires du service informatique ...
		";
	}
}
?>