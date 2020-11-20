<?php $title = "VVA - Dashboard" ?>
<?php ob_start(); ?>

<?php
if($activites->rowCount() == 0) {
    require('view/user/goToAnimations.php');
} else {
    ?>
    <h1 class="text-center">Voici les activités auxquelles vous avez souscrites</h1>

<?php }?>
<?php while($ligne = $activites->fetch(PDO::FETCH_ASSOC)) {
    $this->activite->buildObject($ligne); ?>
    <?php if($ligne['minRdvAct'] == 0) $ligne['minRdvAct'] = $ligne['minRdvAct']."0"; ?>
    <div class="card justify">
        <div class="card-header">
            <h1><?= $ligne['NOMANIM'] ?></h1>
            <?= 'Prix : '.$this->activite->getPrixact('PRIXACT')?>
        </div>
        <div class="card-body">
            <h5 class="card-title"><?= date('d/m/Y', strtotime($this->activite->getDateact())) ?></h5>
            <p class="card-text">Heure de rendez-vous à <?= $ligne['hourRdvAct'].'h'.$ligne['minRdvAct'] ?></p>
            <p class="card-text">Départ à <?= $ligne['hourDebAct'].'h'.$ligne['minDebAct'] ?></p>
            <p class="card-text">Durée effective de l'animation :
                <?php
                if(!empty($ligne['hrDureeAnim']) && $ligne['hrDureeAnim'] != 0)
                echo $ligne['hrDureeAnim'].'h';
                if(!empty($ligne['minDureeAnim']) && $ligne['minDureeAnim'] != 0)
                echo $ligne['minDureeAnim'].'min';
                ?>
            </p>
            <?php
            if(!empty(SESSION::get('USER'))) {
                if($this->activite->estInscritActivite(Session::get('USER'), $this->activite->getCodeanim(), $this->activite->getNoact()))
                require("view/activite/components/btDesinscription.php");
                else
                require("view/activite/components/btInscription.php");
            }
            else
            echo "<p>Connectez vous pour vous inscrire à une activité</p>";
            if(!empty($btn))
            echo $btn;
            ?>
        </div>
    </div>

<?php } ?>

<?php $content = ob_get_clean(); ?>
<?php require("view/template.php"); ?>
