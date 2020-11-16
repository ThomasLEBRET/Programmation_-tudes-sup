<?php
session_start();
include ("fonctions.php");
if (verifConnect($_SESSION['idUser'], $_SESSION['mdpUser'])==0){
	header("location:login.php");
}
else
{
	enTeteHTML("style.css");
	
	//var_dump($_SESSION);
?>
	<nav>
		<div class='menu'>
			<a href='index.php?menu=intervinfo'>Interventions informatiques</a><br/>
			... Autres applications disponibles ...<br/>
			<a href='index.php?menu=NDFgestion'>Gestion des notes de frais</a><br/>
			<a href='deconnexion.php'>Déconnexion</a>
		</div>
		<div class='sousmenu'>
			<?php
				if(isset($_GET['menu'])){
					switch($_GET['menu']){
						case "intervinfo":
							include("intervinfo/sousmenu.php");
						break;
						//Autres cas correspondant aux autres applications disponibles
						case "NDFgestion":
							include("NDFgestion/sousmenu.php");
						break;
					}
				}
			?>
		</div>
	</nav>
	<section>
		<?php
			if(isset($_GET['menu'])){
				switch($_GET['menu']){
					case "intervinfo":
						include("intervinfo/accueil.php");
					break;
					//Autres cas correspondant aux autres applications disponibles
					case "NDFgestion":
						include("NDFgestion/accueil.php");
					break;
					default:
						echo "Veuillez choisir l'application que vous souhaitez utiliser dans le menu";
					break;
				}
			}
			else {
				echo "Veuillez choisir l'application que vous souhaitez utiliser dans le menu";
			}
		?>
	</section>
<?php 
	piedDePageHTML();
} 
?>
