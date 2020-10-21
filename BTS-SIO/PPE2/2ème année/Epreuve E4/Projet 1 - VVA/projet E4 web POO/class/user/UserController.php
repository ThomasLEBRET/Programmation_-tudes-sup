<?php

require_once("User.php");

class UserController extends User {

  private $user;

  public function __construct() {
    $this->user = new User();
  }


  public function home($post) {
    if((empty($post->get('username')) || empty($post->get('password'))) && empty(Session::get('USER'))) {
      require('view/accueil.php');
    } else {
      if($this->user->getLogUser($post) || !empty(Session::get('USER'))) {
        $age = floor(abs(strtotime(date('Y-m-d')) - strtotime(Session::get('DATENAISCOMPTE'))) / (365 * 60 * 60 * 24));
        switch(Session::get('TYPEPROFIL')) {
          case 'VA':
          header('Location: index.php?page=dashboard');
          break;
          case 'EN';
          header('Location: index.php?page=dashboard');
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

  public function loadDatas() {
    $this->user->getUserLoged();
    $age = floor(abs(strtotime(date('Y-m-d')) - strtotime(Session::get('DATENAISCOMPTE'))) / (365 * 60 * 60 * 24));
    $typeProfil = "unknow";
    switch(Session::get('TYPEPROFIL')) {
      case 'EN':
      $typeProfil = "encadrant";
      break;
      case 'VA':
      $typeProfil = "vacancier";
      break;
      default:
      require("view/user/errors/errorUserCode.php");
      break;
    }
    require("view/user/donneesPerso.php");
  }

}
