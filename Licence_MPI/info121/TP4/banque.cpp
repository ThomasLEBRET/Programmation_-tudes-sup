#include <iostream>
using namespace std;

int compte1 = 1000;
int compte2 = 2000;
int compte3 = 1500;
int compte4 = 3000;

void etat_comptes();
void virement(int &compte_orig, int &compte_dest, int somme, int &virement_ok);

void etat_comptes() {
  cout << "Etat des comptes : " << endl;
  cout << "Compte n 1 : " << compte1 << endl;
  cout << "Compte n 2 : " << compte2 << endl;
  cout << "Compte n 3 : " << compte3 << endl;
  cout << "Compte n 4 : " << compte4 << endl;
}

void virement(int &compte_orig, int &compte_dest, int somme, bool &virement_ok) {
 if (somme <= 0 || compte_orig - somme < 0) virement_ok = false;
 else {
   virement_ok = true;
   compte_orig -= somme;
   compte_dest += somme;
 }
}


int main() {
  int v;
  etat_comptes();
  virement(compte1, compte2, 100, v);
  etat_comptes();
  if (v) {
    cout << "Virement effectue" << endl;
  }
  else {
    cout << "Virement impossible" << endl;
  }
  return 0;
}