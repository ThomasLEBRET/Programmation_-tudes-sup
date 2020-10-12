<?php $title = "Erreur 404" ?>

<?php ob_start(); ?>

<div class="jumbotron jumbotron-fluid justify">
    <div class="container">
        <h1 class="display-4">Erreur 404</h1>
        <p class="lead">Page non trouvée</p>
        <i>Redirection automatique dans 5 secondes</i>
    </div>
</div>
<?php $content = ob_get_clean(); ?>
<?php require("view/template.php"); ?>
