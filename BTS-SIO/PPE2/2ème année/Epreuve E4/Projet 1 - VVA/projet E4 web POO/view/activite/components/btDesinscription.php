<?php ob_start(); ?>

<form id="desinscription" method="POST" action="index.php?page=desinscription&anim=<?= $this->activite->getCodeanim('CODEANIM') ?>&acti=<?= $this->activite->getNoAct('NOACT') ?>">
<input type="hidden" name="cdAnim" value="<?= $this->activite->getCodeanim('CODEANIM') ?>"/>
<input type="hidden" name="noAct" value="<?= $this->activite->getNoact('CODEANIM') ?>"/>
<input type="hidden" name="desinscription" value="Désinscription"/>
</form>
<a onclick='document.getElementById("desinscription").submit()' class="btn btn-secondary">Se désinscrire</a>

<?php $btn = ob_get_clean(); ?>
