<div class="card bg-white justify text-dark">
    <article class="card-body mx-auto" style="max-width: 400px;">
        <h4 class="card-title mt-3 text-center text-dark">Simulation</h4>
        <form method="post" action="index.php?page=search">
            <div class="form-group input-group">
                <div class="input-group-prepend">
                    <span class="input-group-text"> <img src='img/icon/train.svg' class='logo' width='20' height='20'/> </span>
                </div>
                <input name="depart" class="form-control" placeholder="Station de départ" type="text">
            </div>
            <div class="form-group input-group">
                <div class="input-group-prepend">
                    <span class="input-group-text"> <img src='img/icon/flag.svg' class='logo' width='20' height='20'/> </span>
                </div>
                <input name="destination" class="form-control" placeholder="Station de destination" type="text">
            </div>
            <div class="form-group">
                <button type="submit" class="btn btn-primary btn-block"> Simuler  </button>
            </div>
        </form>
    </article>
    <img src="<?php echo CHEMIN_IMG ?>/map.jpg" alt="map" name="map" id="map" class="justify" />
</div>
