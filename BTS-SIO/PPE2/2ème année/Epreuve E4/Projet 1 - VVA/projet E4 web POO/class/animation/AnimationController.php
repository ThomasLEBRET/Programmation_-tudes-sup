<?php

require_once("Animation.php");

class AnimationController extends Animation {

  private $animation;

  public function __construct() {
    $this->animation = new Animation();
  }

  /**
   * Renvoi la liste des animations valides
   * @return void demande la vue associée
   */
  public function voirAnimations() {
    if(!empty(Session::get('TYPEPROFIL')) && Session::get('TYPEPROFIL') == 'EN') {
        $anims = $this->animation->getAllAnimationForEncadrant();
    } else {
        $anims = $this->animation->getAnimationsValides();
    }
    require('view/animation/animations.php');
  }

  public function addAnimation() {
      if(!empty(Session::get('TYPEPROFIL')) && Session::get('TYPEPROFIL') == 'EN') {
          $this->animation->buildObject($_POST);
          $this->animation->setDatecreationanim(date('Y-m-d'));
          if($this->animation->allFiledsIsNoneEmpty($_POST)) {
              echo "Objet Valide !";
              // Vérifie si codeanim n'existe pas
              // Vérifie si datecreationanim correspond à la date du jour
              // Vérifie si DATEVALIDITEANIM est supérieur ou égale à la date du jour
              // Vérifie si DUREEANIM ne vaut pas 0
              // Vérifie si LIMITEAGE est supérieur à 0
              // Vérifie si TARIFANIM >= 0
              // Vérifie si NBREPLACEANIM > 0
          }

      } else {
          require('view/animation/errors/errorAccess.php');
      }
  }

  public function deleteAnimation(array $datas) {
      if(!empty(Session::get('TYPEPROFIL')) && Session::get('TYPEPROFIL') == 'EN') {
          // Récupère un objet animation grâce à une fonction qui récupère une animation en fonction du code de l'animation
          // Annule les inscriptions aux activités issues de cette animation
          // Annule les animations de cette activité
          // Annule l'animation
      } else {
          require('view/animation/errors/errorAccess.php');
      }
  }

  public function updateAnimation(array $datas) {
      if(!empty(Session::get('TYPEPROFIL')) && Session::get('TYPEPROFIL') == 'EN') {
          $this->animation->buildObject($_POST);
          $this->animation->setDatecreationanim(date('Y-m-d'));
          if($this->animation->allFiledsIsNoneEmpty($_POST)) {
              echo "Objet Valide !";
              // Vérifie si codeanim n'existe pas
              // Vérifie si datecreationanim correspond à la date du jour
              // Vérifie si DATEVALIDITEANIM est supérieur ou égale à la date du jour
              // Vérifie si DUREEANIM ne vaut pas 0
              // Vérifie si LIMITEAGE est supérieur à 0
              // Vérifie si TARIFANIM >= 0
              // Vérifie si NBREPLACEANIM > 0
          }

      } else {
          require('view/animation/errors/errorAccess.php');
      }
  }

}
