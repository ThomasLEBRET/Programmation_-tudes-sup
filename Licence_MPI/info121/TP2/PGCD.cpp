#include <iostream>

using namespace std;

int pgcd(int a, int b) {
	while (b != 0) {

		int r = a%b;
		a = b;
		b = r;
	}

	cout << "Le PGCD est : " << a << endl;
	return a;
}

void simpleFrac(int a, int b){
    int k;
    k = pgcd(a,b);
    cout << k << endl;
    a = a/k;
    b = b/k;
    if(b < 0) {
        a = -a;
        b = -b;
        }
        cout << "Fraction simplifiée : " << a << "/" << b << endl;
}

int main()
{
	int a, b;
	cout << "Bienvenu dans le programme de calcul de PGCD !" << endl;
	do{
		cout << "Entrez deux valeurs positives a et b pour réaliser le PGCD de ces nombres:" << endl;
		cin >> a >> b;

	} while( (a <= 0) && (b <= 0) );
	simpleFrac(a,b);
	return 0;
}