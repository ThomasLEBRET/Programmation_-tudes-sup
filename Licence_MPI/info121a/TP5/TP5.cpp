#include <iostream>
#include <cstdlib>
#include <time.h>
#include <random>

using namespace std;

struct branche {
  int donnee;
  branche *gauche;
  branche *droite;
  int chercher_profondeur;
};

struct arbre {
  branche *racine;
  int nbVal;
};

/* Cree un noeud et 2 sous-branches gauche et droite */
branche *nouvelle_branche(int val) {
  branche *b = (branche*) malloc(sizeof(branche));
  b -> donnee = val;
  b -> droite = NULL;
  b -> gauche = NULL;
  b -> chercher_profondeur = 0;
  return b;
}

/* Ajoute une valeur au systeme de branche de maniere reccursive */
void ajoute_valeur_reccursive(branche *b, int val) {
  if(val >= b -> donnee && b -> droite != NULL)
  ajoute_valeur_reccursive(b -> droite, val);
  else if(val < b -> donnee && b -> gauche != NULL)
  ajoute_valeur_reccursive(b -> gauche, val);
  else if(b -> gauche == NULL || b -> droite == NULL) {
    if(val >= b -> donnee) b -> droite = nouvelle_branche(val);
    else b -> gauche = nouvelle_branche(val);
  }
}

/* Converti notre systeme de branche en arbre pour le main */
void ajoute_valeur(arbre *a, int val) {
  ajoute_valeur_reccursive(a -> racine, val);
}

/* Ajoute une valeur de maniere iterative a notre arbre */
void ajoute_valeur_iterative(arbre *a, int val) {
  branche *b = a -> racine;
  if (a -> racine == NULL) { /* Si arbre vide, on quitte la fonction */
    a -> racine = nouvelle_branche(val);
    return;
  }
  while(b != NULL) { /* Tant que l'arbre est non-vide */
  if (val < b -> donnee) { /* Si valeur en dessous du noeud */
    if (b -> gauche == NULL){ /* Si noeud à gauche existe pas */
      b -> gauche = nouvelle_branche(val); /* On créé une nouvelle branche */
      break; /* Et on quitte la condition */
    }
    else b = b -> gauche; /* Si il existe une valeur à gauche du noeud, on va à gauche */
  }
  else { /* Si la valeur est supérieure à la valeur du noeud actuel */
    if (b -> droite == NULL) { /* Si le noeud à droite exite pas */
      b -> droite = nouvelle_branche(val); /* On créé une nouvelle branche */
      break; /* Et on quitte la condition */
    }
    else b = b -> droite; /* Si le noeud a droite existe et possède une valeur, on va à droite */
  }
}
}


/* Affiche reccursivement le systeme de branches cree */
void affiche_reccursif(branche *b, int espacement_noeud) {
  if(b == NULL) return;
  for (int i = 0; i < espacement_noeud; i++) {
    if (i < espacement_noeud - 1) cout << "\t";
    else cout << "\t" << "\u27a3 ";
  }
  cout << b -> donnee << endl;
  if (b -> droite != NULL) {
    affiche_reccursif(b -> droite, espacement_noeud+1);
  }

  if (b -> gauche != NULL) {
    affiche_reccursif(b -> gauche, espacement_noeud+1);
  }
}

void affiche_reccursif_lineaire(branche *b) {
  if(b == NULL) {
    cout << "_";
  }
  else {
    cout << " { ";
    affiche_reccursif_lineaire(b -> gauche);
    cout << " < " << b -> donnee << " > ";
    affiche_reccursif_lineaire(b -> droite);
    cout << " } ";
  }
}

/* Converti le systeme de branches en arbre pour l'affichage dans le main */
void afficher_arbre(arbre *a) {
  branche *b = a -> racine;
  cout << "Affichage le plus lisible : " << endl << endl;
  affiche_reccursif(b,0);
  cout << endl << "Affichage en une ligne : " << endl << endl;
  affiche_reccursif_lineaire(b);
  cout << endl << endl;
}

/* Calcul la profondeur d un systeme de branches reccursivement */
int profondeur_reccursive(branche *b) {
  if(b == NULL) return 0;
  if (b -> gauche != NULL && b -> droite != NULL)
  return 1 + max(profondeur_reccursive(b -> gauche), profondeur_reccursive(b -> droite));

  else if (b  -> droite != NULL)
  return 1 + profondeur_reccursive(b -> droite);

  else if (b -> gauche != NULL)
  return 1 + profondeur_reccursive( b -> gauche);

  else return 1;
}


/* Converti notre systeme de branches en arbre */
int profondeur_arbre(arbre *a) {
  return profondeur_reccursive(a -> racine);
}

/* Cherche la profondeur de maniere iterative */
int profondeur_iterative(arbre *a) {
  branche *b = a -> racine;
  int maxVal = 0;
  int cpt = 0;
  if (b == NULL){
    return 0;
  }
  /* Tant qu il existe une valeur non nulle dans l arbre
  et que on a pas chercher dans toutes les branches de l arbre */
  while(b != NULL && not(b -> chercher_profondeur)) {
    /* Si la branche de gauche n a pas ete cherchee et que il existe une valeur non nulle*/
    if (b -> gauche != NULL && not(b -> gauche -> chercher_profondeur)) {
      cpt = cpt + 1; /* On incremente */
      b = b -> gauche; /* On repart a gauche */
    }
    else if (b -> droite != NULL && not(b -> chercher_profondeur)) { /* Pareil a droite */
      cpt = cpt +1;
      b = b -> droite;
    }
    else { /* Sinon ca veut dire que on a visite une branche en entier */
      cpt = cpt + 1; /* On rajoute 1 car dans la formule de calcul d arbre binaire */
      if (cpt > maxVal) { /* Si la valeur max est inferieur au compteur */
        maxVal = cpt; /* On remet la valeur max au meme montant que celui du compteur */
      }
      /* Fin de boucle, on remet le compteur a 0 et on a cherche une serie de branche */
      cpt = 0;
      b -> chercher_profondeur = 1;
      b = a -> racine;
    }
  }
  return maxVal;
}

