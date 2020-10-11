#include<iostream>
#include<cstdlib>

using namespace std;

#define ASSERT(test) if (!(test)) cout << "Test failed in file " << __FILE__ \
                                       << " line " << __LINE__ << ": " #test << endl

/** Calculer le factoriel d'un entier
 *  @param n un entier
 *  @return un entier
 **/
int factoriel(int n) {
    if (n < 0) {
        cerr << "Factoriel argument negatif file " << __FILE__ << " line " << __LINE__ << endl;
        exit(1);
    }
    int res = 1, i;
    for (i = 1 ; i <= n ; i ++) {
        res *= i;
    }
    return res;
}

/** Tester la fonction factorielle
 **/
void testFactoriel() {
    ASSERT(factoriel(0) == 1);
    ASSERT(factoriel(3) == 6);
    ASSERT(factoriel(4) == 24);
    ASSERT(factoriel(6) == 720);
}

/** Calculer le binome de Newton
 *  @param n entier, p entier, n >= p
 *  @return un entier
 **/
int binome(int n, int p) {
    int Nfac = factoriel(n);
    int Pfact = factoriel(p);
    int k = factoriel(n-p);
    return  Nfac / (Pfact * k);
}

void testBinome() {
    // valeur de base
    ASSERT(binome(0, 0) == 1);
    ASSERT(binome(3, 2) == 3);
    ASSERT(binome(4, 2) == 6);
    ASSERT(binome(5, 3) == 10);
    ASSERT(binome(10, 5) == 252);
}

int square(int a) {
    int k;
    k = a*a;
    return k;
}

void testSquare() {
    ASSERT(square(3) == 9);
    ASSERT(square(4) == 16);
    ASSERT(square(9) == 81);
}

/** Fonction principale
 **/
int main() {
    int a;
    cin >> a;
    testFactoriel();
    testBinome();
    testSquare();
    cout << square(square(a));
}
