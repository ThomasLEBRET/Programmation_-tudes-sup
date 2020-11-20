<?php $title = "VVA - Animations en cours" ?>
<?php $cdTypeAnim = []; ?>

<?php ob_start(); ?>
<?php if(!empty(Session::get('TYPEPROFIL')) && Session::get('TYPEPROFIL') == 'EN') {
    require('view/animation/components/btAjouter.php');
    if(!empty($btAjouterAnim)) {
        echo $btAjouterAnim;
    }
} ?>

<?php
while($ligne = $anims->fetch(PDO::FETCH_ASSOC)):
    $this->animation->buildObject($ligne);
    $cdTypeAnim[] = $this->animation->getCodetypeAnim();

    $hrAnim = floor($this->animation->getDureeanim());
    $minAnim = ($this->animation->getDureeanim() - $hrAnim)*60;

    if($this->animation->getNbreplaceanim() == 0 || $ligne['nbPlacesRestantes'] == 0)
    $places = 'Il ne reste aucune place pour cette activité';
    else
    $places = 'Il reste '.$ligne['nbPlacesRestantes'].' / '.$this->animation->getNbreplaceanim().' places pour cette animation. Se termine le '. date('d/m/Y', strtotime($this->animation->getDatevaliditeanim()));

    ?>


    <div class="card justify">
        <div class="card-header">
            <?= $places ?>
        </div>
        <div class="card-body">
            <h5 class="card-title"><?= $this->animation->getNomanim() ?> (<?= $this->animation->getTarifanim()?>)</h5>
            <p class="card-text"><?= $this->animation->getDescriptanim() ?></p>
            <p class="card-text">L'animation dure <?php if(!empty($hrAnim) && $hrAnim != 0) echo $hrAnim.'h'?><?php if(!empty($minAnim) && $minAnim != 0) echo $minAnim.'min'?></p>
            <p class="card-text">Pour les plus de  <?= $this->animation->getLimiteage() ?> ans</p>
            <a href="index.php?page=activite&anim=<?= $this->animation->getCodeanim() ?>" class="btn btn-primary">Dates des activités associées</a>

            <?php
            if(!empty(Session::get('TYPEPROFIL')) && Session::get('TYPEPROFIL') == 'EN') {
                require('view/animation/updateAnimation.php');
                if(!empty($updateAnim)) {
                    echo $updateAnim;
                }
                require('view/animation/components/btModifier.php');
            }
            ?>
        </div>
    </div>
<?php endwhile ?>
<?php
    require('view/animation/addAnimation.php');
    if(!empty($addAnim)) {
        echo $addAnim;
    }
?>


<?php $content = ob_get_clean(); ?>
<?php require("view/template.php"); ?>
