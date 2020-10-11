<?php
	$con = dbConnect();
	$req =
	"SELECT titre, lieu, description
		FROM projets
		WHERE id_user = $id ";
	$res = mysqli_query($con,$req);
	while($ligne = mysqli_fetch_array($res)) {
		include(CHEMIN_MODULE_FORM_VUE."v_projet.php");
	}
?>
