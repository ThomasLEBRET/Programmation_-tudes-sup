<?php
	function insertExperience($id, $titre, $ville, $dt_deb, $dt_fin, $desc, $entreprise){
		$con = dbConnect();
		if($con) {
			$req = "INSERT INTO experience(id_user,entreprise,titre,ville,dt_deb,dt_fin,description)
					VALUES('$id','$entreprise','$titre','$ville','$dt_deb','$dt_fin','$desc')";
			$res = mysqli_query($con,$req);
			if($res) {
				$ligne = mysqli_fetch_array($res);
			}
		}
		dbDisconnect($con);
	}

	function insertProjet($id, $titre, $lieu, $desc) {
		$con = dbConnect();
		if($con) {
			$req = "INSERT INTO projets(id_user,titre,lieu,description)
					VALUES('$id','$titre','$lieu','$desc')";
			$res = mysqli_query($con,$req);
			if($res) {
				$ligne = mysqli_fetch_array($res);
			}
		}
		dbDisconnect($con);
	}

	function insertLoisir($id, $titre, $desc) {
		$con = dbConnect();
		if($con) {
			$req = "INSERT INTO loisirs(id_user,titre,description)
					VALUES('$id','$titre','$desc')";
			$res = mysqli_query($con,$req);
			if($res) {
				$ligne = mysqli_fetch_array($res);
			}
		}
		dbDisconnect($con);
	}

	function insertFormation($id, $titre, $lieu, $dt_deb, $dt_fin, $diplome) {
		$con = dbConnect();
		if($con) {
			$req = "INSERT INTO formation(id_user,titre,lieu,dt_deb,dt_fin, titre_diplome)
					VALUES('$id','$titre','$lieu','$dt_deb','$dt_fin','$diplome')";
			$res = mysqli_query($con,$req);
			if($res) {
				$ligne = mysqli_fetch_array($res);
			}
		}
		dbDisconnect($con);
	}

	function insertCompetence($id, $competence) {
		$con = dbConnect();
		if($con) {
			$req = "INSERT INTO user_competences(id_user, id_comp)
					VALUES('$id', '$competence')";
			$res = mysqli_query($con,$req);
			if($res) {
				$ligne = mysqli_fetch_array($res);
			}
		}
		dbDisconnect($con);
	}

	function selectExperience($id) {
		$con = dbConnect();
		if($con) {
			$tab = [];
			$req = "	SELECT entreprise, titre, ville, dt_deb, dt_fin, description
					FROM experience
					WHERE id_user = '$id' ";
			$res = mysqli_query($con,$req);
			if($res) {
				while($ligne = mysqli_fetch_array($res)) {
					$tab[] = $ligne;
				}
			}
		}
		dbDisconnect($con);
		return $tab;
	}

	function selectCompetenceDev() {
		$con = dbConnect();
		if($con) {
			$tab = [];
			$req = "SELECT *
					FROM competences
					WHERE id_cat = 1";
			$res = mysqli_query($con,$req);
			if($res) {
				while($ligne = mysqli_fetch_array($res)) {
					$tab[] = $ligne;
				}
			}
		}
		dbDisconnect($con);
		return $tab;
	}

	function selectCompetenceUser($id) {
		$con = dbConnect();
		if($con) {
			$tab = [];
			$req = "SELECT *
					FROM user_competences uc, competences c
					WHERE uc.id_comp = c.id_comp
					AND id_user = 1";
			$res = mysqli_query($con,$req);
			if($res) {
				while($ligne = mysqli_fetch_array($res)) {
					$tab[] = $ligne;
				}
			}
		}
		dbDisconnect($con);
		return $tab;
	}

	function insertPhotoProfil($id, $pdp) {
		if($pdp) {
			$sizemax = 2097152;
			$extValide = array('png','jpg','gif','jpeg');
			if ($pdp['size'] <= $sizemax) {
				 $extUpload = strtolower(substr(strrchr($pdp['name'], '.'), 1));
				 if (in_array($extUpload, $extValide)) {
					$avatar = $id.".".$extUpload;
					$location = "profil/".$avatar;
					$result = move_uploaded_file($pdp['tmp_name'], $location);
					if($result) {
						$con = dbConnect();
						$req = "UPDATE user
								SET imgprofil = '$avatar'
								WHERE id = '$id' ";
						$res = mysqli_query($con,$req);
						dbDisconnect($con);
						return true;
					}
					else
						return false;
			 	 }
			 	 else
				 	return false;
			 }
			 else
			 	return false;
		}
	}
