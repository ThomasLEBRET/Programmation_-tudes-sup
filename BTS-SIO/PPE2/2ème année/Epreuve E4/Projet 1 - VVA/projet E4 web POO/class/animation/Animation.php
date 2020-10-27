<?php

require_once("class/datas/Database.php");

class Animation extends Database {
    private $codeanim;
    private $codetypeanim;
    private $nomanim;
    private $datecreationanim;
    private $datevaliditeanim;
    private $dureeanim;
    private $limiteage;
    private $tarifanim;
    private $nbreplaceanim;
    private $descriptanim;
    private $commentanim;
    private $difficulteanim;

    public function __construct() {
        $codeanim = "unknow";
        $codetypeanim = "unknow";
        $nomanim = "unknow";
        $datecreationanim = "unknow";
        $datevaliditeanim = "unknow";
        $dureeanim = "unknow";
        $limiteage = "unknow";
        $tarifanim = "unknow";
        $nbreplaceanim = "unknow";
        $descriptanim = "unknow";
        $commentanim = "unknow";
        $difficulteanim = "unknow";
        $listeCodeAnim = [];
    }


    public function getCodeanim(){
        return $this->codeanim;
    }

    public function setCodeanim($codeanim){
        $this->codeanim = $codeanim;
    }

    public function getCodetypeanim(){
        return $this->codetypeanim;
    }

    public function setCodetypeanim($codetypeanim){
        $this->codetypeanim = $codetypeanim;
    }

    public function getNomanim(){
        return $this->nomanim;
    }

    public function setNomanim($nomanim){
        $this->nomanim = $nomanim;
    }

    public function getDatecreationanim(){
        return $this->datecreationanim;
    }

    public function setDatecreationanim($datecreationanim){
        $this->datecreationanim = $datecreationanim;
    }

    public function getDatevaliditeanim(){
        return $this->datevaliditeanim;
    }

    public function setDatevaliditeanim($datevaliditeanim){
        $this->datevaliditeanim = $datevaliditeanim;
    }

    public function getDureeanim(){
        return $this->dureeanim;
    }

    public function setDureeanim($dureeanim){
        $this->dureeanim = $dureeanim;
    }

    public function getLimiteage(){
        return $this->limiteage;
    }

    public function setLimiteage($limiteage){
        $this->limiteage = $limiteage;
    }

    public function getTarifanim(){
        return $this->tarifanim;
    }

    public function setTarifanim($tarifanim){
        $this->tarifanim = $tarifanim;
    }

    public function getNbreplaceanim(){
        return $this->nbreplaceanim;
    }

    public function setNbreplaceanim($nbreplaceanim){
        $this->nbreplaceanim = $nbreplaceanim;
    }

    public function getDescriptanim(){
        return $this->descriptanim;
    }

    public function setDescriptanim($descriptanim){
        $this->descriptanim = $descriptanim;
    }

    public function getCommentanim(){
        return $this->commentanim;
    }

    public function setCommentanim($commentanim){
        $this->commentanim = $commentanim;
    }

    public function getDifficulteanim(){
        return $this->difficulteanim;
    }

    public function setDifficulteanim($difficulteanim){
        $this->difficulteanim = $difficulteanim;
    }

    public function buildObject(array $datas) {
        foreach($datas as $key => $ligne) {
            $method = 'set'.ucfirst($key);
            if(method_exists($this, $method)) {
                $this->$method($ligne);
            }
        }
    }

    public function buildPartialObject(array $datas) {
        foreach($datas as $key => $ligne) {
            $method = 'set'.ucfirst($key);
            if(method_exists($this, $method) && !empty($ligne)) {
                $this->$method($ligne);
            }
        }
    }

    /**
    * Retourne la liste des animations valides pour un utilisateur connecté (retourne l'ensemble des animations valides si l'utilisateur navigue sur le site en tant qu'invité)
    * @return PDO une requête préparée
    */
    public function getAnimationsValides() {
        $ageUser = floor(abs(strtotime(date('Y-m-d')) - strtotime(Session::get('DATENAISCOMPTE'))) / (365 * 60 * 60 * 24));

        $nbPlacesAnim = "
        SELECT COUNT(*)
        FROM ANIMATION AN, INSCRIPTION I, ACTIVITE A
        WHERE A.NOACT = I.NOACT
        AND A.CODEANIM = AN.CODEANIM
        AND A.CODEETATACT = 'O'
        AND I.DATEANNULE IS NULL
        ";
        $bindParam = "
        AND A.CODEANIM = cdAnim
        ";

        $req = "
        SELECT AN.*, AN.CODEANIM as cdAnim, CONCAT(ROUND(AN.TARIFANIM,0),'€') as TARIFANIM, AN.NBREPLACEANIM - ($nbPlacesAnim$bindParam) as nbPlacesRestantes
        FROM ANIMATION AN, ACTIVITE A
        WHERE AN.CODEANIM = A.CODEANIM
        AND AN.DATEVALIDITEANIM > DATE(NOW())
        AND A.DATEACT > DATE(NOW())
        AND AN.LIMITEAGE <= ?
        AND AN.NBREPLACEANIM - ($nbPlacesAnim) > 0";
        return ($this->createQuery($req, [$ageUser]));
    }

