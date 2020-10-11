#include<iostream>
#include<cstdlib>
#include <iomanip>
#include <cmath>

using namespace std;

const float e = 1e-6;

#define ASSERT(test) if (!(test)) cout << "Test failed in file " << __FILE__ \
                                       << " line " << __LINE__ << ": " #test << endl

/* vérifie que 2 nombres sont égaux avec une précision de 10^⁻6
  @param : 2 nombres float x et y 
  @ return : un booléen true si x vaut y avec une précision de 10^-6, false sinon
*/

bool presqueEgal(float x, float y){

if( (abs(x-y) <= e*abs(x)) && (abs(x-y) <= e*abs(y)) ) {
	return true;
}
return false;
}

void testPresqueEgal() {

	ASSERT(presqueEgal(3,4) == false);
	ASSERT(presqueEgal(1, 1+e/2) == true);
	ASSERT(presqueEgal(1, 1) == true);
	ASSERT(presqueEgal(1+1, 2) == true);
	ASSERT(presqueEgal(0, 0) == true);
	ASSERT(presqueEgal(1, 1+2*e) == false);
	ASSERT(presqueEgal(0, 1) == false);
}

float racine (float a){

float un  = a*1.0;
float un1;

if(a>=0){
	do{

		un1 = ((un + (a/un)) /2);
		un = un1;

	}while(not presqueEgal(un*un, a));
}
return un;
}

void testRacine() {
	ASSERT(racine(1) == 1);
	ASSERT(presqueEgal(1.4142135, racine(2)));
	ASSERT(racine(4) == 2);
}

float racineNieme(float a, float n) {
	float uk = a*1.0;
	float uk1 = 0;

	do {

		uk1 = (1/n)* ( (n-1)*uk + (a/pow(uk, n-1)) );
		uk = uk1;

	}while( not presqueEgal(pow(uk, n), a));

	return uk;

}

void testRacineNieme() {

ASSERT(presqueEgal(racineNieme(2, 5), 1.1486983));
ASSERT(racineNieme(1, 3) == 1);
ASSERT(racineNieme(4, 2) == 2);

}

int main() {

testPresqueEgal();
testRacine();
testRacineNieme();

float x;
float y;
float a;
int n;
cout << "Entrez 2 nombres flotants" << endl;
cin >> x >> y;
cout << endl <<  "0 : faux et 1 : vrai " << endl << endl << presqueEgal(x,y) << endl;
cout << "Entrez un nombre pour obtenir sa racine carré :" << endl;
cin >> a;
cout << racine(a);
cout << "Racine n-ième : Entrez 1 réel flottant + un rang " << endl;
cin >> a >> n;
cout << endl << racineNieme(a, n) << endl; 
}