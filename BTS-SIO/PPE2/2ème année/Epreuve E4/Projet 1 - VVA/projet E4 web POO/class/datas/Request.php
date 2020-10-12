<?php

require_once("Parameters.php");

class Request {

    private $get;

    private $post;


    public function __construct() {
        $this->get = new Parameters($_GET);
        $this->post = new Parameters($_POST);
    }

    public function getGet() {
        return $this->get;
   }

    public function getPost() {
       return $this->post;
   }

    public function getSession() {
       return $this->session;
   }
}
