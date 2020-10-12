<?php
	session_start();
	echo $_SESSION['login'] = "monlogin";
	echo $_SESSION['mdp'] = "monmdp";
	echo "<a href='page8.php'>page8</a>";
?>
