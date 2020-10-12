<?php
	/**
	 * Liste les incidents
	 * @return $res un tableau de résultats issu des données de la table incident et type_incident
	 */
	function listeIncident() {
		$con = dbConnect();
		if($con) {
			$req = "SELECT *
			FROM incident i, type_incident ti
			WHERE i.cd_incident = ti.cd_incident
			AND i.dt_fin_inc IS NULL";
			$res = mysqli_query($con, $req);
			if($res) {
				dbDisconnect($con);
				return $res;
			}
		}
		dbDisconnect($con);
		return false;
	}

	/**
	 * Obtient les informations d'un trajet
	 * @param  PDO 	$pdo       une connexion PDO
	 * @param  string 	$condition une condition
	 * @return array            	 un tableau d'informations
	 */
	function getTrajetInfo($pdo, $condition) {
		$req = "select * from reliers where ".$condition;
		$res = $pdo->query($req);
		$infoT = $res->fetchAll();
		return $infoT;
	}

	/**
	 * Obtient l'id d'une station
	 * @param  PDO 	$pdo         une connexion PDO
	 * @param  string 	$nom_station un nom de station existant
	 * @return int $id               un identifiant de station existant
	 */
	function getStationId($pdo, $nom_station) {
		$req = "select id from stations where nom_station like'%".$nom_station."%'";
		$res = $pdo->query($req);
		$id = $res->fetchAll();
		return $id;
	}

	/**
	 * Créé une connexion de type PDO
	 * @return PDO $pdo une connexion PDO
	 */
	function getPdo() {
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

	/**
	 * Obtient la liste des trajets
	 * @param  PDO $pdo 		une connexion au format PDO
	 * @return array $trajets	un tableau de trajets
	 */
	function getTrajets($pdo) {
		$req = "select station_depart, station_destination, duree_trajet from reliers";
		$res = $pdo->query($req);
		$trajets = $res->fetchAll();
		return $trajets;
	}

	/**
	 * Met à jour l'historique d'un utilisateur lorsqu'il effectue une recherche une fois inscrit et connecté
	 * @param string $depart  une station de départ
	 * @param string $arrivee une station d'arrivée
	 */
	function setHistoriqueUser($depart, $arrivee) {
		if($depart == "" || $arrivee == "") {
			return false;
		}
		if($depart == $arrivee) {
			return false;
		}
		$con = dbConnect();
		if($con) {
			$mail = $_SESSION['email'];
			$req = "INSERT INTO historique_voyage (station_depart, station_arrivee, date_voyage, email)
			VALUES ('$depart', '$arrivee', NOW(), '$mail')";
			$res = mysqli_query($con, $req);
			if($res) {
				dbDisconnect($con);
				return true;
			}
		}
		dbDisconnect($con);
		return false;
	}

	/**
	 * Obtient l'historique de recherche d'un utilisateur
	 * @param  string $mail 		une adresse email
	 * @return array  $tab[]      tableau de trajets issu de l'historique
	 */
	function getHistoriqueByUser($mail) {
		if(!checkEmail($mail)) {
			return false;
		}
		$con = dbConnect();
		if($con) {
			$mail = $_SESSION['email'];
			$req = "SELECT *
			FROM historique_voyage
			WHERE email = '$mail'";
			$res = mysqli_query($con, $req);
			if($res) {
				$tab = [];
				while ($ligne = mysqli_fetch_array($res)) {
					$tab[] = $ligne;
				}
				dbDisconnect($con);
				return $tab;
			}
		}
		dbDisconnect($con);
		return $tab;
	}
