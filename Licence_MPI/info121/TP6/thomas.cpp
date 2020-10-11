#include <cstdlib>
#include <iostream>
#include <string>
using namespace std;

const int MAXPERSONNES = 50;
#define ASSERT(test) if (!(test)) cout << "Test failed in file " << __FILE__ \
                                       << " line " << __LINE__ << ": " #test << endl

enum Genre { M, F };

struct Personne{
string nom;
Genre genre;
int indConjoint, indParent1, indParent2;
};

struct EtatCivil {
Personne tableP[MAXPERSONNES];
int nbP;
};

int dansEtatCivil (string nom, EtatCivil EC) {
  for(int i = 0; i < EC.nbP; i++) {
    if(EC.tableP[i].nom == nom) return i;
  }
  return -1;
}

void testDansEtatCivil(EtatCivil EC){
  ASSERT(dansEtatCivil("Helene",EC) == 7);
  ASSERT(dansEtatCivil("Tartampion",EC) == -1);
}

void AjoutPersonne(string nom, Genre s, int parent1, int parent2, EtatCivil &EC) {
  if(dansEtatCivil(nom,EC)<=0 && EC.nbP < MAXPERSONNES) {
    EC.tableP[EC.nbP] = {nom, s, -1, parent1, parent2};
    EC.nbP++;
  }
  else cout << "Parametres invalides ! " << endl;
}

void AffichePersonne(int ind, EtatCivil EC) {
  if(ind < 0 || ind >=  EC.nbP) cout << "La personne n existe pas ! " << endl;
  else {
    Personne p = EC.tableP[ind];
    cout << "Nom : " << p.nom << endl;
    switch (p.genre) {
      case M: cout << "Genre : Homme" << endl; break;
      case F: cout << "Genre : Femme" << endl; break;
      default: cout << "Genre : Non identifie" << endl;
    }
    if(p.indConjoint >= 0  && p.indConjoint < EC.nbP) cout << "Conjoint : " << EC.tableP[p.indConjoint].nom << endl;
    if(p.indParent1 >= 0  && p.indParent1 < EC.nbP) cout << "Parent 1 : " << EC.tableP[p.indParent1].nom << endl;
    if(p.indParent2 >= 0  && p.indParent2 < EC.nbP) cout << "Parent 2 : " << EC.tableP[p.indParent2].nom << endl;
  }
  cout << endl;
}

void AfficheEtatCivil(EtatCivil EC) {
	for (int i = 0; i < EC.nbP; i++)
		AffichePersonne(i, EC);
}

void RemplitEtatCivil(EtatCivil &EC) { // remplit l'état civil avec 20 personnes
AjoutPersonne("Noemie", F, -1, -1, EC);
AjoutPersonne("Georges", M, -1, -1, EC);
AjoutPersonne("Albert", M, -1, -1, EC);
AjoutPersonne("Marie", F, -1, -1, EC);
AjoutPersonne("Luc", M, 0, -1, EC);
AjoutPersonne("Valerie", F, -1, 1, EC);
AjoutPersonne("Stephane", M, 3, 2, EC);
AjoutPersonne("Helene", F, 5, 4, EC);
AjoutPersonne("Justine", F, 7, 6, EC);
AjoutPersonne("Berenice", F, 5, 10, EC);
AjoutPersonne("John", M, 12, 11, EC);
AjoutPersonne("Franco", M, -1, -1, EC);
AjoutPersonne("Viviane", F, -1, -1, EC);
AjoutPersonne("Pierre", M, 9, 14, EC);
AjoutPersonne("Remi", M, 16, 15, EC);
AjoutPersonne("Boris", M, -1, 17, EC);
AjoutPersonne("Sharon", F, 19, 18, EC);
AjoutPersonne("Alexandre", M, -1, -1, EC);
AjoutPersonne("Augustin", M, -1, -1, EC);
AjoutPersonne("Johanne", F, -1, -1, EC);
}


int main() {
 EtatCivil EC;
 EC.nbP = 0; // il est necessaire d'initialiser le nombre de personnes
 RemplitEtatCivil(EC);
 testDansEtatCivil(EC);
 AfficheEtatCivil(EC);
}
