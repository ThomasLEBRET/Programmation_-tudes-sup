<?php
		if(!empty($_POST)) {
			$nom = $_POST['nom'];
			$prenom = $_POST['prenom'];
			$ddn = $_POST['ddn'];
			$mail = $_POST['mail'];
			$password = $_POST['password'];
			$password2 = $_POST['password2'];
			$no_tel = $_POST['no_tel'];
			$presentation = $_POST['presentation'];
			if ($password == $password2) {
				$con = dbConnect();
				if($con) {
					$res = insertUser($con, $nom, $prenom, $ddn, $mail, $password, $no_tel, $presentation);
					$ligne = mysqli_fetch_array($res);
					if($res) {
						$id = mysqli_insert_id($con);
						$_SESSION['iduser'] = $id;
						insertPhotoProfil($id);
					}
					dbDisconnect($con);
					header("location: index.php?page=experience");
				}
				else {
					echo "Problème inconnu.";
				}
			}
			else {
				echo "<p>L'inscription a échouée : Les 2 mots de passes ne sont pas identiques !.</p>\n";
				echo "<a href='index.php?page=inscription'>Cliquez ici pour vous inscrire de nouveau.</p>";
			}
		}
		else {
			include(CHEMIN_MODULE_USER_VUE."v_inscription.html");
		}
?>
