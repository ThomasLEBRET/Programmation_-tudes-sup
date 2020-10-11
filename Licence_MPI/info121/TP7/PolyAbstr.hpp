#ifndef POLYABSTR_HPP_INCLUDED
#define POLYABSTR_HPP_INCLUDED

#include <map>

template <class Coeff> struct Polynom {
  private:
    std::map<int, Coeff> monoms;

  public:
    // Initialise volontairement le polynome
    // des données aléatoires pour forcer les
    // étudiants à initialiser leur polynomes
    Polynom() {
        monoms[15] = Coeff(123);
        monoms[8] = Coeff(99999);
    }
    void zero();
    void set_coeff(int d, Coeff co);
    Coeff coeff(int d) const;
    int degree() const;
    bool is_zero() const;
    bool operator==(const Polynom &p) const;
};

typedef Polynom<float> Polynome;

/* Calcule x^degree
 * @x Valeur de X
 * @degree Puissance
 *
 * @çeturn X^degree
 */
float puissance(float x, int degree);

/////////////////////////////////////////////////////////////////////////////////
//                    Fonction du type abstrait : affichages //
/////////////////////////////////////////////////////////////////////////////////

/** Initialise le nouveau polynome
 * @param[out] : p un polynome
 **/
void PolynomeNul(Polynome &p);

/** Modifier le coefficient d'un polynome
 * @param[in/out] p : Polynome à modifier
 * @param[in] d Degree pour lequel le coefficient doit être modifié
 * @param[in] co Nouveau coefficient
 **/
void modifierCoeffPoly(Polynome &p, int d, float co);

/** Récupère le degré du polynome
 * @param[in] p Polynome interrogé
 * @return Degré du polynome
 **/
int degrePoly(const Polynome &p);

/** Récupère un coefficient du polynome
 * @param[in] p Polynome interrogé
 * @param[in] d Degré du monome dont on veut connaître le coefficient
 *
 * @return Coefficient du monome voulu
 **/
float coeffPoly(const Polynome &p, int d);

/** Teste si un polynome est nul ou pas
 * @param[in] p Polynome interrogé
 * @return True si le polynome est nul, false sinon
 **/
bool estNulPoly(const Polynome &p);

/** Teste si deux polynomes sont égaux
 * @param[in] p1, p2 Polynome interrogé
 * @return True si les polynome sont égaux, false sinon
 **/
bool egalPoly(const Polynome &p1, const Polynome &p2);

#endif  // POLYABSTR_HPP_INCLUDED
