#ifndef DEPLACEMENT_HPP_INCLUDED
#define DEPLACEMENT_HPP_INCLUDED

#include "grille.hpp"
#include "coordonnees.hpp"
#include "ensemble.hpp"

/* _Fonctions deplacement.cpp_ */
void deplaceAnimal (grille g, grille &nouvGrille, animal &a);
bool attaqueRenard(grille &nouvGrille, animal &a);
tab_coord toutEspece(grille g, Animal e);
void deplaceTousLapins(grille g, grille & nouvGrille);
void deplaceTousRenards(grille g, grille & nouvGrille);
void deplace(grille g, grille &nouvGrille);

#endif
