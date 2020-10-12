<?php

if($_POST) {
    $cdUser = $_POST['username'];
    $psw = $_POST['mdp'];
    if(!logUser($cdUser, $psw)) {
        include(CHEMIN_MODULE_USER_E."connexion.html");
    } else {
        header('Location: index.php?page=accueil');
    }
}
include(CHEMIN_MODULE_USER_V."main.php");
