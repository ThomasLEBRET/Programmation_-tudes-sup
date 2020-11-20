<?php $title = "VVA - Animations en cours" ?>

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
      if(!empty(SESSION::get('USER'))) {
        if($this->activite->estInscritActivite(Session::get('USER'), $cdAnimation, $this->activite->getNoact()))
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
