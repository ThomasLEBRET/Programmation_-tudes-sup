#include <iostream>
#include <cstdlib>
#include <time.h>

using namespace std;

void affiche_tableau(int tab[], int n) {
	for (int i = 0; i < n; i++) {
		cout << tab[i] << " ";
	}
	cout << endl;
}

int chercher_limite(int tab[], int n, int val) {
	for (int i = 0; i < n; i++) {
		if (tab[i] > val)
			return i;
	}
	return n;
}

int rechDicho(int tab[], int min, int max, int val) {
	while (min < max) {
		int mid = (min+max)/2;
		if (tab[mid-1] <= val && tab[mid] >= val)
			return mid;
		if (tab[mid] < val)
			min = mid+1;
		else
			max = mid-1;
	}
	return min;
}

void decaler(int tab[], int n, int idx) {
	for (int i = n; i > idx; i--) {
		tab[i] = tab[i-1];
	}
}

void tri_insertion(int tab[], int n) {
	for (int i = 1; i < n; i++) {
		int nbr = tab[i];
		//int pos = chercher_limite(tab, i, nbr);
		int pos = rechDicho(tab, 0, i, nbr);
		decaler(tab, i, pos);
		tab[pos] = nbr;
	}
}

int main() {
	srand(time(NULL));
	int taille = rand() % 50 + 2;
	int tab[taille];
	for (int i = 0; i < taille; i++)
		tab[i] = rand() % 100;
	cout << "Tableau non trié :\t";
	affiche_tableau(tab, taille);
	tri_insertion(tab, taille);
	cout << "Tableau trié : \t\t";
	affiche_tableau(tab, taille);
	return 0;
}
