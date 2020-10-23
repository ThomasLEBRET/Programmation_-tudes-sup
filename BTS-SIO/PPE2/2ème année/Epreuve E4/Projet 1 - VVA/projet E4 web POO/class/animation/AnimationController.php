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
    $anims = $this->animation->getAnimationsValides();
    if(!empty(Session::get('TYPEPROFIL')) && Session::get('TYPEPROFIL') == 'EN') {
        require('view/animation/components/btSupprimer.php');
        require('view/animation/components/btModifier.php');
    }
    require('view/animation/animations.php');
  }
}
