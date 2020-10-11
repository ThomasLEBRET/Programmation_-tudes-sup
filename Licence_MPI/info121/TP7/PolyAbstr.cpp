#include <cmath>
#include <cstdlib>
#include <iostream>

#include "PolyAbstr.hpp"

using namespace std;

template <typename Coeff> void Polynom<Coeff>::zero() { monoms.clear(); };

template <typename Coeff>
void Polynom<Coeff>::set_coeff(int degree, Coeff coeff) {
    if (degree >= 0) {
        if (coeff != 0)
            monoms[degree] = coeff;
        else
            monoms.erase(degree);
    } else {
        cerr << "Mauvais degré " << degree << " set_coeff impossible !" << endl;
    }
}

template <typename Coeff> int Polynom<Coeff>::degree() const {
    int res{-1};

    for (const auto elem : monoms)
        res = max(res, elem.first);

    return res;
}

template <typename Coeff> Coeff Polynom<Coeff>::coeff(int d) const {
    double degree{0.};
    auto it = monoms.find(d);
    if (it != monoms.end())
        degree = it->second;

    return degree;
}

template <typename Coeff> bool Polynom<Coeff>::is_zero() const {
    return monoms.empty();
};

template <typename Coeff>
bool Polynom<Coeff>::operator==(const Polynom<Coeff> &p) const {
    return monoms == p.monoms;
};

float puissance(float x, int degree) {
    if (degree < 0)
        throw runtime_error{"Impossible de calculer une puissance négative."};
    if (degree == 0)
        return 1.;

    float res{x};
    for (int i = 1; i < degree; i++)
        res *= x;
    return res;
}

/////////////////////////////////////////////////////////////////////////////////
//   fonctions wrapper pour que les étudiants n'ai pas à toucher de l'objet: //
/////////////////////////////////////////////////////////////////////////////////

typedef Polynom<float> Polynome;

void PolynomeNul(Polynome &p) { p.zero(); }
void modifierCoeffPoly(Polynome &p, int d, float co) { p.set_coeff(d, co); }
int degrePoly(const Polynome &p) { return p.degree(); }
float coeffPoly(const Polynome &p, int d) { return p.coeff(d); }
bool estNulPoly(const Polynome &p) { return p.is_zero(); }
bool egalPoly(const Polynome &p1, const Polynome &p2) { return p1 == p2; }
