#include<iostream>
#include<string>

using namespace std;

void litpositif(int &resultat, int &i) {
  do {
    cout << "Donner la valeur de l'entier positif : ";
    cin >> resultat;
    i++;
  } while (resultat < 0);
}

int main() {
	int resultat; 
	int i = -1;
  litpositif(resultat, i);
  cout << "La valeur est :" << resultat << endl << "Il y a eu " << i << " erreurs" << endl;
    return 0;
}
