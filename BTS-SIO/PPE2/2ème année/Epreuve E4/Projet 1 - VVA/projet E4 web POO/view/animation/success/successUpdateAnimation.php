<?php $title = "VVA - Succes modification animation" ?>


<?php ob_start(); ?>

<div class="jumbotron jumbotron-fluid justify">
    <div class="container">
        <h1>La modification de votre animation a réussi</h1>
        <i>Si la redirection automatique ne se fait pas, cliquez <a href="index.php?page=animation">ici</a> </i>
    </div>
</div>

<?php $content = ob_get_clean(); ?>
<?php require("view/template.php"); ?>
<?php header('Refresh:3;url=index.php?page=animation'); ?>
