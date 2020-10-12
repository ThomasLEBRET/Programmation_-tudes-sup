<?php

/**
* Tente de connecter un utilisateur
* @param  string $cdUser : le code utilisateur
* @param  string $mdp    : un mot de passe
* @return bool           : true si l'utilisateur arrive à s'inscrire sans incident, false sinon
*/
function logUser($cdUser, $mdp) {
    $con = dbConnect();
    if($con) {
        $req = "
        SELECT *
        FROM COMPTE
        WHERE USER = '$cdUser'
        AND MDP = '$mdp'";
        $res = mysqli_query($con, $req);
        if($ligne = mysqli_fetch_array($res)) {
            $_SESSION['USER'] = $ligne['USER'];
            $_SESSION['NOMCOMPTE'] = $ligne['NOMCOMPTE'];
            $_SESSION['PRENOMCOMPTE'] = $ligne['PRENOMCOMPTE'];
            $_SESSION['DATEINSCRIP'] = $ligne['DATEINSCRIP'];
            $_SESSION['TYPEPROFIL'] = $ligne['TYPEPROFIL'];
            $_SESSION['DATEDEBSEJOUR'] = $ligne['DATEDEBSEJOUR'];
            $_SESSION['DATEFINSEJOUR'] = $ligne['DATEFINSEJOUR'];
            $_SESSION['DATENAISCOMPTE'] = $ligne['DATENAISCOMPTE'];
            $_SESSION['ADRMAILCOMPTE'] = $ligne['ADRMAILCOMPTE'];
            $_SESSION['NOTELCOMPTE'] = $ligne['NOTELCOMPTE'];
            dbDisconnect($con);
            return true;
        }
    }
    dbDisconnect($con);
    return false;
}
