<?php

require_once("User.php");

class UserController {

  private $user;

  public function __construct() {
    $this->user = new User();
  }


  public function home($post) {
    if((empty($post->get('username')) || empty($post->get('password'))) && empty(Session::get('USER'))) {
      require('view/accueil.php');
    } else {
      if($this->user->getLogUser($post) || !empty(Session::get('USER'))) {
        switch(Session::get('TYPEPROFIL')) {
          case 'VA':
          require('view/user/vacancier.php');
          break;
          case 'EN';
          require('view/user/encadrant.php');
          break;
          default:
          require('view/user/errors/errorLogin.php');
          break;
        }
      } else {
        require("view/errors/errorLogin.php");
      }
    }
  }

}
