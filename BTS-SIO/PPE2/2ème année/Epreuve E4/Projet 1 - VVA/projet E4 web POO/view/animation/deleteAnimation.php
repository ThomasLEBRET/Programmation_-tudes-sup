<?php ob_start() ?>


<form id="deleteAnim" class="justify" style="display:none">
    <h1>Supprimer l'animation</h1>
    <p>Voulez-vous supprimer définitivement cette animation ?</p>
  <button type="submit" class="btn btn-primary">Sign in</button><br>
  <i>Cela supprimera toutes les activités associées ainsi que les inscriptions associées aux activités</i>

</form>

<?php $deleteAnim = ob_get_clean(); ?>
