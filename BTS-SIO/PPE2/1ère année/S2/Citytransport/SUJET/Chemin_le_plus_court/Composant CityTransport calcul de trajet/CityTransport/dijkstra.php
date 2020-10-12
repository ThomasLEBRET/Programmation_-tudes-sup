<?php 
	session_start();
	if (!isset($_SESSION['email'])) 
	{
		include('top.php');
	}
	else include('topC.php');
	
	include('model_crud.php');
	
	//________________________Connexion DB_____________________
	$pdo = getPdo();
	
	//________________________Récupérer la liste des trajets avec la durée_______________________________
	$trajets= getTrajets($pdo);
	
	//__________________________________________________Préparation du tableau des distances(ici des temps de trajet)_______________________________________________
	$_distArr = array();
	foreach($trajets as $route)
	{
		$_distArr[$route['station_depart']][$route['station_destination']]= $route['duree_trajet'];
	}


	//__________________________________Récupération des id des stations de départ et d'arrivée___________________
	$depart = getStationId($pdo, $_POST['depart']);
	$destination = getStationId($pdo, $_POST['destination']);

		//echo $depart->rowCount() ;
	if(count($depart) <= 0 || count($destination) <= 0)//____________vérifier si les noms des stations demandées par l'utilisateur existent ou pas dans la BDD 
	{
		echo "nom de station inconnu !";
	}
	else
	{
		$a = $depart[0]['id'];// station de départ
		$b = $destination[0]['id'];//station d'arrivée
	






		//initialize the array for storing
		$S = array(); //Le chemin le plus proche avec son parent et son poid
		$Q = array();//Les noeuds de gauche sans le chemin le plus proche

			
		foreach(array_keys($_distArr) as $val)$Q[$val] = 99999; 
		$Q[$a] = 0;

		//Commencer à calculer
		while(!empty($Q)){
			$min = array_search(min($Q), $Q);//Le plus petit poids 
			if($min == $b) break;
			foreach($_distArr[$min] as $key=>$val) if(!empty($Q[$key]) && $Q[$min] + $val < $Q[$key]) {
				$Q[$key] = $Q[$min] + $val;
				$S[$key] = array($min, $Q[$key]);
			}
			unset($Q[$min]);
		}

		//lister le trajet
		$path = array();
		$pos = $b;
		while($pos != $a){
			$path[] = $pos;
			$pos = $S[$pos][0];
		}
		$path[] = $a;
		$path = array_reverse($path);//___________le trajet est enregistré ici sous forme d'une succession de numéros de stations : 1->2->3->4...
		
		

		
		//----------------------------------------------------------Récupérer les noms des stations et formater le trajet pour l'affichage---------------------------------
		$path4 = array();
		$path3 ="";
		$count =0;
		$start=true;
		$dep=false;
		$info= array();
		foreach($path as $v => $idt)//___________formater le trajet suivant le modèle : 1->2  2->3  3->4 ...  (une succession de sous-trajets)
		{
			if($count == 0)
			{
				$path4[]=$idt;
				$count ++;
			}
			else if($count<count($path)-1){
				$path4[]=$idt;
				$path4[]=$idt;
				$count ++;
			}
			else if($count<count($path))
			{
				$path4[]=$idt;
				$count ++;
			}
			
		}
		
		foreach($path4 as $v => $idt) //_____________Récupérer pour chaque sous-trajet les informations des stations (nom_station , nom_ligne ...)
		{
			if($start == true) 
			{
				$path3 = "station_depart =".$idt." and"; 
				$start = false;	
			}
			else if($dep == false)
			{
				$path3=$path3." station_destination =".$idt;
				$dep = true;
				$info[]=getTrajetInfo($pdo, $path3);
			}
			else
			{
				$path3 = " station_depart =".$idt." and";
				$dep=false;
			}
		}
		$i=0;
		$ligne = $info[0][0]['nom_ligne']; 
?>

<!-- ************************** Affichage du Résultat du calcul de trajet *****************************-->		
		<div class="container mt-5 mb-5">
			<div class="row">
				<div class="col-md-6 offset-md-3">
					<h4><?php echo "<br />Trajet de ".$_POST['depart']." à destination de ".$_POST['destination'].""; echo "<br />Temps de trajet : ".$S[$b][1]." Minutes";?></h4>
					<?php while($i<count($info))
							{
								$ligne = $info[$i][0]['nom_ligne']; //echo "Ligne : ".$ligne;
					?>
					<a target="_blank" href="#" disabled><?php echo "Ligne : ".$ligne; ?></a>
					<a href="#" class="float-right"><?php echo "Direction : ".$info[$i][0]['direction']; ?></a>
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


<?php
	}
include('bot.html');

?>