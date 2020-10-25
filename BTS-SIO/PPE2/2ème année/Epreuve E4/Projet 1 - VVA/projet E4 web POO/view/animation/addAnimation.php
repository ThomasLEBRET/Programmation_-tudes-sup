<?php ob_start(); ?>

<form id="addAnim" class="justify" style="display:none">
    <h1>Ajouter une animation</h1>
  <div class="form-row">
    <div class="form-group col-md-6">
      <label for="codeAnim">Code de l'animation (8 caractères maximum)</label>
      <input maxlength="8" type="text" class="form-control" id="codeAnim" placeholder="CodeAnim">
    </div>
    <div class="form-group col-md-6">
      <label for="codeTypeAnim">Code du type de l'animation</label>
      <select id="codeTypeAnim">
            <?php for ($i=0; $i < count($cdTypeAnim); $i++): ?>
                <option value="<?= $cdTypeAnim[$i] ?>"><?= ($cdTypeAnim[$i])?></option>
            <?php endfor ?>
        </select>
    </div>
  </div>
  <div class="form-group">
    <label for="inputAddress">Address</label>
    <input type="text" class="form-control" id="inputAddress" placeholder="1234 Main St">
  </div>
  <div class="form-group">
    <label for="inputAddress2">Address 2</label>
    <input type="text" class="form-control" id="inputAddress2" placeholder="Apartment, studio, or floor">
  </div>
  <div class="form-row">
    <div class="form-group col-md-6">
      <label for="inputCity">City</label>
      <input type="text" class="form-control" id="inputCity">
    </div>
    <div class="form-group col-md-4">
      <label for="inputState">State</label>
      <select id="inputState" class="form-control">
        <option selected>Choose...</option>
        <option>...</option>
      </select>
    </div>
    <div class="form-group col-md-2">
      <label for="inputZip">Zip</label>
      <input type="text" class="form-control" id="inputZip">
    </div>
  </div>
  <div class="form-group">
    <div class="form-check">
      <input class="form-check-input" type="checkbox" id="gridCheck">
      <label class="form-check-label" for="gridCheck">
        Check me out
      </label>
    </div>
  </div>
  <button type="submit" class="btn btn-primary">Sign in</button>
</form>
<?php $addAnim = ob_get_clean(); ?>
