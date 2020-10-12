<?php
	$con = mysqli_connect("localhost","root","","tp3");
	$req = "SELECT * FROM mur";
	$res = mysqli_query($con,$req);
	while($ligne = mysqli_fetch_array($res)) {
		echo $ligne['publication']."<br/>";
	}
	mysqli_close($con);
?>
