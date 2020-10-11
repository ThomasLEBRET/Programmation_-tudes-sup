#include <iostream>
#include <vector>

using namespace std;


/** Puissance d'un nombre réel
 *  @param n un entier positif
 *  @param a un nombre réel
 *  @return a^n
 **/
double power(double a, unsigned int n) {
   double res = 0.;
   for (unsigned int i = 0; i<n; i++)
     res = res*a;
   return res;
}

/** Calcule la valeur d'un polynôme en un nombre réel
 *  @param pol un vecteur qui contient les coefficients du polynôme
 *  @param x un nombre réel
 *  @return pol(x)
 **/
double evalpoly(vector<double> pol, double x) {
   double res = 0;
   for (unsigned int i = 1; i <= pol.size(); i++)
     res = res + pol[i]*power(x, i);
   return res;
}

int main() {
   vector<double> pol = {1.5, 2.5, 2.5, 4.0};
   vector<double> vals = {0, 1, 1.5, 2};
   for (unsigned int i = 0; i < vals.size(); i++)
     cout << "P(" << vals[i] << ") = " << evalpoly(pol, vals[i]) << endl;
   return 0;
}

