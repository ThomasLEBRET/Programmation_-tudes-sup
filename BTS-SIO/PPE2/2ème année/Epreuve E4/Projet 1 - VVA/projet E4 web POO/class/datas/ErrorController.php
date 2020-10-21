<?php

class ErrorController {

  /**
   * Retourne la vue erreur page non trouvée
   * @return void une vue erreur 404
   */
  public function errorNotFound() {
    require_once 'view/errors/404.php';
  }

  /**
   * Retourne la vue erreur interne serveur
   * @return void une vue erreur 500
   */
  public function errorServer() {
    require_once 'view/errors/500.php';
  }
}
