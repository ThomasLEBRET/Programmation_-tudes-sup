<?php

require_once('Activite.php');

class ActiviteController extends Activite {

  private $activite;

  public function __construct() {
    $this->activite = new Activite();
  }

  /**
   * Contrôle l'accès à l'ensemble des activités en fonction d'un code d'animation
   * @param  string $cdAnimation PK ANIMATION (code d'animation)
   * @return void   demande la vue des activités si la requête demandant la liste des activités valides réussi, renvoi une vue error sinon
   */
  public function voirActivitesByCodeAnimation($cdAnimation) {
    if(empty(Session::get('TYPEPROFIL')) or Session::get('TYPEPROFIL') == 'VA') {
        $activites = $this->activite->getActivitesValides($cdAnimation);
        require("view/activite/activites.php");
    } elseif (Session::get('TYPEPROFIL') == 'EN') {
        $activites = $this->activite->getAllActivitesForEncadrant($cdAnimation);
        $nbActivites = $activites->rowCount();
        if($nbActivites == 0) {
            require("view/activite/alerts/alertNoneActivite.php");
        } else {
            require("view/activite/activitesForEncadrant.php");
        }
        require("view/activite/createActivite.php");
    }
  }

  /**
   * Vérifie si une inscription à une activité s'est bien déroulée et renvoie la vue associée
   * @param  string $cdAnim PK ANIMATION (code animation)
   * @param  int $noActi PK ACTIVITE (numéro d'activité)
   * @return void         renvoi la vue associée en fonction du succès ou de l'échec de l'exécution de l'inscription
   */
  public function createInscription($cdAnim, $noActi) {
    if($this->activite->execInscription(Session::get('USER'), $cdAnim, $noActi)) {
      require("view/activite/succesInscription.php");
    } else {
      require("view/activite/errors/errorActivites.php");
    }
    header('Refresh:3;url=index.php?page=animation');
  }

  /**
   * Annule une inscription pour un code d'animation et un numéro d'activité donné
   * @param  string $cdAnim PK ANIMATION (code animation)
   * @param  int $noActi PK ACTIVITE (numéro d'activité)
   * @return void         renvoi la vue associée en fonction du succès ou de l'échec de l'annulation d'inscription à une activité
   */
  public function removeInscription($cdAnim, $noActi) {
    if($this->activite->annuleInscription(Session::get('USER'), $cdAnim, $noActi)) {
      require("view/activite/succesDesinscription.php");
    } else {
      require("view/activite/errors/errorRemoveInscription.php");
    }
    header('Refresh:3;url=index.php?page=animation');
  }

  /**
   * Charge un tableau de bord pour un encadrant ou un vacancier lors de sa connexion
   * @return void La vue dashboard représentant les activités auxquelles s'est inscrit un vacancier et la liste des activités classés par animation pour l'encadrant
   */
  public function loadDashboard() {
    if(!empty(Session::get('USER'))) {
        $activites = $this->activite->getActivitesInscrit();
        require("view/user/dashboard.php");
    } else {
      require("view/user/errors/errorLogin.php");
    }
  }
}
