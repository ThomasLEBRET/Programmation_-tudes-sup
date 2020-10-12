<?php

//___________________________Connexion_______________________________________________
function getPdo()
{
	$serveur='mysql:host=localhost';
	$bdd='dbname=citytransports';   		
	$user='root' ;
	$mdp='' ;

	$pdo = new PDO($serveur.';'.$bdd, $user, $mdp);
	$pdo->query("SET CHARACTER SET utf8");
	$pdo->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
	set_time_limit(0);
	if($pdo == null) die("There was a problem !");
	return $pdo;
}

// _________________________________________inscription_________________________________________________________________________

function insertInscription($pdo, $nom, $prenom, $sexe, $dateNaissance, $email, $rue, $cp, $ville, $mdp, $actif, $derniere_connexion, $derniere_ip, $solde)
{

	$sql = ("insert into utilisateur values('".$email."','". $sexe."', '".$nom."', '".$prenom."', '".$dateNaissance."', '".$rue."', '".$cp."', '".$ville."', '".$mdp."', ".$actif.", '".$derniere_connexion."', '".$derniere_ip."', ".$solde.",false);");

	try
	{
		$pdo->query($sql);
	}catch(PDOException $e)
	{
		echo $e->getMessage();
	}

}

//________________________________________Villes____________________________________________________________________________________
	function getVilles($pdo)
	{
			$req = "select * from villes";
			$res = $pdo->query($req);
			$villes = $res->fetchAll();
			return $villes;
	}
		function getCp($pdo)
	{
			$req = "select Code_postal from villes";
			$res = $pdo->query($req);
			$cp = $res->fetchAll();
			return $cp;
	}

//______________________________________________Incidents__________________________________________________________________________________________

	function getIncidents($pdo)
	{
			$req = "select * from incident where current_date < date_fin_incident order by date_debut_incident";
			$res = $pdo->query($req);
			$incidents = $res->fetchAll();
			return $incidents;
	}
//______________________________________________Users______________________________________________________________________________________________
		function getuser($pdo, $email)
	{
			$req = "select email, nom, prenom, sexe, date_de_naissance, rue, code_postal, ville, solde from utilisateur where email='".$email."'";
			$res = $pdo->query($req);
			$users = $res->fetchAll();
			return $users;
	}
//_________________________________________________Trajets________________________________________________________________________________________
function getTrajets($pdo)
	{
			$req = "select station_depart, station_destination, duree_trajet from reliers";
			$res = $pdo->query($req);
			$trajets = $res->fetchAll();
			return $trajets;
	}

function getStationId($pdo, $nom_station)
	{
			$req = "select id from stations where nom_station like'%".$nom_station."%'";
			$res = $pdo->query($req);
			$id = $res->fetchAll();
			return $id;
	}
function getStationName($pdo, $id)
	{
			$req = "select nom_station from stations where id =".$id;
			$res = $pdo->query($req);
			$nom_station = $res->fetchAll();
			return $nom_station;
	}
function getTrajetInfo($pdo, $condition)
	{//natural join parcourirs
			$req = "select * from reliers where ".$condition;
			$res = $pdo->query($req);
			$infoT = $res->fetchAll();
			return $infoT;
	}
?>
