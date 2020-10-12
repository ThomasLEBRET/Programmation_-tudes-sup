<?php
	session_start();
	$id = $_SESSION['id'];
	$con = mysqli_connect("localhost","root","","tp3");
	$accepter = $_POST['choix'];
	$refuser = $_POST['choix'];
	if (empty($accepter) && empty($refuser)) {
		echo "<p>Une erreur est survenue.</p></br>";
		echo "<a href='index.php?page=mur?id=".$id." '>Retourner au menu</a>'";
	}
	else {
		if ($accepter == "Accepter") {
			$req = "UPDATE demandeamis
					SET idChoix = 1";
			header("location: index.php?page=mur&id=".$id."");
		}
		else if ($refuser == "Refuser") {
			$req = "UPDATE demandeamis
					SET idChoix = 0";
			header("location: index.php?page=mur&id=".$id."");
		}
		$res = mysqli_query($con,$req);
		$ligne = mysqli_fetch_array($res);
	}
	mysqli_close($con);
?>
