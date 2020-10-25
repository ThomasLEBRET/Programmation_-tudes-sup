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

  /**
   * Retourne la liste des animations valides pour un utilisateur connecté (retourne l'ensemble des animations valides si l'utilisateur navigue sur le site en tant qu'invité)
   * @return PDO une requête préparée
   */
  public function getAnimationsValides() {
    $ageUser = floor(abs(strtotime(date('Y-m-d')) - strtotime(Session::get('DATENAISCOMPTE'))) / (365 * 60 * 60 * 24));

    $nbPlacesAnim = "
    SELECT COUNT(*) as nbPlacesPrises
    FROM ANIMATION AN, INSCRIPTION I, ACTIVITE A
    WHERE A.NOACT = I.NOACT
    AND A.CODEANIM = AN.CODEANIM
    AND A.CODEETATACT = 'O'
    AND I.DATEANNULE IS NULL
    ";

    $valNbPlacesAnim = $this->createQuery($nbPlacesAnim)->fetch()->nbPlacesPrises;

    $req = "
    SELECT AN.CODEANIM, AN.CODETYPEANIM, AN.NOMANIM, AN.DATEVALIDITEANIM, AN.DUREEANIM, AN.LIMITEAGE, CONCAT(ROUND(AN.TARIFANIM,0),'€') as TARIFANIM, AN.NBREPLACEANIM, AN.DESCRIPTANIM, AN.COMMENTANIM, AN.NBREPLACEANIM - (?) as nbPlacesRestantes
    FROM ANIMATION AN, ACTIVITE A
    WHERE AN.CODEANIM = A.CODEANIM
    AND AN.DATEVALIDITEANIM > DATE(NOW())
    AND A.DATEACT > DATE(NOW())
    AND AN.LIMITEAGE <= ?
    AND AN.NBREPLACEANIM - (?) > 0";
    return $this->createQuery($req, [$valNbPlacesAnim, $ageUser, $valNbPlacesAnim]);
  }

  /**
   * Retourne toutes les animations pour l'encadrant
   * @return PDO une requête préparée
   */
  public function getAllAnimationForEncadrant() {
      $nbPlacesAnim = "
      SELECT COUNT(*) as nbPlacesPrises
      FROM ANIMATION AN, INSCRIPTION I, ACTIVITE A
      WHERE A.NOACT = I.NOACT
      AND A.CODEANIM = AN.CODEANIM
      AND A.CODEETATACT = 'O'
      AND I.DATEANNULE IS NULL
      ";

      $req = "
      SELECT *, NBREPLACEANIM - (?) as nbPlacesRestantes
      FROM ANIMATION";
      return $this->createQuery($req, [$nbPlacesAnim]);
  }

  /**
   * Vérifie qu'une animation possède une valeur à chacun de ses attributs grâce à un tableau de données postées issues d'un formulaire
   * @return bool true si tous les attributs de l'objets sont déclarés et non null, false sinon 
   */
  public function allFiledsIsNoneEmpty($formPost) {
      foreach($formPost as $key => $value) {
          $method = 'get'.ucfirst(strtolower($key));
          if(!method_exists($this, $method) or empty($this->$method())) {
              return false;
          }
      }
      return true;
  }

}
