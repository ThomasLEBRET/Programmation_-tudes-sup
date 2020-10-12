<?php
require_once("config.php");
//connexion et déconnexion
assert(dbConnect() == true);
$con = dbConnect();
assert(dbDisconnect($con) == true);
assert(startSession() == true);
$_SESSION['bonjour'] = "test";
assert(closeSession("") == true);
//regex()
assert(regexMail("th.lebret@outlook.fr") == true);
assert(regexMail("tdezhjfrihjeerhjhirej") == false);
assert(regexMail("t.le@or") == false);

//comparePassword()
assert(comparePassword("", "") == false);
assert(comparePassword("th", "lb") == false);
assert(comparePassword("th", "th") == true);
//salt()
assert((salt() == "^575e6bU") == false);
//checkSalt()
assert(checkSalt("^575e6bU") == false); //le sel existe pour 1 user inscrit dans la base de données
assert(checkSalt("12345678") == true); //sel qui n'existe pas dans la bdd
assert(checkSalt("123456") == false); //sel qui n'existe pas et qui ne possède pas 8 caractères très exactement
//regexCdp()
assert(regexCdp("91410") == true);
assert(regexCdp("00000") == true);
assert(regexCdp("9141") == false);
//regexDdn()
assert(regexDdn("2000-02-03") == true);
assert(regexDdn("0000-02-03") == false);
assert(regexDdn("-02-03") == false);
assert(regexDdn("1020-15-03") == false);
assert(regexDdn("1020-8-30") == false);
assert(regexDdn("1020-08-34") == false);
