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

        <h5>Voici le groupe d'utilisateurs participant à cette activité</h5>
        <?php
        $usr = $this->activite->getListeInscrits($this->activite->getNoact())->fetchAll(PDO::FETCH_ASSOC);
        for($i = 0; $i < count($usr); $i++){
          ?> <p><?= $usr[$i]["USER"] ?></p> 
          
          <?php
        }

        if($this->activite->getCodeetatact() == 'O') {
          if($this->activite->estInscritActivite(Session::get('USER'), $cdAnimation, $this->activite->getNoact()))
          include_once("view/activite/components/btDesinscription.php");
        else
          include_once("view/activite/components/btInscription.php");
          if(!empty($btn)) echo $btn;
        }

      require("view/activite/components/btModifier.php");
      require('view/activite/updateActivite.php');

      if(!empty($updateActi)) {
          echo $updateActi;
      }
      if($this->activite->getCodeetatact() == 'O') {
        require("view/activite/components/btSupprimer.php");
        require('view/activite/deleteActivite.php');
        if(!empty($deleteActi))
          echo $deleteActi;
      }
      ?>
    </div>
  </div>

<?php } ?>

  <?php $activitesForEncadrant = ob_get_clean(); ?>