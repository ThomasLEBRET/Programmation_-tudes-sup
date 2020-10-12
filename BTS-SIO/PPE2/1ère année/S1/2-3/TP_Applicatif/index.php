<!DOCTYPE html>
<html lang="fr" dir="ltr">
	<head>
		<meta charset="utf-8">
		<title>2-3 Applicatif</title>
	</head>
	<body>
		<form action="index.php" method="get">
			<table border="1">
				<tr>
					<td>
						<a href="index.php?page=mur">Mur</a>
						<a href="index.php?page=profil">Profil</a>
					</td>
				</tr>
				<tr>
					<td colspan=2>
						<?php
							if(isset($_GET['page'])) {
								switch($_GET['page']) {
									case "mur":
										include("actu.htm");
										break;
									case "profil":
										include("info.htm");
										break;
									default:
										echo "Le changement de valeur dans l'URL est interdit ";
										break;
								}
							}
						 ?>
					</td>
				</tr>
			 </table>
		</form>
	</body>
</html>
