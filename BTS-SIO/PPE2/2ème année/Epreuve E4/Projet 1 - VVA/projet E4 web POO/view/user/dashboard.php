<?php $title = "VVA - Dashboard" ?>
<?php ob_start(); ?>

<h1 class="text-center">Voici les activités auxquelles vous avez souscrites</h1>

<?php while($ligne = $activites->fetch(PDO::FETCH_ASSOC)) {
  $this->activite->buildObject($ligne); ?>
  <div class="card justify">
    <div class="card-header">
      <h1><?= $ligne['NOMANIM'] ?></h1>
      <?= 'Prix : '.$this->activite->getPrixact('PRIXACT'). '€'?>
    </div>
    <div class="card-body">
      <h5 class="card-title"><?= $this->activite->getDateact('DATEACT') ?></h5>
      <p class="card-text">Heure de rendez-vous à <?= $this->activite->getHrrdvact('HRRDVACT') ?></p>
      <p class="card-text">Départ à <?= $this->activite->getHrdebutact('HRDEBUTACT') ?></p>
      <?php
      if(!empty(SESSION::get('USER'))) {
        if($this->activite->estInscritActivite(Session::get('USER'), $this->activite->getCodeanim()))
          require("view/activite/components/btDesinscription.php");
        else
          require("view/activite/components/btInscription.php");
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
