#ifndef COORDONNEES_HPP_INCLUDED
#define COORDONNEES_HPP_INCLUDED

const int TAILLE = 20;
const int T=TAILLE*TAILLE;

struct coord { int x,y; };

struct tab_coord{
    coord tab[T];
    int n;
};

/* _Fonctions coordonnees.cpp_ */

/* Créer une coordonnée en fonction de 2 entiers */
coord creeCoord( int x, int y );

/* Récupère une coordonnée en x */
int getX(coord c);

/* Récupère une coordonnée en y */
int getY(coord c);

/* Vérifie que 2 coordonnées sont équivalentes */
bool egalCoord ( coord c1, coord c2);

/* Retourne une coordonnée aléatoirement dans un ensemble de coordonnées */
coord randomCoord( tab_coord t);

/* Vérifie qu'une coordonnée est dans la grille */
bool coord_valide(coord a);

/* Ajoute une coordonnée dans un ensemble de coordonnées */
void ajoute_coord( tab_coord  &t, coord c);

/* Retourne les voisins d'une coordonnée */
tab_coord retourne_voisins(coord c);

#endif
