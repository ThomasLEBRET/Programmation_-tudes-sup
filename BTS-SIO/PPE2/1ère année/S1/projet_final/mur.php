  <div class="formactu">
    <div class="publication">
	 <form action="trt_publication.php" method="POST">
		 <input type="text" class="publication" name="publi" placeholder="Publier ...">
		 <input type="hidden" name="id_dest" value="<?php echo $_GET['id']; ?>">
     	 <input type="submit" class="publiButton" value="Publier">
	 </form>
    </div>
  </div>
  <div class="actu">
    <div class="actua">
	 <img class="publi" src="image/avatar/<?php echo $_SESSION['avatar']; ?>" alt="Avatar">
	 <a class="publi" href="index.php?page=profil&id=<?php echo $id?>"><font class="titre"><?php echo $_SESSION['login'] ?></font></a><br>
	<?php
		$con = mysqli_connect("localhost","root","","tp3");
		$req =
		"SELECT idChoix, COUNT(idUtDestinataire) AS dmAmis
			FROM demandeamis
			WHERE $id = idUtDemandeur
			AND idChoix = 2
			GROUP BY idChoix";
		$reqD =
		"SELECT idChoix, COUNT(idUtDestinataire) AS recuAmis
			FROM demandeamis
			WHERE $id = idUtDestinataire
			AND idChoix = 2
			GROUP BY idChoix";
		$res = mysqli_query($con,$req);
		$resD = mysqli_query($con,$reqD);
		$ligne = mysqli_fetch_array($res);
		$ligneD = mysqli_fetch_array($resD);
		if ($_GET['id'] != $id) {
			if($ligne['dmAmis'] == 0) {
				echo "<a href='trt_demandeAmis.php?&idUtDestinataire=".$_GET['id']."'>Inviter</a>";
			}
			else {
				echo "<p>Demande en cours</p>";
			}
		}
		else {
			if($ligne['recuAmis'] != NULL) {
				echo "<p>Vous avez ".$ligneD['recuAmis']." demande d'amis !</p></br>";
				echo "<a href='index.php?page=invitationsAmis&id=".$id." '>Voir mes demandes d'amis</a>";
			}
		}
			// if($ligne['nbrAmis'] == 0|| $_GET['id'] != $id) {
			// 	echo "<a href='trt_demandeAmis.php?&idUtDestinataire=".$_GET['id']."'>Inviter</a>";
			// }
			// else if ($ligne['nbrAmis'] > 0) {
			// 	echo "<p>Vous avez ".$ligne['nbrAmis']." demande d'amis !</p></br>";
			// 	echo "<a href='index.php?page=invitationsAmis&id=".$id." '>Voir mes demandes d'amis</a>";
			// }
	?>
	 <br>
	 <font>
		 <?php include("publication.php"); ?>
 	</font>
    </div>
  </div>
