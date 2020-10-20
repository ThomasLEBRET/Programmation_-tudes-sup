<?php ob_start(); ?>

<form id="inscription" method="POST" action="index.php?page=inscription&anim=<?= $this->activite->getCodeanim() ?>&acti=<?= $this->activite->getNoAct() ?>">
<input type="hidden" name="cdAnim" value="<?= $this->activite->getCodeanim() ?>"/>
<input type="hidden" name="noAct" value="<?= $this->activite->getCodeanim() ?>"/>
<input type="hidden" name="inscription" value="Inscription"/>
</form>
<a onclick='document.getElementById("inscription").submit()' class="btn btn-primary">S'inscrire</a>

<?php $btn = ob_get_clean(); ?>
