    <div class="card">
      <div class="card-header">
          <?php
            if($ligne['NBREPLACEANIM'] == 0) {
                echo 'Il ne reste aucune place pour cette activité';
            }
          ?>
        <?= 'Il reste '.$ligne['NBREPLACEANIM']. ' places pour cette animation. Se termine le '.$ligne['DATEVALIDITEANIM'] ?>
      </div>
      <div class="card-body">
        <h5 class="card-title"><?= $ligne['NOMANIM'] ?></h5>
        <p class="card-text"><?= $ligne['DESCRIPTANIM'] ?></p>
        <a href="index.php?page=animation&anim=<?= $ligne['CODEANIM'] ?>" class="btn btn-primary">Dates des activités <?= $ligne['CODEANIM'] ?></a>
    </div>
    </div>
