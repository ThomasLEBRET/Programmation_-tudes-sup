/* Deplacement */
#include "../hpp/deplacement.hpp"

/*deplace un animal sur une case libre*/
void deplaceAnimal (grille g, grille &nouvGrille, animal &a) {
  a.age++;
  coord nouvelleCoord; coord ancienneCoord(coordAnimal(a)); Animal e=especeAnimal(a);
  tab_coord casesVides; casesVides.n=0;
  casesVides=intersectionEnsCoord(voisinsEspeces(nouvGrille,a,Rien),voisinsEspeces(g,a,Rien));
  if (casesVides.n!=0){
    nouvelleCoord = randomCoord(casesVides);
    changeCoordAnimal(a,nouvelleCoord);
    if (seReproduitAnimal(a,casesVides.n)) setAnimal(nouvGrille,creerAnimal(e,ancienneCoord));
  }
  setAnimal(nouvGrille,a);
}

/*deplace un renard sur une case d un lapin et retourne vrai sinon retourne faux*/
bool attaqueRenard(grille &nouvGrille, animal &a) {
  a.age++;
  coord ancienneCoord=coordAnimal(a); Animal e =especeAnimal(a);
  coord nouvelleCoord;
  tab_coord casesLapins; casesLapins.n=0;
  casesLapins=voisinsEspeces(nouvGrille,a,Lapin); //ensemble des cases avec des lapins
  if (casesLapins.n!=0){ // si il ya des lapins
    nouvelleCoord = randomCoord(casesLapins); //choisi une case au hasard
    changeCoordAnimal(a,nouvelleCoord);
    mangeRenard(a);
    setAnimal(nouvGrille,a); //place l animal dans la nouvelle grille
    if (seReproduitAnimal(a,casesLapins.n)) setAnimal(nouvGrille,creerAnimal(e,ancienneCoord));
    return true;
  }
  faimRenard(a);
  return false;
}

/*retourne l ensemble des coordonnees des animaux de l espece e */
tab_coord toutEspece(grille g, Animal e) {
  coord c;
  tab_coord v;
  v.n=0;
  for (int i=0; i < TAILLE ; i++){
    for (int j=0; j <TAILLE ; j++){
      c=creeCoord(j,i);
      if (especeAnimal(g.t[i][j])==e and coord_valide(c)) {
        ajoute_coord(v,c);
      }
    }
  }
  return v;
}

/* deplace tous les lapins*/
void deplaceTousLapins(grille g, grille & nouvGrille) {
  animal a; coord c; tab_coord t;
  t.n=0;
  t = toutEspece(g, Lapin);
  while( t.n!=0){
    c=randomCoord(t); //choisi un animal au hasard
    a=getAnimal(g,c);	 	 //fait une copie de l animal
    retire(t,c);	 //retire l animal de l ensemble pour pas a revoir a le re deplacer
      if (!mortAnimal(a)) deplaceAnimal(g,nouvGrille,a);
  }
}

/*Deplace tous les renards*/
void deplaceTousRenards(grille g, grille & nouvGrille) {
  animal a;coord ancienneCoord; tab_coord t;
  t.n=0;
  t = toutEspece(g, Renard);
  while(t.n!=0){
    ancienneCoord=randomCoord(t); //choisi un animal au hasard
    a=getAnimal(g,ancienneCoord); //fait une copie de l animal
    retire(t,ancienneCoord);	 //retire l animal de l ensemble pour pas a revoir a le re deplacer
    if (not attaqueRenard(nouvGrille,a) and not mortAnimal(a)){ //si lanimal nest pas mort et n a pas deja ete deplace avec attaqueRenard
      deplaceAnimal(g,nouvGrille,a);
    }
  }
}

void deplace(grille g, grille &nouvGrille) {
  deplaceTousLapins(g,nouvGrille);
  deplaceTousRenards(g,nouvGrille);
}
