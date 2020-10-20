<?php $title = "VVA - Animations en cours" ?>

<?php ob_start(); ?>
<?php
while($ligne = $activites->fetch(PDO::FETCH_ASSOC)) {
  $this->activite->buildObject($ligne);
  ?>

  <div class="card justify">
    <div class="card-header">
      <?= 'Prix : '.$this->activite->getPrixact('PRIXACT'). '€'?>
    </div>
    <div class="card-body">
      <h5 class="card-title"><?= $this->activite->getDateact('DATEACT') ?></h5>
      <p class="card-text">Heure de rendez-vous à <?= $this->activite->getHrrdvact('HRRDVACT') ?></p>
      <p class="card-text">Départ à <?= $this->activite->getHrdebutact('HRDEBUTACT') ?></p>
      <?php
      if(!empty(SESSION::get('USER'))) {
        if($this->activite->estInscritActivite(Session::get('USER'), $cdAnimation))
          require("components/btDesinscription.php");
        else
          require("components/btInscription.php");
      } else {
        echo "<p>Connectez vous pour vous inscrire à une activité</p>";
      }
      if(!empty($btn)) {
        echo $btn;
      }
      ?>
    </div>
  </div>

<?php } ?>

  <?php $content = ob_get_clean(); ?>
  <?php require("view/template.php"); ?>
