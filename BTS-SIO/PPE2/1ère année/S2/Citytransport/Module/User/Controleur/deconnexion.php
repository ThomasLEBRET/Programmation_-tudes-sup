<?php
	if(!empty($_SESSION['email'])) {
		closeSession();
		header('location: index.php?page=accueil');
	}
	else {
		header("location: index.php?page=accueil");
	}
