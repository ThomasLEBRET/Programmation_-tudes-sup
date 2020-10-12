<?php $title = "Erreur 404" ?>

<?php ob_start(); ?>

<div class="jumbotron jumbotron-fluid justify">
    <div class="container">
        <h1 class="display-4">Erreur 500</h1>
        <p class="lead">Une erreur serveur est survenue</p>
        <i>Redirection automatique dans 5 secondes</i>
    </div>
</div>

<?php $content = ob_get_clean(); ?>
<?php require("view/template.php"); ?>
