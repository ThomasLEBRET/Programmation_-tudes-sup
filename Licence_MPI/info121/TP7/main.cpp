#include "PolyAbstr.hpp"
#include <iostream>

/** Infrastructure minimale de test **/
#define ASSERT(test)                                                           \
    if (!(test))                                                               \
    cout << "Test failed in file " << __FILE__ << " line " << __LINE__         \
         << ": " #test << endl

/////////////////////////////////////////////////////////////////////////////////
//                   Utilisation du type abstrait : affichages //
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
        if (i > 1)
            cout << "X^" << i;
        else if (i == 1)
            cout << "X";
    }
}

/* Affiche un polynome dans la console
 * @param[in] p Polynome à afficher
 */
void affichePoly(Polynome p) {
    int d, i;
    if (estNulPoly(p))
        cout << 0 << endl;
    else {
        d = degrePoly(p);
        afficheMonome(d, coeffPoly(p, d), true);
        for (i = d - 1; i >= 0; i--)
            afficheMonome(i, coeffPoly(p, i), false);
        cout << endl;
    }
}

/////////////////////////////////////////////////////////////////////////////////
//             Utilisation du type abstrait : fonction vue en cours //
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
        for (i = 0; i <= d; i++) {
            c = coeffPoly(p, i);
            modifierCoeffPoly(p, i, c * a);
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
    for (i = 0; i < d; i++) {
        modifierCoeffPoly(res, i, (i + 1) * coeffPoly(p, i + 1));
    }
}

/////////////////////////////////////////////////////////////////////////////////
//               Utilisation du type abstrait : fonction à écrire //
/////////////////////////////////////////////////////////////////////////////////

void produitPoly(Polynome p, Polynome q, Polynome &res);
void puissancePoly(Polynome p, int n, Polynome &res);

void ajoutePoly(Polynome &p, Polynome q) {
  int degMax = 0;
  float c = 0;
  if(degrePoly(p)>degrePoly(q)) degMax = degrePoly(p);
  else degMax = degrePoly(q);

  for(int i = degMax; i >= 0; i--) {
      c = coeffPoly(p,i)+coeffPoly(q,i);
      modifierCoeffPoly(p,i,c);
  }
}

void polynomeCoeffEgaux(Polynome &p, int degree, float coeff) {
  int i;
  for(i = degree; i >= 0; i--){
    modifierCoeffPoly(p,i,coeff);
  }
}

float evalPoly(Polynome p, float x) {
  float s = 0;
  for (int i = 0; i <= degrePoly(p); i++){
  s += coeffPoly(p,i)*puissance(x,i);
  }
  return s;
}

float evalHornerPoly(Polynome p, float x) {
  float s = 0;
  float c = coeffPoly(p, degrePoly(p))*x;
  for (int i = degrePoly(p)-1; i > 0; i--) {
    c += coeffPoly(p, i);
    s = c*x;
    c=s;
  }
  return s+coeffPoly(p,0);
}

void produitPolyXn(Polynome p, int n, Polynome &res) {
  float c = 0;
  PolynomeNul(res);
  for (int i = degrePoly(p); i >= 0; i--) {
    c = coeffPoly(p,i);
    modifierCoeffPoly(res, i+n, c);
  }
}

int main() {

  /* modifierCoeffPoly(p, 5, 4.);
  modifierCoeffPoly(p, 2, -5.);
  modifierCoeffPoly(p, 1, 1.);
  modifierCoeffPoly(p, 0, -1.); */

    Polynome p, q;
    // TESTS
    PolynomeNul(p);

    polynomeCoeffEgaux(p,10000,1.0001);
    cout << "Pour x = 1.0001 : " <<  evalPoly(p,1.0001) << endl;
    PolynomeNul(p); //petite différence de calcul
                    // de quelques dizaines pour de grands exposants mais fonctionne parfaitement pour de plus petits
    polynomeCoeffEgaux(p,10000,1.0001);
    cout << "Pour x = 1.0001, evalHornerPoly : " <<  evalHornerPoly(p,1.0001) << endl;

    PolynomeNul(p);
    PolynomeNul(q);
    polynomeCoeffEgaux(p,2,3);
    polynomeCoeffEgaux(q,5,6);
    cout << "Ajoute polynomes : ";
    ajoutePoly(p,q);
    affichePoly(p);

    PolynomeNul(p);
    PolynomeNul(q);
    polynomeCoeffEgaux(p,2,3);
    cout << "Produit polynomes : ";
    produitPolyXn(p,5,q);
    affichePoly(q);

    PolynomeNul(p);
    polynomeCoeffEgaux(p,3,2);
    cout << "Le polynome p est : ";
    affichePoly(p);

    ASSERT(egalPoly(p, p));

    cout << "Le polynome 3*p est : ";
    q = p;
    multPolyConst(q, 3.);
    affichePoly(q);

    cout << "La derivee de p est : ";
    deriveePoly(p, q);
    affichePoly(q);

    ASSERT(not egalPoly(p, q));

    // Q2
    PolynomeNul(p);
    modifierCoeffPoly(p, 4, 1.);
    modifierCoeffPoly(p, 2, 2.);
    modifierCoeffPoly(p, 0, -5.);
    cout << "X^4 + 2 X^2 - 5 evalue en 2 : " << evalPoly(p, 2.) << endl;
    // //Doit afficher 19

    return 0;
}
