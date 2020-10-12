<?php

require_once("class/datas/Database.php");

class Activite extends Database {
  private $noact;
  private $codeanim;
  private $codeetatact;
  private $dateact;
  private $hrrdvact;
  private $prixact;
  private $hrdebutact;
  private $hrfunact;
  private $dateannuleact;
  private $nomresp;
  private $prenomresp;

  public function getNoact(){
    return $this->noact;
  }

  public function setNoact($noact){
    $this->noact = $noact;
  }

  public function getCodeanim(){
    return $this->codeanim;
  }

  public function setCodeanim($codeanim){
    $this->codeanim = $codeanim;
  }

  public function getCodeetatact(){
    return $this->codeetatact;
  }

  public function setCodeetatact($codeetatact){
    $this->codeetatact = $codeetatact;
  }

  public function getDateact(){
    return $this->dateact;
  }

  public function setDateact($dateact){
    $this->dateact = $dateact;
  }

  public function getHrrdvact(){
    return $this->hrrdvact;
  }

  public function setHrrdvact($hrrdvact){
    $this->hrrdvact = $hrrdvact;
  }

  public function getPrixact(){
    return $this->prixact;
  }

  public function setPrixact($prixact){
    $this->prixact = $prixact;
  }

  public function getHrdebutact(){
    return $this->hrdebutact;
  }

  public function sethrdebutact($hrdebutact){
    $this->hrdebutact = $hrdebutact;
  }

  public function getHrfunact(){
    return $this->hrfunact;
  }

  public function setHrfunact($hrfunact){
    $this->hrfunact = $hrfunact;
  }

  public function getDateannuleact(){
    return $this->dateannuleact;
  }

  public function setDateannuleact($dateannuleact){
    $this->dateannuleact = $dateannuleact;
  }

  public function getNomresp(){
    return $this->nomresp;
  }

  public function setNomresp($nomresp){
    $this->nomresp = $nomresp;
  }

  public function getPrenomresp(){
    return $this->prenomresp;
  }

  public function setPrenomresp($prenomresp){
    $this->prenomresp = $prenomresp;
  }

  public function buildObject(array $params) {
      foreach ($params as $key => $value) {
          $method = 'set'.ucfirst(strtolower($key));
          if(method_exists($this, $method)) {
              $this->$method($value);
              $_SESSION[$key] = $value;
          }
      }
      return true;
  }

  public function getActivites($cdAnimation) {
    $req = "
    SELECT *
    FROM ACTIVITE
    WHERE CODEANIM = ?";
    $res = $this->createQuery($req, [$cdAnimation]);
    return $res;
  }

}
