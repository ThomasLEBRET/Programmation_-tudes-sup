<div class="body">
	<section class="gauche">
		<div class="contenugauche">
			<h1 style="margin-top: 10%;" class="info"><?php echo $nom." ".$prenom; ?></h1><br>
			<a class="info" href="mailto: th.lebret@outlook.fr"> <?php echo $mail; ?> </a>
			<h1 class="info"> <?php echo $noTel; ?> </h1>
		</div>
		<div class="contenugauche">
			<img class="photoProfil" src="<?php echo CHEMIN_PROFIL."$imgname" ?>" alt="Photo profil">
		</div>
		<div class="contenugauche">
			<h1 class="info">DATE DE NAISSANCE</h1><br>
			<p><?php echo $ddn; ?></p>
		</div>
		<div class="contenugauche">
			<h1 class="info"> <span> <img class="lien" src="Images/link.png"> </span> <a class="info" href="index.php?page=contact">Contact</a> </h1></br>
		</div>
		<div class="contenugauche">
			<h1 class="info">Présentation</h1><br>
			<p>
				<?php echo $presentation; ?>
			</p>
		<br>
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
				if(!empty($_GET['page'])) {
					switch($_GET['page']) {
						case "formulaire":
						include(CHEMIN_MODULE_FORM_CONTROLER."c_formulaire.php");
						break;
						case "experience":
						include(CHEMIN_MODULE_FORM_CONTROLER."c_experience.php");
						break;
						case "formation":
						include(CHEMIN_MODULE_FORM_CONTROLER."c_formation.php");
						break;
						case "projet":
						include(CHEMIN_MODULE_FORM_CONTROLER."c_projet.php");
						break;
						case "loisir":
						include(CHEMIN_MODULE_FORM_CONTROLER."c_loisir.php");
						break;
						case "competence":
						include(CHEMIN_MODULE_FORM_CONTROLER."c_competence.php");
						break;
						case "deconnexion":
						include(CHEMIN_MODULE_USER_CONTROLER."c_deconnexion.php");
						break;
						case "contact":
						include(CHEMIN_MODULE_USER_VUE."v_contact.php");
						break;
						case "info":
						include(CHEMIN_MODULE_USER_VUE."v_info.php");
						break;
						case "edit":
						include(CHEMIN_MODULE_USER_CONTROLER."c_edit.php");
						break;
						case "profils":
						include(CHEMIN_MODULE_USER_CONTROLER."c_voirTousCv.php");
						break;
						default:
						header('location: index.php?page=info');
						break;
					}
				}
			?>
			</div>
		</div>
	</section>
</div>
