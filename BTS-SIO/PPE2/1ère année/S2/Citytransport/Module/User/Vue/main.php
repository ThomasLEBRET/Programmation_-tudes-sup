<?php
if(empty($_SESSION['email'])) {
	?>

	<div class="jumbotron jumbotron-fluid justify">
		<div class="container">
			<h1 class="display-4">Bienvenu</h1>
			<p class="lead">Si vous n'êtes pas encore inscrit, veuillez vous inscrire ici.</p>
			<p class="lead">Sinon connectez-vous</p>
			<p class="lead">
				<a class="btn btn-primary btn-lg" href="index.php?page=inscription" role="button">S'inscrire</a>
				<a class="btn btn-primary btn-lg" href="index.php?page=connexion" role="button">Se connecter</a>
			</p>
		</div>
	</div>

	<?php
}
else {
	?>

	<div class="jumbotron jumbotron-fluid justify">
		<div class="container">
			<h1 class="display-4">Bienvenu <?php echo $_SESSION['prenom']." ".$_SESSION['nom']; ?> !</h1>
			<h2>Votre solde : <?php echo $_SESSION['solde'] ?>€</h2>
			<h3>Mes données personnelles</h3>
			<p>Email : <a href="mailto: <?php echo $_SESSION['email'] ?> "><?php echo $_SESSION['email'] ?></a></p>
			<p>Date de naissance : <?php echo date($_SESSION['ddn']) ?></p>
			<fieldset>
				<legend>Adresse</legend>
				<p><?php echo $_SESSION['rue'] ?></p>
				<p><?php echo $_SESSION['code_postal']." ".$_SESSION['ville'] ?></p>
			</fieldset>
			<p>Adresse ip : <?php echo $_SESSION['derniere_ip_connue'] ?></p>
			<?php
				if($_SESSION['derniere_connexion'] == date('d/m/Y')) {
					echo "<p>Votre dernière connection remonte au ". $_SESSION['derniere_connexion'].".</p>";
				} else {
					echo "<p>Votre dernière connection remonte du ". $_SESSION['derniere_connexion']." à aujourd'hui.</p>";
				}
			?>
		</div>
	</div>

	<?php
}
