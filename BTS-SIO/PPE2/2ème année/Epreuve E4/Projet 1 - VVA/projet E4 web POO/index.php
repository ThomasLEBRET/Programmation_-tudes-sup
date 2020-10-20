<?php
ini_set('display_errors',-1);
require_once 'class/Router.php';
require_once 'class/datas/Session.php';


Session::demarrer();
$router = new Router();
$router->run();


/*
Programme :
// 2h
1 -> Pouvoir s'inscrire à une activité (+ se désinscrire)
2 -> Voir la liste des activités auxquelles un vacancier a souscrit
3 -> Modifier le menu pour un encadrant VVA une fois connecté
// Fin 2h

//2h
4 -> Ajouter une animation
5 -> Ajouter une activité
6 -> Supprimer une activité
7 -> Supprimer une animation
// Fin 2h

// 4h
8 -> Modifier une activité
9 -> Modifier une animation
// Fin 4h

//1h
10 -> Système de hot search des animations et des activités pour un
encadrant (cf exemple géénrateur cv javascript)
//Fin 1h
 */
