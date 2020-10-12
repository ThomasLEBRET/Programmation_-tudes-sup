<?php $title = "VVA - Accueil" ?>


<?php ob_start(); ?>

<div class="jumbotron jumbotron-fluid justify">
    <div class="container">
        <h1>Erreur de connexion ! </h1>
        <p>Vous avez tenté de vous connecter avec de mauvais identifiants. Vous serez redirigé dans 5 secondes</p>
        <i>Si la redirection automatique ne se fait pas, cliquez <a href="index.php?page=accueil">ici</a> </i>
    </div>
</div>

<?php $content = ob_get_clean(); ?>
<?php require("view/template.php"); ?>
<?php header('Refresh:5;url=index.php?page=accueil'); ?>
