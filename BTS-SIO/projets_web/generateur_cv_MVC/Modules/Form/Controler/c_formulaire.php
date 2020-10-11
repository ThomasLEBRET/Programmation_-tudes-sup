<?php
	if($_POST) {
		startSession();
		$id = $_SESSION['iduser'];
		$btn = $_POST['btForm'];
		switch($btn) {
			case 'experience':
				insertExperience($id, $_POST['titre'], $_POST['ville'], $_POST['dt_deb'], $_POST['dt_fin'],
				$_POST['desc'], $_POST['entreprise']);
				break;
			case 'formation':
				insertFormation($id, $_POST['titre'], $_POST['lieu'],
				$_POST['dt_deb'], $_POST['dt_fin'], $_POST['diplome']);
				break;
			case 'loisir':
				insertLoisir($id, $_POST['titre'], $_POST['desc']);
				break;
			case 'projet':
				insertProjet($id, $_POST['titre'], $_POST['lieu'], $_POST['desc']);
				break;
			case 'competence':
				insertCompetence($id, $_POST['1']);
				break;
		}
		include(CHEMIN_MODULE_FORM_VUE."v_formulaire.php");
	}
	else {
		include(CHEMIN_MODULE_FORM_VUE."v_formulaire.php");
	}
?>
