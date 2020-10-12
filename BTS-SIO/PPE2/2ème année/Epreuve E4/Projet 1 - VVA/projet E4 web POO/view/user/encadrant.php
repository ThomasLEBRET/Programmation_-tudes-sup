<?php $title = "VVA - Accueil" ?>


<?php ob_start(); ?>

<h1>encadrant</h1>
<!-- Lister toutes les activites disponible et où l'encadrant en est responsable -->

<?php $content = ob_get_clean(); ?>
<?php require("view/template.php"); ?>
