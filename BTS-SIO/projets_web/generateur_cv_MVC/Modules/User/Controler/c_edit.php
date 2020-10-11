<?php
	if(!empty($_POST)) {
		$postNom = $_POST['nom'];
		$postPrenom = $_POST['prenom'];
		$postDdn = $_POST['ddn'];
		$postMail = $_POST['mail'];
		$postNoTel = $_POST['no_tel'];
		$postPdp = $_FILES['pdp'];
		$postPresentation = $_POST['presentation'];
		if($postNom == "")
			$postNom = $_SESSION['nom'];
		if($postPrenom == "")
			$postPrenom = $_SESSION['prenom'];
		if($postDdn == "")
			$postDdn = $_SESSION['ddn'];
		if($postNoTel == "")
			$postNoTel = $_SESSION['no_tel'];
		if($postPresentation == "")
			$postPresentation = $_SESSION['presentation'];
		if($postMail == "")
			$postMail = $_SESSION['mail'];
		$con = dbConnect();
		if($con) {
			$res = modifUser($con, $id, $postNom, $postPrenom, $postDdn, $postMail, $postNoTel, $postPresentation);
			$photoProfil = insertPhotoProfil($id, $postPdp);
			if($res && $id)
				header('location: index.php?page=edit');
			else
				echo "La modification a échouée !";
			dbDisconnect($con);
		}
		else
			echo "erreur";
	}
	else
		include(CHEMIN_MODULE_USER_VUE."v_edit.php");
?>
