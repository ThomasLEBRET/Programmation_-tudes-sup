  <div class="formactu">
    <div class="publication">
	 <form action="index.php?page=mur" method="post">
		 <input type="text" class="publication" name="publi" placeholder="Publier ...">
     	 <input type="submit" class="publiButton" value="Publier">
	 </form>
    </div>
  </div>
  <div class="actu">
    <div class="actua">
	 <img class="publi" src="image/avatar.jpg" alt="Mon Avatar">
	 <a class="publi" href="#"><font class="titre">Stan Marsh</font></a><br>
	 <font>
		 <?php
		 	if(isset($_POST['publi'])) {
				echo $_POST['publi'];
			}
		 ?>
 	</font>
    </div>
  </div>
