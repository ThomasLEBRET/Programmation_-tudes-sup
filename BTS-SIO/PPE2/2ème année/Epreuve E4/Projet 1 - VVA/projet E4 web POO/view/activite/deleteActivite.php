<?php ob_start() ?>


<form id="delete<?= $this->activite->getNoact() ?>" class="justify" style="display:none" method="POST" action="index.php?page=annuleActivite">
    <h1>Supprimer l'activite</h1>
    <p>Voulez-vous supprimer définitivement cette animation ?</p>
    <input type="hidden" name="NOACT" value="<?= $this->activite->getNoact() ?>">
  <button type="submit" class="btn btn-danger">Supprimer</button><br>
  <i>Cela annulera l'activité les inscriptions associées à cette activité</i>
</form>

<?php $deleteActi = ob_get_clean(); ?>
