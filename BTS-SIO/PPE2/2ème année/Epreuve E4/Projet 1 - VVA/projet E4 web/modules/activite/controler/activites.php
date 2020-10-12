<?php

if($_POST) {
    if(isset($_POST['inscription']) && $_POST['inscription']  == "inscription") {
        if(inscriptionActivite($_SESSION['USER'], intval($_POST['noAct']), $_POST['cdAnim'])) {
            header('Location: index.php?page=accueil');
        }
    }
    if(isset($_POST['desinscription']) && $_POST['desinscription'] == "deinscription") {
        if(desinscriptionActivite($_SESSION['USER'], intval($_POST['noAct']), $_POST['cdAnim'])) {
            header('Location: index.php?page=accueil');
        }
    }
    if(isset($_POST['suppression']) && $_POST['suppression'] == "suppression") {
        if(annulationActivite($_SESSION['NOMCOMPTE'], intval($_POST['noAct']), $_POST['cdAnim'])) {
            header('Location: index.php?page=accueil');
        }
    }
} else {
    if(!$_GET['anim'] || estCdAnimationValide($_GET['anim'])) {
        $tab = getActivite($_GET['anim']);
        if($tab) {
            foreach($tab as $key => $ligne) {
                echo "<br>";
                include(CHEMIN_MODULE_ACTIVITE_V."voirtoutesActivites.php");
            }
        }
    } else {
        header('Location: index.php?page=animation');
    }
}
