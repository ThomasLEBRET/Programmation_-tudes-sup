<?php $title = "VVA - Erreur de lecture du code utilisateur" ?>


<?php ob_start(); ?>

<div class="jumbotron jumbotron-fluid justify">
    <div class="container">
        <h1>Erreur de catégorie ! </h1>
        <p>Nous n'arrivons pas à trouver la catégorie d'utilisateur à laquelle vous appartenez</p>
        <i>Si la redirection automatique ne se fait pas, cliquez <a href="index.php?page=accueil">ici</a> </i>
    </div>
</div>

<?php $content = ob_get_clean(); ?>
<?php require("view/template.php"); ?>
<?php header('Refresh:3;url=index.php?page=accueil'); ?>
