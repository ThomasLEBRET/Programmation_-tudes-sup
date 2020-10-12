<table class="amis">
	<tr class="photo">
		<td colspan="2">
			<font class="titre">Amis</font>
		</td>
	</tr>
	<?php
		$avatar = $_SESSION['avatar'];
		$con = mysqli_connect("localhost","root","","tp3");
		$req = "SELECT id, avatar
				FROM utilisateurs 
				WHERE avatar != '$avatar'";
		$res = mysqli_query($con,$req);
		while ($ligne = mysqli_fetch_array($res)) {
	?>
	<?php echo
	"<tr class='photo'>
		<td > <a href='index.php?page=profil&id=".$ligne['id']."'> <img src='image/avatar/".$ligne['avatar']."' alt='Avatar '></a></td>";
		$ligne = mysqli_fetch_array($res);
		echo "<td > <a href='index.php?page=profil&id=".$ligne['id']."'> <img src='image/avatar/".$ligne['avatar']."' alt='Avatar '></a></td>
	</tr>";
	 ?>

<?php
	}
	mysqli_close($con);
?>
</table>