    /**
    * Retourne toutes les animations pour l'encadrant
    * @return PDO une requête préparée
    */
    public function getAllAnimationForEncadrant() {
        $req = "
        SELECT AN.CODEANIM, AN.CODEANIM as cdAnim, AN.CODETYPEANIM, AN.NOMANIM, AN.DATEVALIDITEANIM, AN.DUREEANIM, AN.LIMITEAGE, CONCAT(ROUND(AN.TARIFANIM,0),'€') as TARIFANIM, AN.NBREPLACEANIM, AN.DESCRIPTANIM, AN.COMMENTANIM,  AN.NBREPLACEANIM -
        (
            SELECT COUNT(I.NOACT) as nbPlacesPrises
            FROM ANIMATION AN, INSCRIPTION I, ACTIVITE A
            WHERE A.NOACT = I.NOACT
            AND A.CODEANIM = AN.CODEANIM
            AND I.DATEANNULE IS NULL
            AND AN.CODEANIM = cdAnim
            ) as nbPlacesRestantes
            FROM ANIMATION AN";

            return $this->createQuery($req);

        }

        /**
        * Vérifie qu'une animation possède une valeur à chacun de ses attributs grâce à un tableau de données postées issues d'un formulaire
        * @return bool true si tous les attributs de l'objets sont déclarés et non null, false sinon
        */
        public function allFiledsIsIsset($formPost) {
            foreach($formPost as $key => $value) {
                $method = 'get'.ucfirst(strtolower($key));
                if(!method_exists($this, $method)) {
                    $val = $this->$method();
                    if(!isset($val))
                        return false;
                }
            }
            return true;
        }

        public function isAnimationValide() {
            $req = "SELECT CODEANIM FROM ANIMATION";
            $listeCodeAnim = $this->createQuery($req);

        }

        public function isUniqueCodeAnim($codeanim, $oldCodeAnim = null) {
            $req =
            "
            SELECT CODEANIM
            FROM ANIMATION
            ";
            $res = $this->createQuery($req);

            while($cdAnim = $res->fetch(PDO::FETCH_ASSOC)) {
                if($oldCodeAnim) {
                    return true;
                }
                if($cdAnim['CODEANIM'] == $codeanim) {
                    return false;
                }
            }
            return true;
        }

        public function ajouterAnimation() {
            $req =
            "
            INSERT INTO `ANIMATION`
            (
                `CODEANIM`,
                `CODETYPEANIM`,
                `NOMANIM`,
                `DATECREATIONANIM`,
                `DATEVALIDITEANIM`,
                `DUREEANIM`,
                `LIMITEAGE`,
                `TARIFANIM`,
                `NBREPLACEANIM`,
                `DESCRIPTANIM`,
                `COMMENTANIM`,
                `DIFFICULTEANIM`
                )
                VALUES
                (
                    ?,?,?,?,?,?,?,?,?,?,?,?
                    )
                    ";
                    if($this->createQuery($req,
                    [
                        $this->codeanim,
                        $this->codetypeanim,
                        $this->nomanim,
                        $this->datecreationanim,
                        $this->datevaliditeanim,
                        $this->dureeanim,
                        $this->limiteage,
                        $this->tarifanim,
                        $this->nbreplaceanim,
                        $this->descriptanim,
                        $this->commentanim,
                        $this->difficulteanim
                        ])) {
                            return true;
                        }
                        return false;
                    }

        public function modifierAnimation($oldCodeAnim) {
            $req =
            "
            UPDATE ANIMATION
            SET
                CODEANIM = ?,
                CODETYPEANIM = ?,
                NOMANIM = ?,
                DATECREATIONANIM = ?,
                DATEVALIDITEANIM = ?,
                DUREEANIM = ?,
                LIMITEAGE = ?,
                TARIFANIM = ?,
                NBREPLACEANIM = ?,
                DESCRIPTANIM = ?,
                COMMENTANIM = ?,
                DIFFICULTEANIM = ?
            WHERE CODEANIM = ?
            ";
            if($this->createQuery($req,
            [
                $this->codeanim,
                $this->codetypeanim,
                $this->nomanim,
                $this->datecreationanim,
                $this->datevaliditeanim,
                $this->dureeanim,
                $this->limiteage,
                $this->tarifanim,
                $this->nbreplaceanim,
                $this->descriptanim,
                $this->commentanim,
                $this->difficulteanim,
                $oldCodeAnim
            ])) {
                    return true;
                }
                return false;
            }

        public function getAnimation($codeAnim, $post = null) {
            $req = "SELECT * FROM ANIMATION WHERE CODEANIM = ?";
            if($ligne = $this->createQuery($req, [$codeAnim])->fetch(PDO::FETCH_ASSOC)) {
                $this->buildObject($ligne);
            }
            return $this;
        }
}
