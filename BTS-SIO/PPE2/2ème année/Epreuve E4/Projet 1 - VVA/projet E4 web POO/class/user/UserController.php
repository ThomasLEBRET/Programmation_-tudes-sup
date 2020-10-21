<?php

require_once("User.php");

class UserController extends User {

  private $user;

  public function __construct() {
    $this->user = new User();
  }

  /**
   * Redirige vers la page d'accueil après une connexion d'un utilisateur ou lors de l'arrivée sur le site pour la premère fois
   * @param  array $post un tableau associatif $_POST
   * @return void       la vue associée en fonction du succès ou de l'échec de l'inscription
   */
  public function home($post) {
    if((empty($post->get('username')) || empty($post->get('password'))) && empty(Session::get('USER'))) {
      require('view/accueil.php');
    } else {
      if($this->user->getLogUser($post) &&  $this->user->getUserLoged()) {
        $age = floor(abs(strtotime(date('Y-m-d')) - strtotime(Session::get('DATENAISCOMPTE'))) / (365 * 60 * 60 * 24));
        switch($this->user->getTypeprofil()) {
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

  /**
   * Charge les données d'un utilisateur en construisant un objet User
   * @return void la vue associée à l'utilisateur
   */
  public function loadDatas() {
    $this->user->getUserLoged();
    $age = floor(abs(strtotime(date('Y-m-d')) - strtotime(Session::get('DATENAISCOMPTE'))) / (365 * 60 * 60 * 24));
    $typeProfil = "unknow";
    if(!empty($this->user->getTypeprofil())) {
      switch($this->user->getTypeprofil()) {
        case 'EN':
        $typeProfil = "encadrant";
        break;
        case 'VA':
        $typeProfil = "vacancier";
        break;
        default:
        require("view/user/errors/errorUserCode.php");
        break;
        exit();
      }
      require("view/user/donneesPerso.php");
    } else {
      require("view/user/errors/errorUserCode.php");
    }
  }

}
