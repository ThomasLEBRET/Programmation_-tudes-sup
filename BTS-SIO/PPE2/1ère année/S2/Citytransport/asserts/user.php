<?php
require_once("config.php");
function verifySession() {
	if(!empty($_SESSION)) {
		foreach ($_SESSION as $key => $value) {
			if(empty($value)) {
				if($value != 0) {
					echo "erreur pour la clé ".$key;
				}
			}
		}
	}
}

//checkEmail()
assert(checkEmail("th.lebret@outlook.fr") == true);
assert(checkEmail("dslfkeoijfejo") == false);
assert(checkEmail("") == false);
//getUserByEmail()
assert(getUserByEmail("th.lebret@outlook.fr") == true);
verifySession();
assert(getUserByEmail("asKEZHKAEZIJJ") == false);
verifySession();
//getUserByToken()
assert(getUserBytoken("") == false);
assert(getUserBytoken("zadze") == false);
assert(getUserBytoken("20398122915ea67fba6e6232.07958866") == true);
assert(getUserBytoken("123456") == false);
//insertUser()
assert(insertUser("     ", "     ", "     ", "     ", "     ", "     ", "     ","     ","     ","     ","     ") == false);
assert(insertUser("th.lebret@outlook.fr", "     ", "     ", "     ", "     ", "     ", "     ","     ","     ","     ","     ") == false);
assert(insertUser("th.lebret@orange.fr", "     ", "     ", "     ", "     ", "     ", "     ","     ","     ","     ","     ") == false);
assert(insertUser("th.lebret@orange.fr", "A", "LEBRET", "Thomas", " ", "     ", "91410","     ","     ","     ","     ") == false);
assert(insertUser("th.lebret@orange.fr", "A", "LEBRET", "Thomas", "2000-02-03", "", "91410","     ","     ","     ","     ") == false);
assert(insertUser("th.lebret@orange.fr", "A", "LEBRET", "Thomas", "2000-02-03", "4 Allée JOLIVOT", "91410","     ","     ","     ","     ") == false);
//assert(insertUser("th.lebret@orange.fr", "H", "LEBRET", "Thomas", "2000-02-03", "4 Allée JOLIVOT", "91410","azertyui","La Forêt Le Roi","0","teszjk91t") == true);
//isVerified()
assert(isVerified("20398122915ea67fba6e6232.07958866") == false); //token existant mais compte déjà vérifié
assert(isVerified("qjkhqsjqs") == false);
assert(isVerified("") == false);
//createTokenForUser
assert(createTokenForUser("") == false);
assert(createTokenForUser("th.lebret@outlook.fr") == false); //mail existant mais compte déjà vérifié
assert(createTokenForUser("th.lebret@orange.fr") == false); //mail non existant dans la table user
//generateToken
//assert(generateToken("th.lebret@outlook.fr") == true); //adresse mail existante
assert(generateToken("") == false); //adresse mail vide / non existante
//userVerified
assert(userVerified("th.lebret@outlook.fr") == true); //mail existant
assert(userVerified("") == false); //mail non existant ou vide
//connectUser
assert(connectUser("th.lebret@outlook.fr", "test") == true);
assert(connectUser("th.lebret@outlook.fr", "zdkjfzdkjz") == false);
assert(connectUser("th.lebret@outerzvze.r", "test") == false);
//mailExist
assert(mailExist("th.lebret@outlook.fr") == true);
assert(mailExist("th.lebret@gmail.fr") == false);
assert(mailExist("") == false);
