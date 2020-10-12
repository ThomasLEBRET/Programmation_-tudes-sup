<?php $title = "VVA - Activites" ?>


<?php ob_start(); ?>

<div class="jumbotron jumbotron-fluid justify">
    <div class="container">
        <h1>Le code d'activité n'existe plus</h1>
        <p>L'animateur a du retirer l'activité ou le site n'a pas eu le temps d'actualiser la demande de l'animateur</p>
        <p>L'url demandé n'existe sans doute plus également, veuillez réessayer ultérieurement</p>
        <i>Si la redirection automatique ne se fait pas, cliquez <a href="index.php?page=accueil">ici</a> </i>
    </div>
</div>

<?php $content = ob_get_clean(); ?>
<?php require("view/template.php"); ?>
<?php header('Refresh:5;url=index.php?page=animation'); ?>
