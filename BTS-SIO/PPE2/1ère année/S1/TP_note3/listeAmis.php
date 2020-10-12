<table>
<?php
	$con = mysqli_connect("localhost","root","","tpnote3");
	$req = "SELECT nom, prenom, avatar FROM utilisateurs";
	$res = mysqli_query($con,$req);
	while($ligne = mysqli_fetch_array($res)) {
		echo
		"<tr>
	          <td class='photoListeAmis'><img src=' image/".$ligne['avatar']." ' alt='Mon Avatar'></td>
	          <td class='lienListeAmis'><a href='' class='listeAmis'>".$ligne['prenom']." ".$ligne['nom']."</a></td>
	     </tr>";
	}
	mysqli_close($con);
?>
</table>
