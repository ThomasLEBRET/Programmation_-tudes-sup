<?php
	$tab = selectExperience($id);
	if($tab) {
		foreach ($tab as $key => $ligne) {
			include(CHEMIN_MODULE_FORM_VUE."v_experience.php");
		}
	}
?>
