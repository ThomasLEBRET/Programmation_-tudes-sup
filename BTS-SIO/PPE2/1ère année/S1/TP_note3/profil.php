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
