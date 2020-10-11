#include <cstdlib>

#include "PolyAbstr.hpp"
#include <iostream>

#include <chrono>

/////////////////////////////////////////////////////////////////////////////////
//                   Utilisation du type abstrait : affichages                 //
/////////////////////////////////////////////////////////////////////////////////

using namespace std;

/* affiche le monome d'un polynome
 * @param[in] i Degré du monome
 * @param[in] co Coefficient du monome
 * @param[in] premier Est-ce le premier monome affiché pour un polynome ?
 */
void afficheMonome(int i, float co, bool premier) {
  if (co != 0) {
    // affiche le signe
    if (co > 0 && not premier) {
      cout << " + ";
    }
    if (co < 0) {
      cout << " - ";
      co = -co;
    }
    // affiche le coefficient
    if ((co != 1) || (i == 0))
      cout << co;
    // affiche la puissance de X
    if (i > 1) cout << "X^" << i;
    else if (i == 1) cout << "X";
  }
}


/* Affiche un polynome dans la console
 * @param[in] p Polynome à afficher
 */

 void affichePoly(Polynome p) {
 for (int i = 0; i <= MAX_DEGRE; i++)
 afficheMonome(i, coeffPoly(p, i), false);
 cout << endl;
 }

 /*
void affichePoly(Polynome p) {
  int d, i;
  if (estNulPoly(p)) cout << 0 << endl;
  else {
    d = degrePoly(p);
    afficheMonome(d, coeffPoly(p, d), true);
    for (i = d-1; i >= 0; i--)
      afficheMonome(i, coeffPoly(p, i), false);
    cout << endl;
  }
}
*/

/////////////////////////////////////////////////////////////////////////////////
//             Utilisation du type abstrait : fonction vue en cours            //
/////////////////////////////////////////////////////////////////////////////////

/* Multiple un polynome par une constante
 * @param[in/out] p Polynome à multiplier
 * @param[in] la Constante
 */
void multPolyConst(Polynome &p, float a) {
  int d, i;
  float c;

  if (a == 0)
    PolynomeNul(p);
  else {
    d = degrePoly(p);
    for (i=0; i<=d; i++) {
      c = coeffPoly(p, i);
      modifierCoeffPoly(p, i, c*a);
    }
  }
}

/* Dérive un polynome
 * @param[in] p Polynome à dériver
 * @param[out] res le résultat de la dérivation
 */
void deriveePoly(Polynome p, Polynome &res) {
  int d, i;
  d = degrePoly(p);
  PolynomeNul(res);
  for (i=0; i<d; i++) {
    modifierCoeffPoly(res, i, (i+1)*coeffPoly(p, i+1));
  }
}

/////////////////////////////////////////////////////////////////////////////////
//              Utilisation du type abstrait : fonctions à écrire              //
/////////////////////////////////////////////////////////////////////////////////

/* Calcule x^degree
 * @x Valeur de X
 * @degree Puissance
 *
 * @çeturn X^degree
 */
float puissance(float x, int degree) {
    if (degree < 0) {
      degree = -degree;
      x = 1/x;
    }

    if (degree == 0)
        return 1.;

    float res{x};
    for (int i = 1; i < degree; i++)
        res *= x;
    return res;
}

void ajoutePoly(Polynome &p, Polynome q) {
  int d, i;
  d = degrePoly(q);
  for (i=0; i<=d; i++) {
    modifierCoeffPoly(p, i, coeffPoly(p, i)+coeffPoly(q, i));
  }
}

void sommePoly(Polynome p, Polynome q, Polynome &res) {
  res = p;
  ajoutePoly(q, res);
}

float evalPoly(Polynome p, float x) {
  float res = 0.;
  int d = degrePoly(p);
  for (int i=0; i<=d; i++)
    res += coeffPoly(p, i) * puissance(x, i);
  return res;
}

float evalHornerPoly(Polynome p, float x) {
  float res = 0;
  int d = degrePoly(p);
  for (int i=d; i>=0; i--)
    res = res*x + coeffPoly(p, i);
  return res;
}

void polynomeCoeffEgaux(Polynome &p, int degree, float coeff) {
  PolynomeNul(p);
  for (int i=0; i<=degree; i++)
    modifierCoeffPoly(p, i, coeff);
}

