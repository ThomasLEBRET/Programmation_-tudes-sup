#include <iostream>
#include <cstdlib>

using namespace std;


struct vecteur { int n,s,*t; };

vecteur *nouveau_vecteur() {
  vecteur *v = (vecteur*)malloc(sizeof(vecteur));
  v -> n = 0;
  v -> s = 1;
  v -> t = (int*)malloc(sizeof(int) * v -> s);
  if (v -> t == NULL) {
    delete v -> t;
    cout << "Erreur : L'allocation du vector s'est mal passée !" << endl;
    exit(1);
  }
  return v;
}

void liberer_vecteur(vecteur *v ) {
  delete v -> t;
  v -> s = 1;
  v -> n = 0;
}

void afficher_vecteur(vecteur *v) {
  for (int i = 0; i < v -> n; i++) cout << v -> t[i] << " ";
  cout << endl;
}

void augmenter_taille(vecteur *v) {
    int *tmp = (int*) realloc (v -> t, v -> s * 2 * sizeof(int));
    if (tmp == NULL) {
      delete(v -> t);
      cout << "Erreur réallocation" << endl;
      exit (1);
    }
    else {
      v -> t = tmp;
      v -> s *=2;
    }
}

void ajouter_en_queue(vecteur *v, int val) {
  if(v -> s > v -> n) v -> t[v -> n] = val;
  else {
    augmenter_taille(v);
    v -> t[v-> n] = val;
  }
  v -> n++;
}

int retirer_en_queue(vecteur *v) {
  if(v -> n == 0) {
    cout << "Le vecteur ne possède pas de valeurs !" << endl;
    exit(1);
  }
  return v -> n--;
}

int taille_vecteur(vecteur *v) {
  return v -> n;
}

int lire_valeur(vecteur *v, int idx, int val) {
  if(v -> n < idx && idx > 0) {
    cout << "Erreur : dépassement mémoire ! " << endl;
    return -1;
  }
  return v -> t[idx];
}

void modifier_valeur(vecteur *v, int idx, int val) {
  if(v -> n > idx) v -> t[idx] = val;
}

void inserer(vecteur *v, int idx, int val) {
  if (idx > v -> n || idx < 0) {
    cout << "Erreur : index incorrect !" << endl;
    exit(1);
  }
  if (v -> s > v -> n){
    for (int i = v -> n; i > idx ; i--) v -> t[i] = v -> t[i-1];
    v -> t[idx] = val;
  }
  v -> n++;
}

void supprimer(vecteur *v, int idx) {
  if(idx < 0 && v -> n < idx) cout << "Erreur : index incorrect ! " << endl;
  for(int i = idx; i < v -> n-1; i++) v -> t[i] = v -> t[i+1];
  v -> t[v -> n] = 0;
  v -> n--;
}

int main() {
  vecteur *v = nouveau_vecteur();
  for(int i = 0; i <= 40; i++) ajouter_en_queue(v, i);
  cout << v -> s << " " << v -> n << endl;
  afficher_vecteur(v);
  cout << "Supprime '40' : " << endl;
  retirer_en_queue(v); // supprime la valeur "40"
  afficher_vecteur(v);
  /*
  cout << "Taille du vecteur augmentée : " << endl << "Avant : " << v -> s << endl;
  augmenter_taille(v); // double la taille du vecteur
  */
  cout << "Après : " << v -> s << endl;
  cout << "Taille du vecteur : " <<  v -> s << " Nombre de valeurs : " << v -> n << endl;
  ajouter_en_queue(v,41); // ajoute la valeur 41
  afficher_vecteur(v);
  cout << "Change la valeur '39 en '50' : " << endl;
  modifier_valeur(v,39,50); // change 39 en 50
  afficher_vecteur(v);
  cout << "Lis la valeur '50' : " << endl;
  cout << lire_valeur(v,39,50) << endl; // affiche 50
  cout << "Supprime '50' : " << endl;
  supprimer(v,39); //supprime le 50
  afficher_vecteur(v);
  cout << "Insère la valeur '60' à gauche de '8' : " << endl;
  inserer(v,8 ,60); //insere à gauche du 8 la valeur 60
  afficher_vecteur(v);
  return 0;
}
