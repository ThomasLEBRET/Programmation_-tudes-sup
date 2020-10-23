<?php $title = "VVA - Votre espace" ?>

<?php $date = date_create($this->user->getDatenaiscompte()) ?>
<?php ob_start(); ?>

<div class="jumbotron justify">
    <div class="container">
        <h1>Vous êtes connecté en tant que <?= $typeProfil ?> </h1>
        <h1 class="display-4">Bienvenu <?=$this->user->getPrenomcompte()." ".$this->user->getNomCompte(); ?> !</h1>
        <h3>Mes données personnelles</h3>
        <p>Email : <a href="mailto: <?= $this->user->getAdrmailcompte() ?> "><?= $this->user->getAdrmailcompte() ?></a></p>
        <p>Date de naissance : <?= date_format($date,"d/m/Y"); ?></p>
        <p>Age : <?= $age." ans" ?></p>
    </div>
</div>

<?php $content = ob_get_clean(); ?>
<?php require("view/template.php"); ?>
