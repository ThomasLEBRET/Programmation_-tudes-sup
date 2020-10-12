<?php
$var = "1";
echo "\$var"; //Il affiche "$var" et non le contenu de la variable puisque on a mis des guillemets
?>
</br>
<?php
echo $var; //Affiche le contenu de $var
?>
</br>
<?php
$var1 = "texte";
$var2 = "1";
$var3 = 1;
echo $var2;
echo "</br>";
/*
echo $var1 + $var1; //Pas content
echo $var2 + $var2; //Pas content
*/
echo $var1 . $var1;
echo "</br>";
echo $var2 + $var2;
echo "</br>";
echo $var2 . $var2;
echo "</br>";
echo $var3 + $var3;
?>
</br>
<?php
if($var3 == 1) {
  echo "L'expression est vraie";
}
else {
  echo "L'expression est fausse";
}
?>
</br>
<?php
$tab[0] = 0;
$tab[1] = 1;
$tab[2] = 2;
$tab[3] = 3;
for($i = 0; $i <= 3; $i++) {
  echo $tab[$i];
}
?>
