<?php
    $_SESSION['CODEANIM'] = $ligne['CODEANIM'];
?>
<div class="card">
  <div class="card-header">
    <?= 'Prix : '.$ligne['PRIXACT']. '€'?>
  </div>
  <div class="card-body">
    <h5 class="card-title"><?= $ligne['DATEACT'] ?></h5>
    <p class="card-text">Heure de rendez-vous à <?= $ligne['HRRDVACT'] ?></p>
    <p class="card-text">Départ à <?= $ligne['HRDEBUTACT'] ?></p>

    <?php if(!estInscritActivite($_SESSION['USER'], $ligne['NOACT'])) { ?>

    <form id="inscription" method="POST" action="index.php?page=animation&anim=<?= $ligne['CODEANIM'] ?>">
    <input type="hidden" name="cdAnim" value="<?= $ligne['CODEANIM'] ?>"/>
    <input type="hidden" name="noAct" value="<?= $ligne['NOACT'] ?>"/>
    <input type="hidden" name="inscription" value="inscription"/>
    </form>
    <?php
    if($_SESSION['TYPEPROFIL'] == "VA") {?>
        <a onclick='document.getElementById("inscription").submit()' class="btn btn-primary">S'inscrire</a>
    <?php } ?>


<?php } else { ?>
    <form id="desinscription" method="POST" action="index.php?page=animation&anim=<?= $ligne['CODEANIM'] ?>">
    <input type="hidden" name="cdAnim" value="<?= $ligne['CODEANIM'] ?>"/>
    <input type="hidden" name="noAct" value="<?= $ligne['NOACT'] ?>"/>
    <input type="hidden" name="desinscription" value="deinscription"/>
    </form>
    <a onclick='document.getElementById("desinscription").submit()' class="btn btn-secondary">Se désinscrire</a>
<?php } ?>

  </div>
</div>
