<div class="jumbotron jumbotron-fluid justify">
    <div class="container">
        <?php if($_SESSION['TYPEPROFIL'] == "VA"){ ?>
            <h1>Vous êtes connecté en tant que vacancier </h1>
        <?php } else { ?>
            <h1>Vous êtes connecté en tant qu'encadrant </h1>
        <?php } ?>
        <h1 class="display-4">Bienvenu <?php echo $_SESSION['PRENOMCOMPTE']." ".$_SESSION['NOMCOMPTE']; ?> !</h1>
        <h3>Mes données personnelles</h3>
        <p>Email : <a href="mailto: <?php echo $_SESSION['ADRMAILCOMPTE'] ?> "><?php echo $_SESSION['ADRMAILCOMPTE'] ?></a></p>
        <p>Date de naissance : <?php echo date($_SESSION['DATENAISCOMPTE']) ?></p>
    </div>
</div>
