#include <iostream>
#include <iomanip>

using namespace std;

float power(float x, unsigned int n) {
    unsigned int i;
    float res = 1.;
    for (i=0; i<n; i++)
        res *= x;
    return res;
}

float factorial(int n) {
    float res = 1;
    for (int i = 1; i<= n; i++) res = res*i;
    return res;
}

float exponentiel(float x) {
    const float epsilon = 1e-7;
    float res = 1., term;
    int i = 1;
    do {
        term = power(x, i) / factorial(i);
        res += term;
        i++;
    } while ((term / res) > epsilon);
    return res;
}


void affiche(void) {
    cout.precision(3);
    cout << fixed;

    for (double x=0; x<2; x=x+0.2)
        cout << setw(5) << x << " ";
    cout << endl;
    for (double x=0; x<2; x=x+0.2)
        cout << setw(5) << exponentiel(x) << " ";
    cout << endl;
}

int main() {
    affiche();
    return 0;
}
