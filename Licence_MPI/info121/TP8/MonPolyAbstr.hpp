#ifndef MONPOLYABSTR_HPP_INCLUDED
#define MONPOLYABSTR_HPP_INCLUDED

const int MAX_DEGRE = 10000;

struct Polynome {
  int degre;
  float coeffs[MAX_DEGRE+1];
};


/////////////////////////////////////////////////////////////////////////////////
//                         Fonctions du type abstrait                          //
/////////////////////////////////////////////////////////////////////////////////

/** Initialise le nouveau polynome
 * @param[out] : p un polynome
 **/
void PolynomeNul(Polynome &p);

/** Teste si deux polynomes sont égaux
 * @param[in] p1, p2 Polynome interrogé
 * @return True si les polynome sont égaux, false sinon
 **/
bool  egalPoly(Polynome p1, Polynome p2);

/** Modifier le coefficient d'un polynome
 * @param[in/out] p : Polynome à modifier
 * @param[in] d Degree pour lequel le coefficient doit être modifié
 * @param[in] co Nouveau coefficient
 **/
void modifierCoeffPoly(Polynome &p, int d, float co);

/** Récupère le degré du polynome
 * @param[in] p Polynome interrogé
 * @return Degré du polynome (-1 si le polynome est nul)
 **/
int   degrePoly(Polynome p);

/** Récupère un coefficient du polynome
 * @param[in] p Polynome interrogé
 * @param[in] d Exposant du monome dont on veut connaître le coefficient
 *
 * @return Coefficient du monome voulu
 **/
float coeffPoly(Polynome p, int d);

/** Teste si un polynome est nul ou pas
 * @param[in] p Polynome interrogé
 * @return True si le polynome est nul, false sinon
 **/
bool  estNulPoly(Polynome p);


// Fonctions de test

void test_PolynomeNul();
void test_modifierCoeffPoly();
void test_degrePoly();
void test_coeffPoly();
void test_estNulPoly();


#endif // MONPOLYABSTR_HPP_INCLUDED
