from math import *
nbr = 600851475143
newnbr = nbr
facteur = 0
cpt = 2

while pow(cpt,2) < newnbr:
	if newnbr%cpt == 0:
		newnbr = newnbr/cpt
		facteur = cpt
	else:
		cpt = cpt+1
	if newnbr > facteur:
		facteur = newnbr
print(facteur)
