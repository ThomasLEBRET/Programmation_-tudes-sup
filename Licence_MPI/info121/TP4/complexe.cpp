#include<iostream>

using namespace std;

struct Complexe
{
	float r, i;
};

void saisie(double &r, double &i) {
	cout << "Partie réelle : " << endl;
	cin >> r;
	cout << "Partie imaginaire : " << endl;
	cin >> i;
}


void affiche(double r, double i) {
	cout << r << "+" << i << "i" << endl;
}

void somme(double r1, double i1,
	double r2, double i2,
	double &sommer, double &sommei) {
	sommer = r1 + r2;
	sommei = i1 + i2;
}

int main() {
	double r;
	double i;
	saisie(r, i);
	affiche(r, i);
	return 0;
}