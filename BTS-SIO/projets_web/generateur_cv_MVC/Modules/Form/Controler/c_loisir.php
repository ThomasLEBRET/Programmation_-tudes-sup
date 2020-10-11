<?php
	$con = dbConnect();
	$req =
	"SELECT titre, description
		FROM loisirs
		WHERE id_user = $id";
	$res = mysqli_query($con,$req);
	while($ligne = mysqli_fetch_array($res)) {
		include(CHEMIN_MODULE_FORM_VUE."v_loisir.php");
	}
	dbDisconnect($con);
?>
