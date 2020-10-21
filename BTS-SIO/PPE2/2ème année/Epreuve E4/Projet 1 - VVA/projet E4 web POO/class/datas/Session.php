<?php

class Session {

  /**
  * démarre une session en vérifiant qu'une session n'est pas déjà déclarée
  * @return void
  */
  public static function demarrer() {
    if(empty($_SESSION))
    session_start();
  }

  /**
   * Change la valeur d'une partie de la session en fonction de la clé associée à cette valeur
   * @param string $name  la clé qui associe une valeur
   * @param sometype $value une valeur associée à la clé
   */
  public static function set($name, $value) {
    $_SESSION[$name] = $value;
  }

  /**
   * Récupère la valeur d'une partie de la session en fonction de sa clé
   * @param  string $name une clé qui associe une valeur
   * @return sometype       la valeur associée à la clé
   */
  public static function get($name) {
    if(isset($_SESSION[$name]))
    return $_SESSION[$name];
  }

  /**
   * Supprime du tableau associatif de la session une association clé / valeur
   * @param  string $name la clé
   * @return void
   */
  public static function remove($name) {
    unset($_SESSION[$name]);
  }

  /**
   * Arrête une session et la détruit entièrement
   * @return void
   */
  public static function stop() {
    session_unset();
    session_destroy();
  }
}
