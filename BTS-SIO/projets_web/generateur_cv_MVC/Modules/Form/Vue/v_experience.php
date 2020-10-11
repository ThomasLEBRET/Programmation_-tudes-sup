<?php
	echo "<div class='contenuCV'>
		<h1 font-size: 18pt;' class='titre'>".$ligne['entreprise']."</h1>
		<h1 class='titre'>".$ligne['titre']."</h1>
		<h2 class='lieu'>Lieu : " .$ligne['ville']."</h2>
		<h2 class='lieu'>Du <i>" .$ligne['dt_deb']. "</i> au <i>".$ligne['dt_fin']."</i></h2>
		<p>
			".$ligne['description']."
		</p>
		<br>
	</div>";
?>
