<?php ob_start() ?>


<form id="delete<?= $this->animation->getCodeTypeAnim() ?>" class="justify" style="display:none" method="POST" action="index.php?page=supprimerAnimation">
    <h1>Supprimer l'animation</h1>
    <p>Voulez-vous supprimer définitivement cette animation ?</p>
    <input type="hidden" name="CODEANIM" value="<?= $this->animation->getCodeanim() ?>">
  <button type="submit" class="btn btn-danger">Supprimer</button><br>
  <i>Cela annulera toutes les activités associées ainsi que les inscriptions associées aux activités annulées</i>
</form>

<?php $deleteAnim = ob_get_clean(); ?>
