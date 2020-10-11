<?php
echo
"
<div class='contenuCV'>
	<h1 class='titre'> ".$ligne['prenom']." ".$ligne['nom']."</h1><br>
	<h2 class='lieu'> ".$ligne['mail']." </h2><br>
	<p> ".$ligne['presentation']." </p><br>
	<p>Numéro de téléphone :<i> ".$ligne['no_tel']." </i></p><br>
</div>
";
?>
