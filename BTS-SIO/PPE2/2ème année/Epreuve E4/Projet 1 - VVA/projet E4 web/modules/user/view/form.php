<div class="jumbotron jumbotron-fluid justify">
    <div class="container">
        <h1 class="display-4">Bienvenue</h1>
        <p class="lead">Connectez-vous</p>
        <p class="lead">
            <form action="index.php?page=accueil" method="POST">
                <div class="form-group">
                    <label for="exampleInputEmail1">Nom utilisateur</label>
                    <input name="username" type="text" class="form-control" id="exampleInputEmail1" aria-describedby="emailHelp">
                </div>
                <div class="form-group">
                    <label for="exampleInputPassword1">Mot de passe</label>
                    <input name="mdp" type="password" class="form-control" id="exampleInputPassword1">
                </div>
                <input type="submit" name="btEnvoyer" value="Envoyer" class="btn bt-primary">
            </form>
        </div>
    </div>
