<!DOCTYPE html>
<html lang="fr" dir="ltr">
	<head>
		<meta charset="utf-8">
		<title>2-4 : TP_Applicatif</title>
	</head>
	<body>
		<a href="index.php?var=mur">mur</a>
		<a href="index.php?var=profil">profil</a>
		<?php
			if(isset($_GET['var'])) {
				switch ($_GET['var']) {
					case 'mur':
						include("form.htm");
						include("trt_actu.php");
						break;
				}
			}
		 ?>
	</body>
</html>
