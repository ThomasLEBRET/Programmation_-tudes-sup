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
}
