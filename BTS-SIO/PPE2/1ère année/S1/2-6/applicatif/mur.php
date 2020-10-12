<?php
	session_start();
?>
<!DOCTYPE html>
<html lang="fr" dir="ltr">
	<head>
		<meta charset="utf-8">
		<title>Mur</title>
	</head>
	<body>
		<a href="profil.php">profil</a><br>
		<?php
			if(!empty($_SESSION['login']) AND !empty($_SESSION['password'])) {
				echo $_SESSION['login'];
				echo $_SESSION['password'];
			}
			else {
				header("location: login.htm");
			}
		?>
	</body>
</html>
