<?php
	session_start();
	echo $_SESSION['login'];
	echo $_SESSION['mdp'];
	session_destroy();
	echo "<a href='page9.php'>page9</a>";
?>
