<table>
<?php
	$con = mysqli_connect("localhost","root","","tp3");
	$req = "SELECT id, nom, prenom, avatar, idUtDestinataire, idUtDemandeur
			FROM demandeamis, utilisateurs
			WHERE id = idUtDestinataire
			AND idChoix = 1";
	$res = mysqli_query($con,$req);
	while($ligne = mysqli_fetch_array($res)) {
		echo
		"<tr>
	          <td class='photoListeAmis'><img src='image/avatar/".$ligne['avatar']." ' alt='Mon Avatar'></td>
	          <td class='lienListeAmis'> <a href='index.php?page=profil&id=".$ligne['id']." ' class='listeAmis'>".$ligne['prenom']." ".$ligne['nom']."</a> </td>
	     </tr>";
	}
	mysqli_close($con);
?>
</table>
