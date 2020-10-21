<?php $title = "VVA - Votre espace" ?>

<?php $date = date_create(Session::get('DATENAISCOMPTE')) ?>
<?php ob_start(); ?>

<div class="jumbotron jumbotron-fluid justify">
    <div class="container">
        <h1>Vous êtes connecté en tant que </h1>
        <h1 class="display-4">Bienvenu <?= Session::get('PRENOMCOMPTE')." ".Session::get('NOMCOMPTE'); ?> !</h1>
        <h3>Mes données personnelles</h3>
        <p>Email : <a href="mailto: <?= Session::get('ADRMAILCOMPTE') ?> "><?= Session::get('ADRMAILCOMPTE') ?></a></p>
        <p>Date de naissance : <?= date_format($date,"d/m/Y"); ?></p>
        <p>Age : <?= $age." ans" ?></p>
    </div>
</div>


<?php $content = ob_get_clean(); ?>
<?php require("view/template.php"); ?>
