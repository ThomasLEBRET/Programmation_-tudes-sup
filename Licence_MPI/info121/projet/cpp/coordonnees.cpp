/* ___Fonctions de coordonnees___ */
#include <iostream>

#include "../hpp/coordonnees.hpp"

/* Cree une coordonnee */
coord creeCoord( int x, int y ) {
  coord c;
  c.x=x;
  c.y=y;
  return c;
}

/* Recupere donnees de coordonnee */
int getX(coord c) { return c.x; }

int getY(coord c) { return c.y; }

/* Teste si deux coordonnees sont egales */
bool egalCoord ( coord c1, coord c2) {
  if(getX(c1) != getX(c2)) return false;
  if(getY(c1) != getY(c2)) return false;
  return true;
}

/* Retourne une coord au hasard dans un tableau de coord */
coord randomCoord( tab_coord t) {
  int a;
  if (t.n!=0) a=rand()%t.n;
  return t.tab[a];
}

/* Teste si les coordonnees sont dans la grille */
bool coord_valide(coord a) {
  bool valide=false;
  if (a.x >= 0 && a.x < TAILLE && a.y >= 0 && a.y < TAILLE) valide = true;
  return valide;
}

/* Ajoute une coord a un ensemble de coord */
void ajoute_coord( tab_coord  &t, coord c) {
  t.tab[t.n]=c;
  t.n+=1;
}

/* Retourne les voisins dune coordonne */
tab_coord retourne_voisins(coord c) {
  coord b;
  tab_coord voisins;
  voisins.n=0;
  for (int i = getX(c)-1 ; i <= getX(c)+1; i++){
    for (int j = getY(c)-1; j<=getY(c)+1; j++){
      b=creeCoord(i,j);
      if (coord_valide(b) and not egalCoord(b,c)) ajoute_coord(voisins, b);
    }
  }
  return voisins;
}
