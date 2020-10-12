<div class="container mt-5 mb-5 text-white">
	<div class="row text-white">
		<div class="col-md-6 offset-md-3 text-white">
			<h4 class="text-white"><?php echo "<br />Trajet de ".$_POST['depart']." à destination de ".$_POST['destination'].""; echo "<br />Temps de trajet : ".$S[$b][1]." Minutes";?></h4>
			<?php while($i<count($info))
			{
				$ligne = $info[$i][0]['nom_ligne'];
				?>
				<a class="text-white" href="" disabled><?php echo "Ligne : ".$ligne; ?></a>
				<a class="text-white" href="" class="float-right"><?php echo "Direction : ".$info[$i][0]['direction']; ?></a>
				<ul class="timeline1">
					<?php while($i< count($info) && $ligne == $info[$i][0]['nom_ligne']) {

						?>
						<li>
							<p><?php echo $info[$i][0]['nom_station_depart']; ?></p>
						</li>
						<?php $i++;} ?>
						<li>
							<p><?php echo $info[$i-1][0]['nom_station_destination']; ?></p>
						</li>
					</ul>
				<?php } ?>
			</div>
		</div>
	</div>
