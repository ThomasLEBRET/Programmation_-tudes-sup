/*Fonctions ensemble*/
#include "../hpp/ensemble.hpp"

using namespace std;

/*verifie si la coordonnees c est presente dans lensemble t*/
bool estDans(tab_coord t, coord c, int &indice) {
  for (int i=0; i<t.n;i++){
    if(egalCoord(t.tab[i], c)) {
      indice=i;
      return true;
    }
  }
  return false;
}

/*retire la coordonnees c de lensemble t si presente*/
void retire(tab_coord &t, coord c) {
  int indice=0;
  if (estDans(t,c, indice)){
    for (int i= indice ; i<t.n-1 ;i++) t.tab[i]=t.tab[i+1];
    t.n-=1;
  }
}

/*teste si un ensemble est vide*/
bool estVide(tab_coord t) {
  return t.n==0;
}

/*retourne lintersection de deux ensemble*/
tab_coord intersectionEnsCoord(tab_coord t, tab_coord v) {
  tab_coord h; int j;
  h.n=0;
  for (int i=0; i<t.n ;i++){
    if (estDans(v,t.tab[i],j)) ajoute_coord(h,t.tab[i]);
  }
  return h;
}