void produitPolyXn(Polynome p, int n, Polynome &res) {
  int d, i;
  d = degrePoly(p);
  PolynomeNul(res);
  for (i=0; i<=d; i++) {
    modifierCoeffPoly(res, i+n, coeffPoly(p, i));
  }
}

void produitPoly(Polynome p, Polynome q, Polynome &res) {
  int d, i;
  Polynome tmp;
  d = degrePoly(q);
  PolynomeNul(res);
  for (i=0; i<=d; i++) {
    produitPolyXn(p, i, tmp);
    multPolyConst(tmp, coeffPoly(q, i));
    ajoutePoly(res, tmp);
  }
}

void puissancePoly(Polynome p, int n, Polynome &res) {
  Polynome tmp;
  int i;
  PolynomeNul(res);
  modifierCoeffPoly(res, 0, 1.);
  for (i=0; i<n; i++) {
    tmp = res;
    produitPoly(tmp, p, res);
  }
}

/////////////////////////////////////////////////////////////////////////////////
//                                    Autres                                   //
/////////////////////////////////////////////////////////////////////////////////

/** Infrastructure minimale de test **/
#define ASSERT(test) if (!(test)) cout << "Test failed in file " << __FILE__ \
                                       << " line " << __LINE__ << ": " #test << endl


/*
* Retourne le temps machine en millisecondes (include chrono nécessaire)
*/
long GetTime()
{
    auto t = chrono::high_resolution_clock::now();
    return chrono::time_point_cast<chrono::milliseconds>(t).time_since_epoch().count();
}

int main() {
  Polynome p, q;

  PolynomeNul(p);
  PolynomeNul(q);
  egalPoly(p,q);

modifierCoeffPoly(p, 5,  4.);
modifierCoeffPoly(p, 2, -5.);
modifierCoeffPoly(p, 1,  1.);
modifierCoeffPoly(p, 0, -1.);

cout << "Le polynome p est : ";
affichePoly(p);

ASSERT( egalPoly(p, p) );

cout << "Le polynome 3*p est : ";
q = p;
multPolyConst(q, 3.);
affichePoly(q);
ASSERT( not egalPoly(p, q) );

cout << "La derivee de p est : ";
deriveePoly(p, q);
affichePoly(q);

//Q2
PolynomeNul(p);
modifierCoeffPoly(p, 4,  1.);
modifierCoeffPoly(p, 2, 2.);
modifierCoeffPoly(p, 0,  -5.);
cout << "X^4 + 2 X^2 - 5 evalue en 2 : " << evalPoly(p, 2.) << endl; //Doit afficher 19

//Q2 a
long deb, fin;

polynomeCoeffEgaux(p, 10000, 1.0001);
cout << "Basic : " << endl;
deb = GetTime();
cout << evalPoly(p, 1.0001) << endl;
fin = GetTime();
cout << "Time = " << (fin-deb)/1.e3 << " s" << endl;

cout << "Horner : " << endl;
deb = GetTime();
cout << evalHornerPoly(p, 1.0001) << endl;
fin = GetTime();
cout << "Time = " << (fin-deb)/1.e3 << " s " << endl;

//Q2 b
PolynomeNul(q);
modifierCoeffPoly(q, 10, 1);
modifierCoeffPoly(q, 9, -99);
cout << "evalPoly       q(100) = " << evalPoly(q, 100) << endl;
cout << "evalHornerPoly q(100) = " << evalHornerPoly(q, 100) << endl;

//Q4
PolynomeNul(p);
modifierCoeffPoly(p, 5,  4.);
modifierCoeffPoly(p, 2, -5.);
modifierCoeffPoly(p, 1,  1.);
modifierCoeffPoly(p, 0,  -1.);
cout << "Polynome p : ";affichePoly(p);

Polynome r;
cout << "Multiplication par X^2 : ";
produitPolyXn(p, 2, r);
affichePoly(r);

// Q5

PolynomeNul(q);
modifierCoeffPoly(q, 3,  1.);
modifierCoeffPoly(q, 1, 2.);
modifierCoeffPoly(q, 0,  -1.);

cout << "produit avec q : ";
produitPoly(p, q, r);
affichePoly(r);

//Q6 : Triangle de Pascal
PolynomeNul(p);
modifierCoeffPoly(p, 1, 1.);
modifierCoeffPoly(p, 0, 1.);
affichePoly(p);

produitPoly(p, p, r);
affichePoly(r);

for (int i=0; i<10; i++) {
  puissancePoly(p, i, r);
  affichePoly(r);
}


}
