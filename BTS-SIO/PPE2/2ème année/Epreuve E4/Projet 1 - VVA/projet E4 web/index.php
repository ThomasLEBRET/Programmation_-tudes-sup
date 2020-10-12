<?php ini_set('display_errors',-1); ?>
<?php include_once("constantes.php"); ?>
<?php include_once(CHEMIN_LIB."library.php"); ?>
<?php include_once(CHEMIN_MODULE_USER_M."user.php"); ?>
<?php include_once(CHEMIN_MODULE_ACTIVITE_M."activite.php"); ?>

<?php startSession(); ?>
<?php include_once(CHEMIN_GLOBAL."head.html"); ?>
<?php include_once(CHEMIN_GLOBAL."header.php"); ?>

<?php
if(!empty($_GET['page'])) {
    switch ($_GET['page']) {
        case 'accueil':
        include(CHEMIN_MODULE_USER_C."main.php");
        break;
        case 'animation':
        if(!empty($_GET['anim']) && $_GET['page'] == 'animation' && !empty($_SESSION['USER']))
            include(CHEMIN_MODULE_ACTIVITE_C."activites.php");
        else
            include(CHEMIN_MODULE_ACTIVITE_C."animation.php");
        break;
        case 'deconnexion':
        include(CHEMIN_MODULE_USER_C."deconnexion.php");
        break;
        default:
        header('Location: index.php?page=accueil');
        break;
    }
} else {
    include(CHEMIN_MODULE_USER_C."main.php");
}
?>

<?php include_once(CHEMIN_GLOBAL."footer.html"); ?>
