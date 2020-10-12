<?php
$con = mysqli_connect("localhost","root","","2-5TPdid");
$req = "INSERT INTO nom, prenom FROM Personne";
$res = mysqli_query($con,$req);
mysqli_close($con);
header("location: ");
?>
