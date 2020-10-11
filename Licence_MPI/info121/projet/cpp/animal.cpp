#include <iostream>
#include "../hpp/animal.hpp"

using namespace std;
/*Fonctions d animaux */

/*cree un animal a partir de ses coordonnes et son espece*/
animal creerAnimal( Animal g, coord c) {
	animal a;
	a.genre = g;
	a.c=c;
	a.nourriture=FoodInit;
	a.age = 0;
	return a;
}

/*retourne les coordonnees dun animal*/
coord coordAnimal( animal a) { return a.c; }

/*retourne l espece d un animal */
Animal especeAnimal( animal a) { return a.genre; }

/*retourne le niveau de nourriture dun animal*/
int nourritureAnimal(animal a) { return a.nourriture; }

/* teste si il n y a pas d animal*/
bool estVide (animal a) { return a.genre==Rien; }

/* change les coordonnees d un animal */
void changeCoordAnimal (animal &a, coord c) { a.c=c; }

/* augmente le niveau de nourriture d un renard*/
void mangeRenard (animal &a) { if (especeAnimal(a)==Renard and a.nourriture <=MaxFood) a.nourriture+=FoodLapin; }

/* diminue le niveau de nourriture d un renard*/
void faimRenard (animal &a) {	if (especeAnimal(a)==Renard) a.nourriture-=1; }

int ageAnimal(animal a) { return a.age; }

/* teste si un animal est mort */
bool mortAnimal(animal a) {
	int esperance_vie_lapin = 9;
	int esperance_vie_renard = 5;
	switch(especeAnimal(a)) {
		case Renard : return(((nourritureAnimal(a)<=0) || (ageAnimal(a)) > esperance_vie_renard));
		case Lapin : return (ageAnimal(a) > esperance_vie_lapin);
		default : cout << " Pas d animal! " << endl;
	}
	return true;
}

/*teste si un animal se reproduit */
bool seReproduitAnimal(animal a, int nombreCaseVide) {
	float n = rand()%100;
	switch(especeAnimal(a)){
		case Renard : return (nourritureAnimal(a)>=FoodReprod and n/100. <ProbBirthRenard);
		case Lapin : return (nombreCaseVide >= MinFreeBirthLapin and n/100.<ProbBirthLapin);
		default : cout << " Pas d animal " << endl;
	}
	return true;
}
