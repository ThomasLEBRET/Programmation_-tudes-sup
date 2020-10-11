<?php
	if(!empty($_POST['mail']) && !empty($_POST['password'])) {
		$mail = $_POST['mail'];
		$password = $_POST['password'];
		$con = dbConnect();
		$req = " 	SELECT *
				FROM user
				WHERE mail = '$mail' AND password = '$password'";
		$res = mysqli_query($con,$req);
		if($ligne = mysqli_fetch_array($res)) {
			startSession();
			$_SESSION['iduser'] = $ligne['id'];
			$_SESSION['nom'] = $ligne['nom'];
			$_SESSION['prenom'] = $ligne['prenom'];
			$_SESSION['ddn'] = $ligne['ddn'];
			$_SESSION['imgprofil'] = $ligne['imgprofil'];
			$_SESSION['mail'] = $mail;
			$_SESSION['password'] = $password;
			$_SESSION['no_tel'] = $ligne['no_tel'];
			$_SESSION['presentation'] = $ligne['presentation'];
			$_SESSION['imgprofil'] = $ligne['imgprofil'];
			$id = $_SESSION['iduser'];
			dbDisconnect($con);
			header("location: index.php?page=info");
		}
		else {
			echo "<p>Mot de passe incorrect !</p></br>";
			echo "<a href='index.php?page=connexion'>Cliquez ici pour vous connecter de nouveau</a>";
		}
	}
	else {
		include(CHEMIN_MODULE_USER_VUE."v_connexion.php");
	}
?>
