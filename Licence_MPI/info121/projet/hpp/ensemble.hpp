#ifndef ENSEMBLE_HPP_INCLUDED
#define ENSEMBLE_HPP_INCLUDED

#include "coordonnees.hpp"
#include "ensemble.hpp"

/* _Fonctions ensemble.cpp_ */
bool estDans(tab_coord t, coord c, int &indice);
void retire(tab_coord &t, coord c);
bool estVide(tab_coord t);
tab_coord intersectionEnsCoord(tab_coord t, tab_coord v);

#endif
