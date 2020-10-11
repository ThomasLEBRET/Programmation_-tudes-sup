#include <iostream>
#include <time.h>
#include <random>

using namespace std;

int parent (int i) { return (i-1)/2; }
int gauche (int i) { return 2*i+1; }
int droite (int i) { return 2*i+2; }

void afficher_tas (int tab[], int n) {
  for (int i = 0; i < n; i++) cout << tab[i] << "\t";
  cout << endl;
}

void echanger (int tab[], int a, int b) {
  int temp = tab[a];
  tab[a] = tab[b];
  tab[b] = temp;
}

int max (int tab[], int a, int b, int c) {
  if (b > a || b >= c) return 0;
  if(c <= a) {
    if (tab[b] >= tab[c]) return b;
    else return c;
  }
  else return a;
}

void tamiser (int tab[], int deb, int fin) {
  int parent = deb;
  int fils = gauche(parent);
  int max = parent;
  if(fils < fin && tab[fils] > tab[max]) max = fils;
  if(fils + 1 < fin && tab[fils+1] > tab[max]) max = fils + 1;
  if(max != parent) {
    echanger(tab,max,parent);
    tamiser(tab,max,fin);
  }
}

void tamiser_prof (int tab[], int n, int r) { /* Fonction vu en amphi, ne fonctionne pas avec mon code actuel */
  if(gauche(r) >= n && droite(r) >= n) return;
  int x = 0;
  x = max (tab, tab[r], tab[gauche(r)], tab[droite(r)]);
  if(x == tab[r]) return;
  if(x == tab[gauche(r)]) {
    echanger(tab, r, gauche(r));
    tamiser(tab, n, gauche(r));
  }
  if(x == tab[droite(r)]) {
    echanger(tab, r, droite(r));
    tamiser(tab, n, droite(r));
  }
}

void tamiser_iteratif (int tab[], int size) { /* Ne fonctionne pas avec mon code mais donne la même chose que celle du prof */
  int parent = 1;
  int fils = 2*parent;
  bool fin = false;
  while(fils < size && !fin) {
    if(fils < size && tab[fils+1] < tab[fils]) fils++;
    if(tab[parent] < tab[fils]) {
      parent = fils;
      fils = 2*parent;
    }
    else fin = true;
  }
}

void creer_tas (int tab[], int size) {
  for(int i = size / 2; i >= 0; i--) tamiser(tab,i,size);
}

void tri_par_tas (int tab[], int size) {
  if (size <= 1) return;
  creer_tas(tab,size);
  for (int j = size - 1; j >= 0; j--) {
    echanger(tab,0,j);
    tamiser(tab,0,j);
  }
}

int main() {
  srand(time(NULL));
  int n = rand() % 50- 2;
  int tab[n];
  for (int i = 0; i < n; i++) tab[i] = rand() % 50 - 2;
  cout << "Tableau avant tri: " << endl;
  afficher_tas(tab,n);
  tri_par_tas(tab,n);
  cout << endl << "Tableau apres tri: " << endl;
  afficher_tas(tab,n);
  return 0;
}
