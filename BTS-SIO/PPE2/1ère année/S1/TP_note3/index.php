<?php session_start(); ?>
<!DOCTYPE html>
<html lang="fr" dir="ltr">
<head>
	<meta charset="utf-8">
	<link rel="stylesheet" href="css/main.css">
	<link rel="shortcut icon" href="image/favicon.ico">
	<title>Fakebook</title>
</head>
<body>
	<header>
		<div class="logo">
			<img src="image/fakebook.jpg" alt="Fakebook">
		</div>
		<nav>
			<a class="menu" href="index.php?page=mur">Mur</a>&nbsp;
			<a class="menu" href="index.php?page=profil">Profil</a>&nbsp;
			<a class="menu" href="index.php?page=amis">Amis</a>&nbsp;
			<a class="menu" href="">Déconnexion</a>
		</nav>
	</header>
	<div class="body">
		<section class="gauche">
			<div class="contenugauche">
				<img src="image/avatar.jpg" alt="Mon Avatar">
			</div>
			<div class="contenugauche">
				<?php include("amis.htm"); ?>
			</div>
		</section>
		<section class="droite">
			<?php
			if(isset($_GET['page'])) {
				switch($_GET['page']) {
					case "mur":
					include("mur.php");
					break;
					case "profil":
					include("profil.php");
					break;
					case "amis":
					include("listeAmis.php");
					break;
					default:
					echo "Le changement de valeur dans l'URL est interdit ";
					break;
				}
			}
			?>
		</section>
	</div>
</body>
</html>
