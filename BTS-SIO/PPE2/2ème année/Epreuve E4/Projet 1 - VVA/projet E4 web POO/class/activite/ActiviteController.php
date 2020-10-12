<?php

require_once('Activite.php');

class ActiviteController {

  private $activite;

  public function __construct() {
    $this->activite = new Activite();
  }

  public function voirActivitesByCodeAnimation($cdAnimation) {
    if($this->activite->getActivites($cdAnimation)->fetch() == false) {
      require("view/activite/errors/errorActivites.php");
    } else {
      $activites = $this->activite->getActivites($cdAnimation);
      if(!empty(Session::get('USER'))) {
        $btnInscript = "<a onclick='document.getElementById('inscription').submit()' class='btn btn-primary'>S'inscrire</a>";
      }
      require("view/activite/activites.php");
    }
  }

}
