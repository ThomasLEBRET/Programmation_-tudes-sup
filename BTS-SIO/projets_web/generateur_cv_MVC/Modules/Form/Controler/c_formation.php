<?php
	$con = dbConnect();
	$req =
	"SELECT titre, lieu, dt_deb, dt_fin, titre_diplome
		FROM formation
		WHERE id_user = $id ";
	$res = mysqli_query($con,$req);
	while($ligne = mysqli_fetch_array($res)) {
		include(CHEMIN_MODULE_FORM_VUE."v_formation.php");
	}
	dbDisconnect($con);
?>
