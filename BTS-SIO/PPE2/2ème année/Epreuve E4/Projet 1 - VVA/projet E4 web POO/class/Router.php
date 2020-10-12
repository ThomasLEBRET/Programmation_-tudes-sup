<?php

require_once("user/UserController.php");
require_once("animation/AnimationController.php");
require_once("activite/ActiviteController.php");
require_once("datas/ErrorController.php");
require_once("datas/Request.php");

class Router {

  private $userController;

  private $animationController;

  private $activiteController;

  private $errorController;

  private $request;

  public function __construct() {
    $this->userController = new UserController();
    $this->animationController = new AnimationController();
    $this->activiteController = new ActiviteController();

    $this->errorController = new ErrorController();
    $this->request = new Request();
  }

  public function run()
  {
    $page = $this->request->getGet()->get('page');
    $cdAnimation = $this->request->getGet()->get('anim');
    try {
      if($page) {
        switch($page) {
          case 'accueil':
          $this->userController->home($this->request->getPost());
          break;
          case 'animation':
          $this->animationController->voirAnimations();
          break;
          case 'activite':
          $this->activiteController->voirActivitesByCodeAnimation($cdAnimation);
          break;
          case 'deconnexion':
              Session::stop();
              header('Location: index.php?page=accueil');
              break;
          default:
          $this->errorController->errorNotFound();
          header('Refresh:5;url=index.php?page=accueil');
          break;
        }
      } else {
        header('Location: index.php?page=accueil');
      }
    }
    catch (Exception $e) {
      $this->errorController->errorServer();
      header('Refresh:5;url=index.php?page=accueil');
    }
  }

}
