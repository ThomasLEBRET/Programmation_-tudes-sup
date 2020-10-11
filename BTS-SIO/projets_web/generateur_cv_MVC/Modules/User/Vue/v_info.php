<?php
echo
"
<div class='contenuCV'>
	<h1 class='titre'> $prenom $nom</h1><br>
	<h2 class='lieu'> $mail </h2><br>
	<p> $presentation </p><br>
	<p>Numéro de téléphone :<i> $noTel </i></p><br>
	<button class='connexion'><a href='index.php?page=edit'>Modifier mes informations</a></button>
</div>
";
?>
