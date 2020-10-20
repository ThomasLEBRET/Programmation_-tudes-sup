<?php

require_once('Activite.php');

class ActiviteController {

  private $activite;

  public function __construct() {
    $this->activite = new Activite();
  }

  public function voirActivitesByCodeAnimation($cdAnimation) {
    if($this->activite->getActivitesValides($cdAnimation)->fetch()) {
      $activites = $this->activite->getActivitesValides($cdAnimation);
      require("view/activite/activites.php");
    } else {
      require("view/activite/errors/errorActivites.php");
    }
  }

  public function createInscription($cdAnim, $noActi) {
    if($this->activite->execInscription(Session::get('USER'), $cdAnim, $noActi)) {
      require("view/activite/succesInscription.php");
    } else {
      require("view/activite/errors/errorActivites.php");
    }
    header('Refresh:3;url=index.php?page=animation');
  }

  public function removeInscription($cdAnim, $noActi) {
    if($this->activite->annuleInscription(Session::get('USER'), $cdAnim, $noActi)) {
      require("view/activite/succesDesinscription.php");
    } else {
      require("view/activite/errors/errorRemoveInscription.php");
    }
    header('Refresh:3;url=index.php?page=animation');
  }
}
