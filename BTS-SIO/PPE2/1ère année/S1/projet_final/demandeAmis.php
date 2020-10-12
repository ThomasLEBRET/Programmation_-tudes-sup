<table>
	<?php
		$id = $_SESSION['id'];
		$con = mysqli_connect("localhost","root","","tp3");
		$req = "SELECT id,nom, prenom, avatar
				FROM demandeamis, utilisateurs
				WHERE idUtDestinataire = '$id'
				AND idUtDemandeur = id
				AND idChoix = 2";
		$res = mysqli_query($con,$req);
		while($ligne = mysqli_fetch_array($res)) {
			echo
			"<tr>
		          <td class='photoListeAmis'><img src='image/avatar/".$ligne['avatar']." ' alt='Mon Avatar'></td>
				<td class='lienListeAmis'>
					<a href='index.php?page=profil&id=".$ligne['id']." ' class='listeAmis'>".$ligne['prenom']." ".$ligne['nom']."</a>
					<form method='POST' action='trt_amis.php'>
						<input type='submit' name='choix' value='Accepter'>
						<input type='submit' name='choix' value='Refuser'>
					</form>
				</td>
		     </tr>";
		}
	?>
</table>
