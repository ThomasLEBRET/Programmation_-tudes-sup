<?php
include_once("requetes.php");

/**
* @param void
* @return bool: true si le code existe pour une animation, false sinon
*/
function estCdAnimationValide($cdAnim) {
    $tab = getAllAnimationValides();
    for ($i=0; $i < count($tab) ; $i++) {
        if($tab[$i]['CODEANIM'] == $cdAnim)
        return true;
    }
    return false;
}

/**
* @param void
* @return $tab : un tableau associatif des animations valides
*/
function getAllAnimationValides() {
    $tab = [];
    $con = dbConnect();
    if($con) {
        $req = "SELECT *
        FROM ANIMATION AN, ACTIVITE A
        WHERE AN.CODEANIM = A.CODEANIM
        AND AN.NBREPLACEANIM > 0
        AND AN.DATEVALIDITEANIM > DATE(NOW())
        AND A.CODEETATACT = 'O'
        ";
        $res = mysqli_query($con, $req);
        while(($ligne = mysqli_fetch_array($res))) {
            $tab[] = $ligne;
        }
    }
    dbDisconnect($con);
    return $tab;
}

/**
* @param void
* @return $tab : un tableau associatif des animations
*/
    function getAllAnimations() {
    $tab = [];
    $con = dbConnect();
    if($con) {
        $req = "SELECT * FROM ANIMATION
        ";
        $res = mysqli_query($con, $req);
        while(($ligne = mysqli_fetch_array($res))) {
            $tab[] = $ligne;
        }
    }
    dbDisconnect($con);
    return $tab;
}

/**
* @param void
* @return $tab : un tableau associatif des activites par rapport à son code d'animation
*/
function getActivite($cdAct) {
    $tab = [];
    $con = dbConnect();
    if($con) {
        $req = "SELECT * FROM ACTIVITE WHERE CODEANIM = '$cdAct'";
        $res = mysqli_query($con, $req);
        while(($ligne = mysqli_fetch_array($res))) {
            $tab[] = $ligne;
        }
    }
    dbDisconnect($con);
    return $tab;
}

/**
* @param $user un code d'utilisateur connecté
* @return bool : true si l'utilisateur est inscrit à cette activité, false sinon
*/
function estInscritActivite($usr, $noAct) {
    $con = dbConnect();
    if($con) {
        $req = "
        SELECT *
        FROM INSCRIPTION I, ACTIVITE A
        WHERE I.NOACT = A.NOACT
        AND I.USER = '$usr'";
        $res = mysqli_query($con, $req);
        while($ligne = mysqli_fetch_array($res)) {
            if($ligne['NOACT'] == $noAct) {
                if(empty($ligne['DATEANNULE'])) {
                    dbDisconnect($con);
                    return true;
                }
            }
        }
    }
    dbDisconnect($con);
    return false;
}

