#include <iostream>
#include <cstdlib>

using namespace std;

struct branche {
  int donnee;
  branche *gauche;
  branche *droite;
  int chercher_profondeur;
};

struct arbre {
  branche *racine;
};

/* Cree un noeud et 2 sous-branches gauche et droite */
branche *nouvelle_branche(int val) {
  branche *b = (branche*) malloc(sizeof(branche));
  b -> donnee = val;
  b -> droite = NULL;
  b -> gauche = NULL;
  return b;
}

/* Ajoute une valeur au systeme de branche de maniere reccursive */
void ajoute_valeur_reccursive(branche *b, int val) {
  if(b == NULL) return;
  if(val >= b -> donnee && b -> droite != NULL)
  ajoute_valeur_reccursive(b -> droite, val);
  else if(val < b -> donnee && b -> gauche != NULL)
  ajoute_valeur_reccursive(b -> gauche, val);

  if(b -> gauche == NULL || b -> droite == NULL) {
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
  if(a == NULL) return;
  branche *b = a -> racine;
  while(b -> gauche != NULL || b -> droite != NULL) {
    if (val >= b -> donnee) b = b -> droite;
    else b = b -> gauche;
  }
  if (val >= b -> donnee)
    b -> droite = nouvelle_branche(val);
   else
    b -> gauche = nouvelle_branche(val);
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
    if(b   == NULL) return 0;
	while (b -> gauche != NULL) b = b -> gauche;
	return b -> donnee;
}

int main() {
  arbre *a = (arbre*) malloc(sizeof(arbre));
  a -> racine = nouvelle_branche(10);
  a -> racine -> gauche = nouvelle_branche(9);
  a -> racine -> droite = nouvelle_branche(30);
  ajoute_valeur_iterative(a,7);
  ajoute_valeur_iterative(a,18);
  ajoute_valeur(a,6);
  cout << "Profondeur de l'arbre reccursive : " << profondeur_arbre(a) << endl;
  cout << "Profondeur de l'arbre iterative : " << profondeur_iterative(a) << endl;
  cout << "Valeur minimale de l'arbre : " << cherche_minimum(a) << endl;
  afficher_arbre(a);
  return 0;
}
