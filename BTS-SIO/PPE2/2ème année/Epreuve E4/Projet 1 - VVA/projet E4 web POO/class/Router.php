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

  /**
   * Réparti l'utilisation des controleurs de données en fonction du chemin emprunté par l'utilisateur
   * @return void  le controleur de données associé au chemin choisi par l'utilisateur
   */
  public function run()
  {
    $page = $this->request->getGet()->get('page');
    $cdAnimation = $this->request->getGet()->get('anim');
    $noActivite = $this->request->getGet()->get('acti');

    try {
      if($page) {
        switch($page) {
          case 'accueil':
          $this->userController->home($this->request->getPost());
          break;
          case 'dashboard':
          $this->activiteController->loadDashboard();
          break;
          case 'compte':
          $this->userController->loadDatas();
          break;
          case 'animation':
          $this->animationController->voirAnimations();
          break;
          case 'activite':
          $this->activiteController->voirActivitesByCodeAnimation($cdAnimation);
          break;
          case 'ajouterAnimation':
          $this->animationController->addAnimation($this->request->getPost());
          break;
          case 'supprimerAnimation':
          $this->animationController->deleteAnimation($this->request->getPost()->get("CODEANIM"));
          break;
          case 'modifierAnimation':
          $this->animationController->updateAnimation();
          break;
          case 'inscription':
          $this->activiteController->createInscription($cdAnimation, $noActivite);
          break;
          case 'desinscription':
          $this->activiteController->removeInscription($cdAnimation, $noActivite);
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
