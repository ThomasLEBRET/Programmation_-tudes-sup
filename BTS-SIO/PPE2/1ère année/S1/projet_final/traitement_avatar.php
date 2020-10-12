<?php
	session_start();
	if (isset($_FILES['avatar']) AND !empty($_FILES['avatar']['name'])) {
	$sizemax = 2097152;
	$extValide = array('png','jpg','gif','jpeg');
	if ($_FILES['avatar']['size'] <= $sizemax) {
		 $extUpload = strtolower(substr(strrchr($_FILES['avatar']['name'], '.'), 1));
		 if (in_array($extUpload, $extValide)) {
			$id = $_SESSION['id'];
			$avatar = $id.".".$extUpload;
			$location = "image/avatar/".$avatar;
			echo $location;
			$result = move_uploaded_file($_FILES['avatar']['tmp_name'], $location);
			if($result) {
				$con = mysqli_connect("localhost","root","","tp3");
				$req = "UPDATE utilisateurs
						SET avatar = '$avatar'
						WHERE id = '$id' ";
				$res = mysqli_query($con,$req);
				mysqli_close($con);
				header('location: index.php?page=profil');
			}
			else {
	 	 		echo "Si la redirection n'est pas automatique, cliquez <a href='index.php?page=profil'> sur ce lien </a> pour revenir en arrière.";
	 	 	}
	 	 }
	 	 else {
	 	 	echo "Votre photo de profil n'est pas au bon format. Cliquez <a href='index.php?page=profil'> sur ce lien </a> pour revenir en arrière.";
	 	 }
	 }
	 else {
	  	echo "Votre photo de profil dépasse 2Mo.Cliquez <a href='index.php?page=profil'> sur ce lien </a> pour revenir en arrière.";
	  }
	}
?>
