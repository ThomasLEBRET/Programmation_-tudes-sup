<?php
//ini_set('display_errors',-1);
require_once 'class/Router.php';
require_once 'class/datas/Session.php';


Session::demarrer();
$router = new Router();
$router->run();
