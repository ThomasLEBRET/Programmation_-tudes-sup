<form class="justify" action="index.php?page=profil" method="POST">
	<div class="form-group">
		<label for="exampleInputEmail1">Adresse Mail </label>
		<input name="email" type="email" class="form-control" id="Email" aria-describedby="emailHelp" placeholder="Email">
	</div>
	<div class="form-group">
		<label for="exampleInputEmail1">Mot de passe </label>
		<input name="password" type="password" class="form-control" id="Password" aria-describedby="emailHelp" placeholder="Mot de passe">
	</div>
	<div class="form-row">
		<div class="col-md-6 mb-6">
			<label for="validationCustom04">Nom</label>
			<input name="nom" type="text" class="form-control" id="Nom" placeholder="Doe">
		</div>
		<div class="col-md-6 mb-6">
			<label for="validationCustom05">Prénom </label>
			<input name="prenom" type="text" class="form-control" id="Prenom" placeholder="John">
		</div>
	</div>
	<div class="form-group">
		<label for="validationCustom03">Rue </label>
		<input name="rue" type="text" class="form-control" id="Adrese_Ville" placeholder="404 Rue des Programmeurs">
	</div>
	<div class="form-row">
		<div class="col-md-6 mb-6">
			<label for="validationCustom04">Ville </label>
			<input name="ville" type="text" class="form-control" id="Ville" placeholder="Massy">
		</div>
		<div class="col-md-6 mb-6">
			<label for="validationCustom05">Code Postal </label>
			<input name="cdp" type="text" class="form-control" id="Cd Postal" placeholder="91180">
		</div>
	</div>
	<br>
	<button type="submit" class="btn btn-light">Envoyer</button>
</form>
