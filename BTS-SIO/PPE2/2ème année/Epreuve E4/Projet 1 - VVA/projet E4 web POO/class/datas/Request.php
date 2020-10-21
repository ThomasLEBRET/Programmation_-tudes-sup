<?php

require_once("Parameters.php");

class Request {

    private $get;

    private $post;


    public function __construct() {
        $this->get = new Parameters($_GET);
        $this->post = new Parameters($_POST);
    }

    /**
     * Retourne la variable super globale $_GET
     * @return array le tableau associatif $_GET
     */
    public function getGet() {
        return $this->get;
   }

   /**
    * Retourne la variable super globale $_POST
    * @return array le tableau associatif $_POST
    */
    public function getPost() {
       return $this->post;
   }
}
