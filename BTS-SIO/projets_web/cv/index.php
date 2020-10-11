<!DOCTYPE html>
<html lang="fr" dir="ltr">
<head>
	<meta charset="utf-8">
	<link rel="stylesheet" href="css/main.css">
	<title>CV-Thomas LEBRET</title>
</head>
<body>
	<?php include("header.html"); ?>
	<div class="body">
		<section class="gauche">
			<div class="contenugauche">
				<h1 class="info">Thomas LEBRET</h1></br>
				<a class="info" href="mailto: th.lebret@outlook.fr">th.lebret@outlook.fr</a>
			</div>
			<div class="contenugauche">
				<img class="photoProfil" src="Images/profil.jpg" alt="Photo profil">
			</div>
			<div class="contenugauche">
				<h1 class="info">DATE DE NAISSANCE</h1></br>
				<p>03/02/2000</p>
			</div>
			<div class="contenugauche">
				<h1 class="info"> <span> <img class="lien" src="Images/link.png"> </span> <a class="info" target="_blank" href="https://github.com/ThomasLEBRET">Mon Github</a> </h1></br>
			</div>
			<div class="contenugauche">
				<h1 class="info"> <span> <img class="lien" src="Images/link.png"> </span> <a class="info" href="contact.php">Contact</a> </h1></br>
			</div>
			<div class="contenugauche">
				<h1 class="info">Présentation</h1></br>
				<p>
					Étudiant rigoureux et dynamique, désireux de mettre en application mon apprentissage théorique.
					Formé aux techniques des réseaux et du développement informatique, je suis doté d’un bon sens relationnel.
					Je sais faire preuve d’initiative tout en veillant au respect des procédures de l’entreprise.
				</p>
			</br>
		</div>
	</section>
	<section class="droite">
		<div class="en-tete">
			<?php
				if (isset($_GET['page'])) {
					echo "<h1 class='info'>".$_GET['page']."</h1>";
				}
			?>
		</div>
		<div class="contientInfo">
			<div class="infos">
				<?php
				if(isset($_GET['page'])) {
					switch($_GET['page']) {
						case "experience":
							include("experiences.html");
							break;
						case "formation":
							include("formations.html");
							break;
						case "projets":
							include("projets.html");
							break;
						case "veille":
							include("veille.html");
							break;
						case "loisirs":
							include("loisirs.html");
							break;
						case "competences":
							include("competences.html");
							break;
						default:
							echo "Le changement de valeur dans l'URL est interdit ";
							break;
						}
					}
					?>
				</div>
			</div>
		</section>
	</div>
</body>
</html>
