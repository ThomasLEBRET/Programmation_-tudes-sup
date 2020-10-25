<?php $title = "VVA - Aucune activite" ?>


<?php ob_start(); ?>

<div class="jumbotron jumbotron-fluid justify">
    <div class="container">
        <h1>Aucune activité pour le code d'animation demandé</h1>
        <p>Les activités liées à cette animation ont expirées</p>
        <i>Retour à la liste des animation <a href="index.php?page=animation">ici</a> </i>
    </div>
</div>

<?php $content = ob_get_clean(); ?>
<?php require("view/template.php"); ?>
