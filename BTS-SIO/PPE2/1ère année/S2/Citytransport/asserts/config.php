<?php
// Activation de l'assertion et on le rend silencieux
assert_options(ASSERT_ACTIVE, 1);
assert_options(ASSERT_WARNING, 0);
assert_options(ASSERT_QUIET_EVAL, 1);

// Création d'une fonction de gestionnaire
function my_assert_handler($file, $line, $code, $desc = null)
{
    echo "Echec de l'assertion : $file$line$code";
    if ($desc) {
        echo ": $desc";
    }
    echo "\n";
}
// Définition de la fonction de rappel
assert_options(ASSERT_CALLBACK, 'my_assert_handler');

require_once("../constantes.php");
require_once("../".CHEMIN_MODULE_USER_MODELE."user.php");
require_once("../".CHEMIN_MODULE_TRAJET_MODELE."trajet.php");
require_once("../".CHEMIN_LIBRARY."fonction.php");
