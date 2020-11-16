<?php 
include ("fonctions.php");
enTeteHTML("style.css");
?>
	<form method='post'action='trt_login.php'>
		Login : <input type='text' name='log'/><br/>
		Mot de passe : <input type='text' name='mdp'/><br/>
		<input type='submit' name='validLogin' value='ok'/>
	</form>
<?php piedDePageHTML();?>