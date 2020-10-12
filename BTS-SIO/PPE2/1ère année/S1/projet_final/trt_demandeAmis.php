<?php
	session_start();
	$con = mysqli_connect("localhost","root","","tp3");
	$demandeur = $_SESSION['id'];
	$receveur = $_GET['idUtDestinataire'];
	$req = "INSERT INTO demandeamis(idUtDemandeur, idUtDestinataire, idChoix)
			VALUES('$demandeur','$receveur',2)";
	$res = mysqli_query($con,$req);
	$ligne = mysqli_fetch_array($res);
	mysqli_close($con);
	header("location: index.php?page=mur&id=".$receveur."");
?>
