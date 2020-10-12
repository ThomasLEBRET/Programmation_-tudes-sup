<?php

class Session {

    public static function demarrer() {
      if(empty($_SESSION))
        session_start();
    }

    public static function set($name, $value) {
        $_SESSION[$name] = $value;
    }

    public static function get($name) {
        if(isset($_SESSION[$name]))
            return $_SESSION[$name];
    }

    public static function remove($name) {
       unset($_SESSION[$name]);
   }

   public static function stop() {
       session_unset();
       session_destroy();
   }
}
