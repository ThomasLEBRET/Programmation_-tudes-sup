<br>
<div class="card">
  <div class="card-header">
    <?= 'Vous participez à l animation  '.$ligne['NOMANIM'] ?>
  </div>
  <div class="card-body">
    <h5 class="card-title">Date de l'activité : <?= $ligne['DATEACT'] ?></h5>
    <p class="card-text">Heure de rendez-vous à <?= $ligne['HRRDVACT'] ?></p>
    <p class="card-text">Départ à <?= $ligne['HRDEBUTACT'] ?></p>
    <form id="desinscription" method="POST" action="index.php?page=animation&anim=<?= $ligne['CODEANIM'] ?>">
    <input type="hidden" name="cdAnim" value="<?= $ligne['CODEANIM'] ?>"/>
    <input type="hidden" name="noAct" value="<?= $ligne['NOACT'] ?>"/>
    <input type="hidden" name="desinscription" value="deinscription"/>
    </form>
    <a onclick='document.getElementById("desinscription").submit()' class="btn btn-secondary">Se désinscrire</a>
</div>
</div>
