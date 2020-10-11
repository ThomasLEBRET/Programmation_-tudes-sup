<form class="insc" action="index.php?page=edit" method="post" enctype="multipart/form-data">
	<label>Nom</label><br>
	<input type="text" name="nom" placeholder="Nom"><br>
	<label>Prénom</label><br>
	<input type="text" name="prenom" placeholder="Prénom"><br>
	<label>Date de naissance</label><br>
	<input type="date" name="ddn" placeholder="Prénom"><br>
	<label>Photo de profil</label><br>
	<input type="file" name="pdp" placeholder="Photo de profil"><br>
	<label>Mail</label><br>
	<input type="email" name="mail" placeholder="example.domain.com"><br>
	<label>N° Téléphone</label><br>
	<input type="number" name="no_tel"><br>
	<label>Présentation</label><br>
	<textarea name="presentation" rows="5" cols="50" placeholder="Présente toi !"></textarea><br>
	<input type="submit" name="envoi" value="Envoyer">
</form>
