<?php
	if($_POST['login'] != "" AND $_POST['password'] != "" AND $_POST['nom'] != "" AND $_POST['prenom'] != ""
	AND $_POST['ddn'] != "" AND $_POST['sexe'] != "") {
		$login = $_POST['login'];
		$password = password_hash($_POST['password'], PASSWORD_DEFAULT); 
		$nom = $_POST['nom'];
		$prenom = $_POST['prenom'];
		$ddn = $_POST['ddn'];
		$sexe = $_POST['sexe'];
		$con = mysqli_connect("localhost","root","","tp3");
		$req = "INSERT INTO utilisateurs(nom,prenom,login,password,ddn,sexe,avatar) VALUES('$nom','$prenom','$login','$password','$ddn','$sexe','avatar.jpg')";
		$res = mysqli_query($con,$req);
		$ligne = mysqli_fetch_array($res);
		mysqli_close($con);
		header("location: connexion.htm");
	}
	else {
		echo "<p>Un des champs n'est pas rempli ou n'est pas valide.</p>\n";
		echo "<a href='inscription.htm'>Cliquez ici pour vous inscrire de nouveau.</p>";
	}
?>
