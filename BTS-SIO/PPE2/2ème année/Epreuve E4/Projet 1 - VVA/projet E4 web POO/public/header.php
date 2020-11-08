<?php $page = $_GET['page']; ?>

<nav class="navbar navbar-expand-lg navbar-dark bg-primary">
    <a class="navbar-brand" href="index.php?page=accueil">VVA</a>
    <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarNav" aria-controls="navbarNav" aria-expanded="false" aria-label="Toggle navigation">
        <span class="navbar-toggler-icon"></span>
    </button>
    <div class="collapse navbar-collapse" id="navbarNav">
        <ul class="navbar-nav">
            <?php if(!empty(Session::get('USER'))): ?>
              <li class="nav-item <?php if($page == 'accueil' || $page == 'dashboard') echo "active" ?>">
                  <a class="nav-link" href="index.php?page=accueil">Accueil<span class="sr-only"></span></a>
              </li>
              <li class="nav-item <?php if($page == 'animation') echo "active" ?>">
                  <a class="nav-link" href="index.php?page=animation">Animations</a>
              </li>
                <li class="nav-item <?php if($page == 'compte') echo "active" ?>">
                    <a class="nav-link" href="index.php?page=compte">Mon compte</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" href="index.php?page=deconnexion">Déconnexion</a>
                </li>
            <?php endif ?>
        </ul>
    </div>
</nav>
