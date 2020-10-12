<br>
<div class="card">
  <div class="card-header">
    <?= 'Vous avez créé une animation : '.$ligne['NOMANIM'] ?>
  </div>
  <div class="card-body">
    <h5 class="card-title">Date de l'activité : <?= $ligne['DATEACT'] ?></h5>
    <p class="card-text">Heure de rendez-vous à <?= $ligne['HRRDVACT'] ?></p>
    <p class="card-text">Départ à <?= $ligne['HRDEBUTACT'] ?></p>

    <form id="annulation" method="POST" action="index.php?page=animation&anim=<?= $ligne['CODEANIM'] ?>">
    <input type="hidden" name="cdAnim" value="<?= $ligne['CODEANIM'] ?>"/>
    <input type="hidden" name="noAct" value="<?= $ligne['NOACT'] ?>"/>
    <input type="hidden" name="suppression" value="suppression"/>
    </form>
    <a onclick='document.getElementById("annulation").submit()' class="btn btn-secondary">Annuler l'activité</a>

</div>
</div>
