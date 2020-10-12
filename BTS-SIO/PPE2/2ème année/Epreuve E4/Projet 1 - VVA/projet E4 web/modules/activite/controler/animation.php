<?php

$tab = getAllAnimationValides();
if($tab) {
    foreach($tab as $key => $ligne) {
        echo "<br>";
        include(CHEMIN_MODULE_ACTIVITE_V."voirToutesAnimations.php");
    }
}
