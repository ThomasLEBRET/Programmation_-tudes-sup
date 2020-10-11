#include <iostream>
#include <cstdlib>
#include <stdexcept>

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


/*_____________________TP3___________________ */


void tri_insertion(liste *l) {
  int max = 0;
	liste *t = nouveau_liste();
	while(l -> tete != NULL) {
		max = rechercher_max(l);
		supprimer_val(l, max);
		ajouter_tete(t, max);
	}
	l -> tete = t -> tete;
	free(t);
}

int supprimer_max(liste *l) {
  noeud *a = l -> tete;
  noeud *max = a;
  noeud *avant_max = a;

  int maxNbr = a -> donnee;
  if (a == NULL) {
    return -1;
  }
  while(a -> suivant != NULL){
    if(a -> suivant -> donnee > maxNbr){
      max = a -> suivant;
      avant_max = a;
      maxNbr = a -> suivant -> donnee;
    }
    a = a -> suivant;
  }
  if(max != l -> tete) avant_max -> suivant = max -> suivant ;
  else l -> tete = max -> suivant;
  return maxNbr;
}

void tri_insertion_rapide(liste *l) {
  liste *t = nouveau_liste();
  while(l->tete != NULL) {
    int max = supprimer_max(l);
    ajouter_tete(t, max);
  }
  l -> tete = t -> tete;
  free(t);
}

int main() {
  srand(time(NULL));
	liste *l = nouveau_liste();
	int taille = rand()%10;
	for (int i = 0; i < taille; i++) ajouter_tete(l, rand()%100);
	voir_liste(l);
	tri_insertion_rapide(l);
  cout << endl;
	voir_liste(l);
	return 0;
}
