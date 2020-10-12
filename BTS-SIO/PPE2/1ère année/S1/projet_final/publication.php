<?php
	$con = mysqli_connect("localhost","root","","tp3");
	$req =
	"SELECT m.id, m.id_utilisateur, m.id_destinataire, m.publication, m.pseudo_envoi, m.date_actuelle, u.avatar
	FROM mur m, utilisateurs u
	WHERE m.id_utilisateur = u.id
	ORDER BY m.id desc";
	$res = mysqli_query($con,$req);
	while($ligne = mysqli_fetch_array($res)) {
		if($ligne['id_utilisateur'] == $_GET['id'] || $ligne['id_destinataire'] == $_GET['id']) {
?>
<h3>
	<a href=<?php echo "index.php?page=profil&id=".$ligne['id_utilisateur'].""; ?>>
	<?php echo $ligne['pseudo_envoi']."<br/>"; ?>
	</a>
</h3>
<img style="width:50px;float:left;" src="image/avatar/<?php echo $ligne['avatar']; ?>" alt="Avatar">
<p><?php echo $ligne['publication']; ?></p>
<i><?php echo $ligne['date_actuelle']; ?></i>
<?php
		}
	}
	mysqli_close($con);
?>