/* Cherche la valeur minimale de l arbre
(se situant tout a gauche du dernier noeud du systeme de branche) */
int cherche_minimum(arbre *a) {
  branche *b = a -> racine;
  while (b -> gauche != NULL) b = b -> gauche;
  return b -> donnee;
}

/* _____TP5 : Fonctions_____ */

int contiens_reccursif(branche *b, int val) {
  if (b -> donnee != val) {
    if (b -> gauche != NULL && b -> donnee > val)
    return contiens_reccursif(b -> gauche, val);
    else if (b -> droite != NULL && b -> donnee <= val)
    return contiens_reccursif(b -> droite, val);
    else {
      cout << "La valeur : " << val << " n'existe pas !" << endl;
      return 0;
    }
  }
  else {
    cout << "La valeur : " << val << " existe bien !" << endl;
    return 1;
  }
}

int contiens(arbre *a, int val) {
  return contiens_reccursif(a -> racine, val);
}

/* free() : libère la mémoire sans destruction de valeur
delete : supprime la valeur et est utilisée pour la gestion de mémoire dans un programme
on prendra delete pour supprimer une valeur du coup
*/

branche* supprimer_reccursif(branche *b, int val) {
  if (b == NULL) return NULL;
  else if (b -> donnee < val) b -> droite = supprimer_reccursif(b -> droite, val);
  else if (b -> donnee > val) b -> gauche = supprimer_reccursif(b -> gauche, val);
  else {

    /* Cas 1 : 1 enfant de chaque côté  */
    if (b -> gauche != NULL && b -> droite != NULL) {
      while(b -> droite -> gauche != NULL) /* On cherche le minimum a droite */
      b -> droite = b -> droite -> gauche;
      branche *tmp = b -> droite; /* On créé un temporaire qui stocke la valeur b -> droite */
      b -> donnee = tmp -> donnee;
      b -> droite = supprimer_reccursif(b -> droite, tmp -> donnee); /* On supprime la valeur */
    }

    /* Cas 2 : pas d'enfants  */
    else if( b -> gauche == NULL && b -> droite == NULL) {
      delete b;
      b = NULL;
    }

    /* Cas 3 : 1 enfant gauche */
    else if (b -> droite == NULL) {
      branche *tmp = b; /* On stocke b dans un temporaire */
      b = b -> gauche;
      delete tmp;
    }

    /* Cas 4 : 1 enfant droite */
    else if (b -> gauche == NULL) {
      branche *tmp = b;
      b = b -> droite;
      delete tmp;
    }
  }
  return b;
}

void supprimer(arbre *a, int val){
  if (contiens(a,val) == 1){
    a->racine = supprimer_reccursif(a->racine,val);
    a->nbVal--;
  }
}

void affiche_tableau(int tab[], int n) {
  for (int i = 0; i < n; i++) {
    cout << tab[i] << " ";
  }
  cout << endl;
}

void ajouter_arbre(arbre *a, int val){
  branche *n = nouvelle_branche(val);
  if ( a->racine == NULL){
    a -> racine = n;
  }
  else {
    branche *e = a->racine;
    while(true) {
      if (val < e->donnee) {
        if (e->gauche == NULL) {
          e->gauche = n;
          break;
        }
        else e=e->gauche;
      }
      else {
        if (e -> droite == NULL){
          e -> droite = n;
          break;
        }
        else e = e -> droite;
      }
    }
  }
  a -> nbVal++;
}

arbre *nouvel_arbre() {
  arbre *a = (arbre*) malloc(sizeof(arbre));
  a -> nbVal = 0;
  return a;
}

void tri(int tab[], int n){
  int add;
  arbre *a = (arbre*) malloc (sizeof(arbre));
  a -> racine = nouvelle_branche(tab[0]);
  for(int i = 0; i < n; i++){
    ajouter_arbre(a,tab[i]);
  }
  for (int i = 0; i < n; i++) 	{
    add = cherche_minimum(a);
    supprimer(a,add);
    tab[i] = add;
  }
}

int mediane(arbre *a){
	int taille = a->nbVal;
	int tab[taille];
	for(int i = 0;i<taille;i++){
		tab[i] = cherche_minimum(a);
		supprimer(a,cherche_minimum(a));
	}
	return tab[int(taille)/2];
}


int main() {
  srand(time(NULL));
  int taille = rand() % 50 - 2 ;
  int tab[taille];
  for (int i = 0; i < taille; i++)
  tab[i] = rand() % 50 - 2;
  cout << endl << "Taille tableau avant tri: " << endl;
  affiche_tableau(tab, taille);
  tri(tab,taille);
  cout << endl << "Taille tableau apres tri: " << endl;
  affiche_tableau(tab, taille);
  arbre *a = (arbre*) malloc(sizeof(arbre));
  ajouter_arbre(a,rand()% 50 - 2);
  mediane(a);
  cout << "Voici la mediane de l arbre : " << endl;
  return 0;
}