/**
* @param $usr l'utilisateur voulant s'inscrire, $noAct le numéro de l'activité en question, $cdAct le code d'animation
* @return true si l'inscription à l'activité s'est déroulée sans encombre, false sinon
*/
function inscriptionActivite($usr, $noAct, $cdAnim) {
    $date = date("Y-m-d");
    $con = dbConnect();
    if($con) {
        $req = "
        SELECT *
        FROM ANIMATION
        WHERE NBREPLACEANIM > 0
        AND DATEVALIDITEANIM >= DATE(NOW())
        ";
        $res = mysqli_query($con, $req);
        while($ligne = mysqli_fetch_array($res)) {
            if($ligne['CODEANIM'] == $cdAnim) {
                $reqUpdate = "
                SELECT *
                FROM INSCRIPTION
                WHERE USER = '$usr'
                AND DATEANNULE IS NOT NULL
                AND NOACT = '$noAct'";
                $resUpdate = mysqli_query($con, $reqUpdate);
                if(mysqli_num_rows($resUpdate) > 0) {
                    $req1 = "
                    UPDATE INSCRIPTION
                    SET
                    USER = '$usr',
                    DATEINSCRIP = '$date',
                    DATEANNULE = NULL
                    WHERE NOACT = '$noAct'
                    AND USER = '$usr'";
                } else {
                    $req1 = "
                    INSERT INTO INSCRIPTION(USER, NOACT, DATEINSCRIP)
                    VALUES
                    (
                        '$usr',
                        '$noAct',
                        '$date'
                    )";
                }
                    $res2 = mysqli_query($con, $req1);
                    if($res2) {
                        $req2 = "
                        UPDATE ANIMATION
                        SET NBREPLACEANIM = NBREPLACEANIM - 1
                        WHERE CODEANIM = '$cdAnim'
                        ";
                        $res3 = mysqli_query($con, $req2);
                        if($res3) {
                            dbDisconnect($con);
                            return true;
                        }
                    }
                }
            }
        }
        dbDisconnect($con);
        return false;
    }

    /**
    * @param $usr l'utilisateur voulant se désinscription, $noAct le numéro de l'activité, $cdAct le code d'animation
    * @return true si la désinscription à l'activité s'est déroulée sans encombre, false sinon
    */
    function desinscriptionActivite($usr, $noAct, $cdAnim) {
        $date = date("Y-m-d");
        $con = dbConnect();
        if($con) {
            $req1 = "SELECT *
            FROM INSCRIPTION
            WHERE USER = '$usr'
            AND NOACT = '$noAct'";
            $res1 = mysqli_query($con, $req1);
            if($ligne = mysqli_fetch_array($res1)) {
                $noIn = $ligne['NOINSCRIP'];
                $req2 = "
                UPDATE INSCRIPTION
                SET DATEANNULE = '$date'
                WHERE NOINSCRIP = '$noIn'
                ";
                $res2 = mysqli_query($con, $req2);
                if($res2) {
                    $req3 = "
                    UPDATE ANIMATION
                    SET NBREPLACEANIM = NBREPLACEANIM + 1
                    WHERE CODEANIM = '$cdAnim'
                    ";
                    $res3 = mysqli_query($con, $req3);
                    if($res3) {
                        dbDisconnect($con);
                        return true;
                    }
                }
            }
        }
        dbDisconnect($con);
        return false;
    }
/**
* Supprime une activité et supprime les inscriptions associées à cette ancienne activité
* @param $nomAnim l'utilisateur voulant se désinscription, $noAct le numéro de l'activité, $cdAct le code d'animation
* @return true si la suppression de l'activité s'est déroulée sans encombre ainsi que les suppressions des inscriptions associés, false sinon
*/
//Modification DELETE par UPDATE du CODEETATACT
function annulationActivite($nomAnim, $noAct, $cdAnim) {
    $con = dbConnect();
    if($con) {
        $req1 = "DELETE FROM INSCRIPTION
                        WHERE NOACT = '$noAct'
                ";
        if(mysqli_query($con, $req1)) {
            $req2 = "DELETE FROM ACTIVITE
                    WHERE CODEANIM = '$cdAnim'
                    AND NOMRESP = '$nomAnim'
                    AND NOACT = '$noAct'";
            if(mysqli_query($con, $req2)) {
                dbDisconnect($con);
                return true;
            }
        }
    }
    dbDisconnect($con);
    return false;
}

/**
* Tente de renvoyer les activités auxquelles un utilisateur est inscrit
* @param $usr un utilisateur
* @return $tab un tableau associatif des différentes activités auxquel est inscrit un utilisateur
*/
function listeActivitesInscrites($usr) {
    $tab = [];
    $con = dbConnect();
    if($con) {
        $req = "SELECT *
        FROM INSCRIPTION I, ACTIVITE A, ANIMATION AN
        WHERE A.NOACT = I.NOACT
        AND AN.CODEANIM = A.CODEANIM
        AND I.USER = '$usr'
        AND I.DATEANNULE IS NULL";
        $res = mysqli_query($con, $req);
        if($res) {
            while($ligne = mysqli_fetch_array($res)) {
                $tab[] = $ligne;
            }
            dbDisconnect($con);
            return $tab;
        }
    }
    dbDisconnect($con);
    return false;
}


/**
* Tente de renvoyer toutes les activités créées par un encadrant VVA
* @param $usr un utilsateur
* @return $tab un tableau associatif des activités créées par un encadrant VVA
*/
function listeActivitesCreees($usr) {
    $tab = [];
    $con = dbConnect();
    if($con) {
        $req = "SELECT *
                FROM ACTIVITE A, ANIMATION AN, COMPTE C
                WHERE A.CODEANIM = AN.CODEANIM
                AND A.NOMRESP = C.NOMCOMPTE
                AND C.USER = '$usr'";
        $res = mysqli_query($con, $req);
        if($res) {
            while($ligne = mysqli_fetch_array($res)) {
                $tab[] = $ligne;
            }
            dbDisconnect($con);
            return $tab;
        }
    }
    dbDisconnect($con);
    return false;
}
