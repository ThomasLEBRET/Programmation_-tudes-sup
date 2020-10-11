#include <iostream>
#include<vector>
#include<cmath>

using namespace std;

enum genre {homme, femme};
enum orientation {hetero, homo};

struct Personne
{
    string prenom;
    string nom;
    int annee;
    genre g;
    orientation o;
};

Personne nouvellePersonne(string n, string p, int a, genre g, orientation o){
    Personne nouveau;
    nouveau.nom = n;
    nouveau.prenom = p;
    nouveau.annee = a;
    nouveau.g = g;
    nouveau.o = o;
    return nouveau;
}

    vector<Personne> population = {
        nouvellePersonne("Bonnet", "Jean", 1979, homme),
        nouvellePersonne("Lefebvre", "Michel", 1981, homme),
        nouvellePersonne("Leroy", "Pierre", 1977, homme),
        nouvellePersonne("Petit", "Philippe", 1984, homme),
        nouvellePersonne("Morel", "Alain", 1990, homme),
        nouvellePersonne("Fournier", "Marie", 1985, femme),
        nouvellePersonne("Durand", "Nathalie", 1989, femme),
        nouvellePersonne("Dubois", "Isabelle", 1975, femme),
        nouvellePersonne("Moreau", "Catherine", 1982, femme),
        nouvellePersonne("Girard", "Sylvie", 1987, femme)
    };

bool estFaisable(Personne P1, Personne P2){
   return (abs(P1.annee-P2.annee <7) && P1.o==P2.o);
}

void AfficheCoupleFaisable(vector<Personne> t){
    for (int i = 0; i < t.size(); i++){
        for (int j = i+1; j < t.size()-1; j++) {
            if (estFaisable(t[i], t[j]))
            {
                cout << "Est faisable : " << t[i].prenom << "  " << t[i].nom << " et " << t[j].prenom << "  " << t[j].nom << endl;
            }
        }
    }
}

int main(){
    AfficheCoupleFaisable(population);
    return 0;
}