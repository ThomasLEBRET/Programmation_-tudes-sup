<?php ob_start(); ?>
<?php
while($ligne = $activites->fetch(PDO::FETCH_ASSOC)) {
  $this->activite->buildObject($ligne);
?>

  <div class="card justify">
    <div class="card-body">
      <h5 class="card-title"><?= date('d/m/Y', strtotime($this->activite->getDateact())) ?></h5>
      <p class="card-text">Heure de rendez-vous à <?= $ligne['hourRdvAct'].'h'.$ligne['minRdvAct']?></p>
      <p class="card-text">Départ à <?= $ligne['hourDebAct'].'h'.$ligne['minDebAct'] ?></p>
      <?php
        if($this->activite->estInscritActivite(Session::get('USER'), $cdAnimation))
          require("view/activite/components/btDesinscription.php");
        else
          require("view/activite/components/btInscription.php");
      if($btn) echo $btn;

      require("view/activite/components/btModifier.php");
      require("view/activite/components/btSupprimer.php");

      require('view/activite/updateActivite.php');
      require('view/activite/deleteActivite.php');
      if(!empty($updateActi) && !empty($deleteActi)) {
          echo $updateActi, $deleteActi;
        }
      ?>
    </div>
  </div>

<?php } ?>

  <?php $activitesForEncadrant = ob_get_clean(); ?>
