<?php
	
	if (isset($_SESSION['LAST_ACTIVITY']) && (time() - $_SESSION['LAST_ACTIVITY'] > 1800)) {
		// last request was more than 30 minutes ago
		session_unset();     // unset $_SESSION variable for the run-time 
		session_destroy();   // destroy session data in storage
	}
	else
	{
		$_SESSION['LAST_ACTIVITY'] = time();
		if( !isset($_SESSION['last_access']) || (time() - $_SESSION['last_access']) > 60 )
		$_SESSION['last_access'] = time();
	}
?>
<!doctype html>
<html>
	<head>
		<meta charset="utf-8" />
		<title> City Transport </title>
		<link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css" integrity="sha384-Vkoo8x4CGsO3+Hhxv8T/Q5PaXtkKtu6ug5TOeNV6gBiFeWPGFN9MuhOf23Q9Ifjh" crossorigin="anonymous">
		<script src="https://code.jquery.com/jquery-3.4.1.slim.min.js" integrity="sha384-J6qa4849blE2+poT4WnyKhv5vZF5SrPo0iEjwBvKU7imGFAV0wwj1yYfoRSJoZ+n" crossorigin="anonymous"></script>
		<script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js" integrity="sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo" crossorigin="anonymous"></script>
		<script src="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js" integrity="sha384-wfSDF2E50Y2D1uUdj0O3uMBJnjuUD4Ih7YwaYd1iqfktj0Uod8GCExl3Og8ifwB6" crossorigin="anonymous"></script>
		<link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.0.8/css/all.css">
		<link rel="stylesheet" type="text/css" href="style/style.css" />
	</head>
	<body>
		<header>
		</header>
		<nav class="navbar navbar-expand-lg navbar-dark bg-dark">
		  <a class="navbar-brand" href="#"> <img src="img/Bus-512.png" alt="logo" width="30" height="30" class="d-inline-block align-top"/> </a>
		  <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarNavAltMarkup" aria-controls="navbarNavAltMarkup" aria-expanded="false" aria-label="Toggle navigation">
			<span class="navbar-toggler-icon"></span>
		  </button>
		  <div class="collapse navbar-collapse" id="navbarNavAltMarkup">
			<div class="navbar-nav">
			  <a class="nav-item nav-link" href="#">Inscription </a>
			  <a class="nav-item nav-link" href="#">Connexion</a>
			  <a class="nav-item nav-link" href="simulertrajet.php">Simuler un trajet</a>
			  <a class="nav-item nav-link" href="#">Etat du trafic</a>
			 
			</div>
		  </div>
		</nav>
		
	<script>	
		$(function(){
			// this will get the full URL at the address bar
			var url = window.location.href; 

			// passes on every "a" tag 
			$("a").each(function() {
					// checks if its the same on the address bar
				if(url == (this.href)) { 
					$(this).addClass("active");
				}
			});
		});
	</script>