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

void AjoutPersonne(string sonNom, Genre s, int parent1, int parent2, EtatCivil &EC){

  if (sonNom.size() == 0 || sonNom.size() > 20)  cout << "Paramètres invalides !" <<endl;
  else {
  Personne humain;
  humain.nom = sonNom;
  humain.genre = s;
  humain.indConjoint = -1;
  humain.indParent1 = parent1;
  humain.indParent2 = parent2;
  EC.tableP[EC.nbP] = humain;
  EC.nbP++;
  }
}

void AffichePersonne(int ind, EtatCivil EC){
  Personne h;
  if (ind >= EC.nbP || ind < 0) cout << "Erreur, la personne n'existe pas ! " << endl;
  else {
    h = EC.tableP[ind];
    cout << "Prenom : " << h.nom << endl << "Genre : " << h.genre << endl <<
    "Statut martial : " << h.indConjoint << endl << "Parent 1 : "
    << h.indParent1 << endl << "Parent 2 : " << h.indParent2 << endl;

  }
}

void AfficheEtatCivil(EtatCivil EC) {
  for (int i = 0; i < EC.nbP; i++) {
    AffichePersonne(i,EC);
  }
}

int recherche(EtatCivil EC, string nomHumain){
  int ind = -1;
  for (int i = 0; i < EC.nbP; i++){
    if (EC.tableP[i].nom == nomHumain) {
      ind = i;
    }
  }
  cout << ind;
  return ind;
}

bool mariage(EtatCivil EC, string nomP1, string nomP2){
  int i1 = recherche(EC, nomP1);
  int i2 = recherche(EC, nomP2);

  return (i1 != -1 && i2 != -1 && EC.tableP[i1].indConjoint == -1 && EC.tableP[i2].indConjoint == -1 && i1 != i2);
}

void testMariage(EtatCivil EC){
  ASSERT(mariage(EC, "Noemie", "Georges") == true);
  ASSERT(mariage(EC, "Noemie", "Noemie") == false);
  ASSERT(mariage(EC, "Noemie", "Marie") == true);
  ASSERT(mariage(EC, "Georges", "Albert") == true);
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
  AffichePersonne(1,EC);
  AfficheEtatCivil(EC);
  recherche(EC, "Marie");
  testMariage(EC);
  return 0;
}
