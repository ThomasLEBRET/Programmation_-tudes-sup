<?php

/**
* Réalise une connexion de type mysqli
* @return $con une connexion mysqli
*/
function dbConnect() {
	$host = 'localhost';
	$user = "root";
	$pwd = "root";
	$dbname = "gatci";
	$con = mysqli_connect($host,$user,$pwd,$dbname);

	if(!$con) {
		return false;
	}
	return $con;
}

/**
* Déconnection de la base de données
* @param  mysqli $con 	une connexion mysqli
* @return bool 		true
*/
function dbDisconnect($con) {
	mysqli_close($con);
	return true;
}

/**
* Démarre une session si elle n'existe pas
*/
function startSession() {
	if(empty($_SESSION)) {
		session_start();
	}
	return true;
}

/**
* @param $mail
* @return bool
* Détruit une session en déchargeant le tableau $_SESSION. Met l'activité de l'utilisateur à 0
*/
function closeSession() {
	if($_SESSION) {
		session_unset();
		session_destroy();
		return true;
	} else {
		return false;
	}
}
