<?php $title = "VVA - Animations en cours" ?>


<?php ob_start(); ?>

<?php
  while($ligne = $anims->fetch(PDO::FETCH_ASSOC)) {
    $this->animation->buildObject($ligne);
      if($this->animation->getNbreplaceanim() == 0)
        $places = 'Il ne reste aucune place pour cette activité';
      else
        $places = 'Il reste '.$this->animation->getNbreplaceanim(). ' places pour cette animation. Se termine le '. date('d/m/Y', strtotime($this->animation->getDatevaliditeanim()));
  ?>


  <div class="card justify">
    <div class="card-header">
      <?= $places ?>
    </div>
    <div class="card-body">
      <h5 class="card-title"><?= $this->animation->getNomanim() ?></h5>
      <p class="card-text"><?= $this->animation->getDescriptanim() ?></p>
      <a href="index.php?page=activite&anim=<?= $this->animation->getCodeanim() ?>" class="btn btn-primary">Dates des activités <?= $this->animation->getCodeanim() ?></a>
  </div>
  </div>
<?php } ?>

<?php $content = ob_get_clean(); ?>
<?php require("view/template.php"); ?>
