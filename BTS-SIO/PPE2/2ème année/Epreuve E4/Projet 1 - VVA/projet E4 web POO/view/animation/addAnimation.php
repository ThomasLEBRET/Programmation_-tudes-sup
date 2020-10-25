<?php ob_start(); ?>

<form id="addAnim" class="justify" style="display:none;" method="POST" action="index.php?page=ajouterAnimation">
    <h1>Ajouter une animation</h1>
    <div class="form-row">
        <div class="form-group col-md-6">
            <label for="CODEANIM">Code de l'animation (8 caractères maximum)</label>
            <input name="CODEANIM" required maxlength="8" type="text" class="form-control" id="CODETYPEANIM" placeholder="CodeAnim">
        </div>
        <div class="form-group col-md-6">
            <label for="CODETYPEANIM">Code du type de l'animation</label>
            <select name="CODETYPEANIM" id="CODETYPEANIM" class="form-control">
                <?php for ($i=0; $i < count($cdTypeAnim); $i++): ?>
                    <option value="<?= $cdTypeAnim[$i] ?>"><?= ($cdTypeAnim[$i])?></option>
                <?php endfor ?>
                <?php var_dump($cdTypeAnim); ?>
            </select>
        </div>
    </div>
    <div class="form-group">
        <label for="NOMANIM">Nom</label>
        <input name="NOMANIM" required type="text" class="form-control" id="NOMANIM" placeholder="Nom animation">
    </div>
    <div class="form-row">
        <div class="form-group col-md-6">
            <label for="DATEVALIDITEANIM">Date de validité de l'animation</label>
            <input name="DATEVALIDITEANIM" required type="date" class="form-control" id="DATEVALIDITEANIM" value="<?= date("Y-m-d") ?>" min="<?= date("Y-m-d") ?>">
        </div>
        <div class="form-group col-md-6">
            <label for="DUREEANIM">Durée</label>
            <input name="DUREEANIM" type="number" class="form-control" id="DUREEANIM" value="0.15" min="0.15" step="any">
        </div>
    </div>
    <div class="form-row">
        <div class="form-group col-md-6">
            <label for="LIMITEAGE">Limite d'âge</label>
            <input name="LIMITEAGE" required type="number" class="form-control" id="LIMITEAGE" value="3" min="3" step="any">
        </div>
        <div class="form-group col-md-4">
            <label for="TARIFANIM">Tarif(€)</label>
            <input name="TARIFANIM" required type="number" class="form-control" id="TARIFANIM" placeholder="Prix animation" value="1" step="any">
        </div>
        <div class="form-group col-md-2">
            <label for="NBREPLACEANIM">Nombre de places</label>
            <input name="NBREPLACEANIM" required type="number" class="form-control" id="NBREPLACEANIM" value="1" min="1" step="1">
        </div>
    </div>
    <div class="form-group">
        <label for="DESCRIPTANIM">Description</label>
        <textarea id="DESCRIPTANIM" required class="form-control" name="DESCRIPTANIM" rows="4" cols="80"></textarea>
    </div>
    <div class="form-group">
        <label for="COMMENTANIM">Commentaire</label>
        <textarea id="COMMENTANIM" required class="form-control" name="COMMENTANIM" rows="4" cols="80"></textarea>
    </div>
    <div class="form-group">
        <label for="DIFFICULTEANIM">Difficulté</label>
        <input id="DIFFICULTEANIM" required class="form-control" type="text" name="DIFFICULTEANIM" placeholder="Facile / Moyen / Difficile">
    </div>
    <button type="submit" class="btn btn-primary">Ajouter l'animation</button>
</form>
<?php $addAnim = ob_get_clean(); ?>
