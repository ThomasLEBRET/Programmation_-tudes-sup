#include <iostream>
#include <cstdlib>
#include <stdexcept>
#include <random>
#include <time.h>

using namespace std;

struct noeud {
	int donnee;
	noeud *suivant;
};

struct liste {
	int nb;
	noeud *tete;
};


/*_____________________Fonctions TP2___________________*/


liste *nouveau_liste() {
	liste *l = (liste*) malloc (sizeof(liste));
	l -> tete = NULL;
	l -> nb = 0;
	return l;
}

void voir_liste(liste *l) {
	noeud *n = l -> tete;
	while (n != NULL) {
		cout << n -> donnee << " ";
		n = n -> suivant;
	}
	cout << endl;
}

void ajouter_tete(liste *l, int val) {
	noeud *n = (noeud*) malloc (sizeof(noeud));
	n -> donnee = val;
	n -> suivant = l -> tete;
	l -> tete = n;
	l -> nb++;
}

void supprimer_val(liste *l, int val) {
	noeud * actuel = l -> tete;
	if (actuel -> donnee == val) {
		l -> tete = actuel -> suivant;
		free(actuel);
		return;
	}
	noeud *avant = (noeud*) malloc (sizeof(noeud));
	while (actuel != NULL) {
		avant = actuel;
		actuel = actuel -> suivant;
		if (actuel -> donnee == val) {
			avant -> suivant = actuel -> suivant;
			free(actuel);
			break;
		}
	}
}

int rechercher_max(liste *l) {
	noeud *n = l -> tete;
	int max = -2147483648;
	while(n != NULL) {
		if (n -> donnee > max)
			max = n -> donnee;
		  n = n -> suivant;
	}
	return max;
}

void libere_liste(liste *l) {
	noeud *avant = l->tete;
	noeud *actuel = avant -> suivant;
	while (actuel != NULL) {
		free(avant);
		avant = actuel;
		actuel = actuel -> suivant;
	}
	free(l);
}


int main() {
	liste *l = nouveau_liste();
	ajouter_tete(l,4);
	ajouter_tete(l, 3);
	ajouter_tete(l, 2);
	voir_liste(l);
	supprimer_val(l, 2);
	voir_liste(l);
	libere_liste(l);
	return 0;
}
