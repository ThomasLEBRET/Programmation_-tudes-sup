<?php $title = "VVA - Erreur désinscription" ?>

<?php ob_start(); ?>

<div class="jumbotron jumbotron-fluid justify">
    <div class="container">
        <h1>Votre désinscription n'a pas été prise en compte</h1>
        <i>La redirection se fera dans 3 secondes. Si la redirection automatique ne se fait pas, cliquez <a href="index.php?page=accueil">ici</a> </i>
    </div>
</div>

<?php $content = ob_get_clean(); ?>
<?php require("view/template.php"); ?>
<?php header('Refresh:3;url=index.php?page=animation'); ?>
