<div class="body" id="body">
	<div class="insc" id="listeForm">
		<!-- Expérience -->
		<form id="form1" style="">
			<h1 class="titre">Expérience</h1>
			<label>Entreprise</label><br>
			<input type="text" name="entreprise" placeholder="Entreprise" value="test" required><br>
			<label>Intitulé</label><br>
			<input type="text" name="titre" placeholder="Enseigne" value="test" required><br>
			<label>Ville</label><br>
			<input type="text" name="ville" placeholder="Ville" value="test" required><br>
			<label>Date de début / fin</label><br>
			<input type="date" name="dt_deb" placeholder="Date de début" value="1111-01-11" required>
			<input type="date" name="dt_fin" placeholder="Date de fin" value="1111-01-11" required>
			<label>Description</label><br>
			<textarea name="desc" rows="5" cols="50" placeholder="Description de l'expérience (255 caractères)" required>test</textarea><br>
			<button class="connexion" type="button" name="btForm" value="experience" onclick="getExperience(0); prochainFormulaire();">Valider</button>
		</form>
		<!-- Formation -->
		<form id="form2" style="display: none;">
			<h1 class="titre">Formation</h1>
			<label>Formation</label><br>
			<input type="text" name="titre" placeholder="Nom de la formation" required><br>
			<label>Lieu</label><br>
			<input type="text" name="lieu" placeholder="Lieu" required><br>
			<label>Date de début / fin</label><br>
			<input type="date" name="dt_deb" placeholder="Date de début" required>
			<input type="date" name="dt_fin" placeholder="Date de fin" required>
			<label>Titre de votre diplôme</label><br>
			<input type="text" name="diplome" placeholder="Diplôme" required>
			<button class="connexion" type="button" name="btForm" value="formation" onclick="prochainFormulaire(); getExperience(1)">Valider</button>
		</form>
		<!-- Loisirs -->
		<form id="form3" style="display: none;">
			<h1 class="titre">Loisirs</h1>
			<label>Intitulé</label><br>
			<input type="text" name="titre" placeholder="Intitulé du loisir" required><br>
			<label>Description</label><br>
			<textarea name="desc" rows="5" cols="50" placeholder="Description du projet (255 caractères)" required></textarea><br>
			<button class="connexion" type="button" name="btForm" value="loisir" onclick="prochainFormulaire(); getExperience(2)">Valider</button>
		</form>
		<!-- Projets -->
		<form id="form4" style="display: none;">
			<h1 class="titre">Projets</h1>
			<label>Intitulé</label><br>
			<input type="text" name="titre" placeholder="Intitulé du projet" required><br>
			<label>Lieu</label><br>
			<input type="text" name="lieu" placeholder="Dans quel cadre avez-vous réalisé ce projet ?" required><br>
			<label>Description</label><br>
			<textarea name="desc" rows="5" cols="50" placeholder="Description du projet (255 caractères)" required></textarea><br>
			<button class="connexion" type="button" name="btForm" value="projet" onclick="prochainFormulaire(); getExperience(3)">Terminer</button>
		</form>
		<!-- Compétences -->
		<form id="form5" style="display: none;">
			<h1 class="titre">Compétences</h1>
			<label>Développeur</label><br>
			<select name='1'>
			<?php
				$tab = selectCompetenceDev();
				foreach($tab as $key => $ligne) {
					include("v_afficherCompetences.php");
				}
			?>
			</select>
			<button class="connexion" type="button" name="btForm" value="competence" onclick="getExperience(4)">Terminer</button>
		</form>
		<button id="precedent" style="display:none" class="connexion" type="button" name="button" value="btn" onclick="precedentFormulaire();">Revenir au précédent formulaire</button>
		<button id="suivant" style="float: right;" class="connexion" type="button" name="button" value="btn" onclick="prochainFormulaire();">Passer au prochain formulaire</button>
	</div>
</div>
