<?php
require_once("config.php");
//setHistoriqueUser
assert(setHistoriqueUser("", "Masséna") == false);
assert(setHistoriqueUser("Masséna", "") == false);
assert(setHistoriqueUser("Cusset", "Cusset") == false);
//assert(setHistoriqueUser("Cusset", "Masséna") == true);
//getHistoriqueByUser
assert(getHistoriqueByUser("th.lebret@outlook.fr") == true);
assert(getHistoriqueByUser("") == false);
assert(getHistoriqueByUser("sdkjsdfkjqdslji@zekhdsjihds.com") == false);
