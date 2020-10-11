<?php
	function dbConnect() {
		$host = 'localhost';
		$user = "root";
		$pwd = "";
		$dbname = "cv";
		$con = mysqli_connect($host,$user,$pwd,$dbname);
		if(!$con) {
			return false;
		}
		return $con;
	}

	function dbDisconnect($con) {
		mysqli_close($con);
		return true;
	}

	function startSession() {
		if(empty($_SESSION)) {
			session_start();
		}
	}

	function closeSession() {
		if($_SESSION) {
			session_unset();
			session_destroy();
		}
	}
?>
