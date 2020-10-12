<?php
if (!empty($_GET['id'])) {
	$id = $_GET['id'];
	$con = mysqli_connect("localhost","root","","tp3");
	$req = "SELECT * FROM utilisateurs WHERE id = '$id'";
	$res = mysqli_query($con,$req);
	$ligne = mysqli_fetch_array($res);
	$nom = $ligne['nom'];
	$prenom = $ligne['prenom'];
	$sexe = $ligne['sexe'];
	$ddn = $ligne['ddn'];
?>
<table>
	<tr>
		<td class="gauche">Nom :</td>
		<td class="droite"><?php echo $nom; ?></td>
	</tr>
	<tr>
		<td class="gauche">Prénom : </td>
		<td class="droite"> <?php echo $prenom; ?></td>
	</tr>
	<tr>
		<td class="gauche">Sexe :</td>
		<td class="droite"><?php echo $sexe; ?></td>
	</tr>
	<tr>
		<td class="gauche">Date de naissance :</td>
		<td class="droite"><?php echo $ddn; ?></td>
	</tr>
	<?php
	if ($_SESSION['id'] != $id) {
		echo
		"<tr>
			<td align='center' colspan='2'><a href='index.php?page=mur&id=".$_GET['id']."'>Voir mon profil</a></td>
		</tr>";
	}
	else {
		echo
		"<tr>
			<td class='gauche'>
			<form  action='traitement_avatar.php' method='post' enctype='multipart/form-data'>
				<input type='file' name='avatar'>
			</td>
			<td class='droite'>
			<input type='submit' value='Envoyer'>
			</form>
			</td>
		</tr>";
	}
?>
</table>
<?php
	}
		else {
?>
<table>
	<tr>
		<td class="gauche">Nom :</td>
		<td class="droite"><?php echo $_SESSION['nom']; ?></td>
	</tr>
	<tr>
		<td class="gauche">Prénom : </td>
		<td class="droite"> <?php echo $_SESSION['prenom']; ?></td>
	</tr>
	<tr>
		<td class="gauche">Sexe :</td>
		<td class="droite"><?php echo $_SESSION['sexe']; ?></td>
	</tr>
	<tr>
		<td class="gauche">Date de naissance :</td>
		<td class="droite"><?php echo $_SESSION['ddn']; ?></td>
	</tr>
</table>
<?php
	}
?>
