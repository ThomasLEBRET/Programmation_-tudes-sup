<?php
	session_start();
	if(!empty($_SESSION['login']) && !empty($_POST['publi']) && !empty($_POST['id_dest'])) {
		$id_user = $_SESSION['id'];
		$id_dest = $_POST['id_dest'];
		$publi = $_POST['publi'];
		$pseudo_envoi = $_SESSION['login'];
		$con = mysqli_connect("localhost","root","","tp3");
		$req = "INSERT INTO mur(id_utilisateur,id_destinataire,publication,pseudo_envoi,date_actuelle)
			   VALUES('$id_user',$id_dest,'$publi','$pseudo_envoi',NOW())";
		$res = mysqli_query($con,$req);
	}
	mysqli_close($con);
	header("location: index.php?page=mur&id=".$_POST['id_dest']);
 ?>
