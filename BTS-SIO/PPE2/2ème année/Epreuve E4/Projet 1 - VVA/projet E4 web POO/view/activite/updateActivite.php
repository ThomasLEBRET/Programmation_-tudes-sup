<?php ob_start(); ?>

<form id="update<?= $this->activite->getNoact() ?>" class="justify" style="display:none;" method="POST" action="index.php?page=ajouterActivite">
    <h1>Ajouter une activité</h1>
    <div class="form-row">
        <div class="form-group col-md-6">
            <label for="DATEACT">Date de l'activité</label>
            <input name="DATEACT" required min="<?= date('Y-m-d') ?>" type="date" class="form-control" id="DATEEACT" placeholder="Date de activité">
        </div>
        <div class="form-group col-md-6">
            <label for="HRRDVACT">Heure de rendez-vous de l'activité</label>
            <input type="time" name="HRRDVACT" require class="form-control" placeholder="Heure de l'activité">
        </div>
    </div>
    <div class="form-group">
        <label for="PRIXACT">Prix</label>
        <input name="PRIXACT" required type="number" class="form-control" id="PRIXACT" placeholder="Prix de l'activité" min="0">
    </div>
    <div class="form-row">
        <div class="form-group col-md-6">
            <label for="HRDEBUTACT">Heure du début de l'activité</label>
            <input name="HRDEBUTACT" required type="time" class="form-control" id="HRDEBUTACT">
        </div>
        <div class="form-group col-md-6">
            <label for="HRFINACT">Heure de fin de l'activité</label>
            <input name="HRFINACT" required type="time" class="form-control" id="HRFINACT">
        </div>
    </div>

    <button type="submit" class="btn btn-primary">Ajouter l'activité</button>
</form>
<?php $updateActi = ob_get_clean(); ?>
