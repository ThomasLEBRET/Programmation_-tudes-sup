<?php
	$tab = selectCompetenceUser($id);
	foreach ($tab as $key => $ligne) {
		include(CHEMIN_MODULE_FORM_VUE."v_afficherCompetenceUser.php");
	}
?>
