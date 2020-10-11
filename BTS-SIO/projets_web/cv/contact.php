<!DOCTYPE html>
<html lang="fr" dir="ltr">
	<head>
		<meta charset="utf-8">
		<title>CV-Thomas LEBRET</title>
		<link rel="stylesheet" href="css/main.css">
		<meta name="viewport" content="width=device-width, initial-scale=1.0">
	</head>
	<body>
		<?php include("header.html"); ?>
		<div class="contact">
			<form class="contact" action="trt_contact.php" method="post">
				<h1 class="titre">CONTACT</h1>
				<label>Adresse e-mail</label></br>
				<input type="email" name="mail" placeholder="@mail" required></br>
				<label>Sujet de votre message</label></br>
				<input type="text" name="sujet" placeholder="Sujet" required></br>
				<label>Message</label></br>
				<textarea name="message" rows="5" cols="50" placeholder="Message..." required></textarea><br>
				<input type="submit" name="envoi" value="Envoyer">
			</form>
		</div>
	</body>
</html>
