#include <iostream>
#include <cstdlib>
#include <string>

using namespace std;    

const int NB_CARTES = 40;

enum Couleur { P, Co, T, Ca };

struct Carte {
    int valeur;
    Couleur couleur;
};

struct Paquet {
    int taille;
    Carte carte[40];
};

void initPaquet (Paquet &paquet) {
    paquet.taille = NB_CARTES;
    for(int i = 0; i < NB_CARTES/4; i++) {
        for (int j=0; j<4; j++) {
            paquet.carte[4*i + j] = {i+1, Couleur(j)};
        }
    }
}

void affichePaquet(Paquet P){
    Carte c;
    string color;
    for (int i = 0; i < NB_CARTES; i++){
        c = P.carte[i];
        switch(c.couleur){
            case 0 : color = "Pique"; break;
            case 1 : color = "Carreau"; break;
            case 2 : color = "Trefle"; break;
            case 3 : color = "Coeur"; break;
        }
        cout << i  << " " << c.valeur << "  " << color << endl;
    }
}

void melange(){
    int a;
    int b;
    int i = 0;
    while(i < 40){
        a = rand()%40;
        b = rand()%40;
        
        i++;
    }

}

int main() {
    Paquet P;
    initPaquet(P);
    affichePaquet(P);
    return 0;
}