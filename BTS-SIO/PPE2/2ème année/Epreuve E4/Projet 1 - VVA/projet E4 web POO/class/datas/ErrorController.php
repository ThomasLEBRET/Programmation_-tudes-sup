<?php

class ErrorController {

    public function errorNotFound() {
        require_once 'view/errors/404.php';
    }

    public function errorServer() {
        require_once 'view/errors/500.php';
    }
}
