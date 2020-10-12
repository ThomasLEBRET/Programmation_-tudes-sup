<?php
if(!empty($_POST['depart']) && !empty($_POST['destination'])) {
	$pdo = getPdo();
	$trajets= getTrajets($pdo);
	$_distArr = array();
	foreach($trajets as $route) {
		$_distArr[$route['station_depart']][$route['station_destination']]= $route['duree_trajet'];
	}
	$depart = getStationId($pdo, $_POST['depart']);
	$destination = getStationId($pdo, $_POST['destination']);
	if(count($depart) <= 0 || count($destination) <= 0) {
		echo "nom de station inconnu !";
	} else {
		$a = $depart[0]['id'];
		$b = $destination[0]['id'];
		$Q = array();
		foreach(array_keys($_distArr) as $val)$Q[$val] = 99999;
		$Q[$a] = 0;
		while(!empty($Q)){
			$min = array_search(min($Q), $Q);
			if($min == $b) break;
			foreach($_distArr[$min] as $key=>$val) if(!empty($Q[$key]) && $Q[$min] + $val < $Q[$key]) {
				$Q[$key] = $Q[$min] + $val;
				$S[$key] = array($min, $Q[$key]);
			}
			unset($Q[$min]);
		}
		$path = array();
		$pos = $b;
		while($pos != $a) {
			$path[] = $pos;
			$pos = $S[$pos][0];
		}
		$path[] = $a;
		$path = array_reverse($path);
		$path4 = array();
		$path3 ="";
		$count =0;
		$start=true;
		$dep=false;
		$info= array();
		foreach($path as $v => $idt) {
			if($count == 0) {
				$path4[]=$idt;
				$count ++;
			} else if($count<count($path)-1) {
				$path4[]=$idt;
				$path4[]=$idt;
				$count ++;
			} else if($count<count($path)) {
				$path4[]=$idt;
				$count ++;
			}
		}

		foreach($path4 as $v => $idt) {
			if($start == true) {
				$path3 = "station_depart =".$idt." and";
				$start = false;
			} else if($dep == false) {
				$path3=$path3." station_destination =".$idt;
				$dep = true;
				$info[]=getTrajetInfo($pdo, $path3);
			} else {
				$path3 = " station_depart =".$idt." and";
				$dep=false;
			}
		}
		$i=0;
		$ligne = $info[0][0]['nom_ligne'];
		if($_SESSION) {
			setHistoriqueUser($_POST['depart'], $_POST['destination']);
		}
		include(CHEMIN_MODULE_TRAJET_VUE."resultatTrajet.php");
	}
} else if ($_POST) {
	echo
	"
	<div class='alert alert-danger' role='alert'>
	<strong>Votre recherche d'itinéraire n'a pas pu aboutir !</strong>
	<button type='button' class='close' data-dismiss='alert' aria-label='Close'>
	<span aria-hidden='true'>&times;</span>
	</button>
	</div>
	";
}
include(CHEMIN_MODULE_TRAJET_VUE."itineraire.php");
