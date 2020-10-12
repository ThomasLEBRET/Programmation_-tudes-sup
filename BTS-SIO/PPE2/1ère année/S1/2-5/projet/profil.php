<?php
	$con = mysqli_connect("localhost","root","","2-5tpdid");
	$req = "SELECT nom,prenom,ddn,sexe FROM utilisateur";
	$res = mysqli_query($con,$req);
	$ligne = mysqli_fetch_array($res);
?>
<table>
	<tr>
		<td class="gauche">Nom :</td>
		<td class="droite"><?php echo $ligne['nom']; ?></td>
	</tr>
	<tr>
		<td class="gauche">Prénom : </td>
		<td class="droite"> <?php echo $ligne['prenom']; ?></td>
	</tr>
	<tr>
		<td class="gauche">Sexe :</td>
		<td class="droite"><?php echo $ligne['sexe']; ?></td>
	</tr>
	<tr>
		<td class="gauche">Date de naissance :</td>
		<td class="droite"><?php echo $ligne['ddn']; ?></td>
	</tr>
</table>
<?php
	mysqli_close($con);
 ?>
