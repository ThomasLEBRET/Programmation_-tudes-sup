<?php
$tab = getAllUser();
echo
"
<form action='index.php?page=profils' method='post'><br />
	<input list='users' name='user'>
	<datalist id='users'>
";
foreach($tab as $key => $ligne) {
	echo "<option name='nom' value='".$ligne['nom']."'>";
}
echo "
</datalist><br /><br />
<input type='submit' name='filtre' value='Filtrer par nom'>
</form>
";
	if($tab) {
		if($_POST) {
			$name = $_POST['user'];
			$tab = getUsersByName($name);
			if(!$tab) {
				echo "La requête n'a rien retournée !";
			}
		}
		foreach($tab as $key => $ligne) {
			include(CHEMIN_MODULE_USER_VUE."v_voirTousCv.php");
		}
	}
?>
