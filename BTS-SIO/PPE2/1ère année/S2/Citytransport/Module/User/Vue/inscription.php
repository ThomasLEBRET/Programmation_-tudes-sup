	<div class="justify text-light">
	<form action="index.php?page=inscription" method="POST" id="insc" name="form">
		<div class="form-group mx-sm-3 mb-2">
			<label for="email">Adresse Mail</label>
			<input name="email" type="email" class="form-control" id="inputAddress2" placeholder="nomxyz@domain.com">
		</div>
		<div class="form-group mx-sm-3 mb-2">
			<label for="nom">Nom</label>
			<input name="nom" type="text" class="form-control" id="nom" placeholder="Nom de famille">
		</div>
		<div class="form-group mx-sm-3 mb-2">
			<label for="prenom">Prénom</label>
			<input name="prenom" type="text" class="form-control" id="prenom" placeholder="Prénom">
		</div>
		<div class="form-group mx-sm-3 mb-2">
			<label for="ddn">Date de Naissance</label>
			<input name="ddn" type="date" class="form-control" id="ddn" placeholder="01/01/2000">
		</div>
		<div class="form-group mx-sm-3 mb-2">
			<label for="rue">Rue</label>
			<input name="rue" type="text" class="form-control" id="adress" placeholder="4 Rue des Cerisiers">
		</div>
		<div class="form-row mx-sm-3 mb-2">
			<div class="form-group col-md-6">
				<label for="ville">Ville</label>
				<input name="ville" type="text" class="form-control" id="ville" placeholder="Massy">
			</div>
			<div class="form-group col-md-6">
				<label for="cdp">Code Postal</label>
				<input name="cdp" type="number" class="form-control" id="cdp" placeholder="91300">
			</div>
		</div>
		<div class="form-row mx-sm-3 mb-2">
			<div class="form-group col-md-6">
				<div class="form-group">
					<label for="psw">Mot de passe</label>
					<input name="psw" type="password" class="form-control" id="psw" placeholder="********" oninput="verifPsw()">
				</div>
			</div>
			<div class="form-group col-md-6">
				<label for="psw2">Confirmer le Mot de Passe</label>
				<input name="psw2" type="password" class="form-control" id="psw2" placeholder="********" oninput="verifPsw()">
			</div>
		</div>
		<div class="form-group col-md-6 mx-sm-3 mb-2">
			<input type= "radio" name="sexe" value="H"> Homme <br>
			<input type= "radio" name="sexe" value="F"> Femme <br>
			<input type= "radio" name="sexe" value="A"> Autre <br>
		</div>
		<input type="submit" class="btn btn-outline-light" data-toggle="modal" data-target="#exampleModal" name="valid" value="S'inscrire">
		<button type="reset" class="btn btn-outline-danger">Vider le formulaire</button>
	</form>
</div>
