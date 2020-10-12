<?php
	$con = mysqli_connect("localhost","root","","2-5TPdid");
	$req = "SELECT nom, prenom FROM Personne";
	$res = mysqli_query($con,$req);
	while($ligne = mysqli_fetch_array($res)) {
		echo $ligne['nom']." ".$ligne['prenom']."<br/>";
	}
	mysqli_close($con);
?>
