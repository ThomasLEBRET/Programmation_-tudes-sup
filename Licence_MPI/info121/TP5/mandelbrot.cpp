#include <iostream>
#include <cmath>

using namespace std;

#define ASSERT(test) if (!(test)) cout << "Test failed in file " << __FILE__ \
                       << " line " << __LINE__ << ": " #test << endl

struct Complexe {
    float re, im;
};


Complexe creeComplexe(float reel, float imaginaire){
    Complexe c;
    c.re = reel;
    c.im = imaginaire;
    return c;
}

bool egaleComplexe(Complexe c1, Complexe c2){
    return (c1.re==c2.re)&&(c1.im==c2.im);
}

Complexe ajouterComplexe(Complexe c1, Complexe c2){
    Complexe resultat;
    resultat.re = c1.re + c2.re;
    resultat.im = c1.im + c2.im;
    return resultat;
}

Complexe multiplierComplexe(Complexe c1, Complexe c2){
     Complexe resultat;
     resultat.re = (c1.re * c2.re) - (c1.im*c2.im);
     resultat.im = (c1.re * c2.im) + (c2.re*c1.im);
     return resultat;
}

void testMultiplierComplexe(){
    ASSERT(egaleComplexe(multiplierComplexe(creeComplexe(0, 0),creeComplexe(1, 1)),creeComplexe(0, 0)));
    ASSERT(egaleComplexe(multiplierComplexe(creeComplexe(1, 1),creeComplexe(1, 1)),creeComplexe(0, 2)));
    ASSERT(egaleComplexe(multiplierComplexe(creeComplexe(2, 3),creeComplexe(4, 5)),creeComplexe(-7, 22)));
}

float moduleComplexe(Complexe c){
    return sqrt(c.re*c.re + c.im*c.im);
}

void testModuleComplexe(){
    ASSERT(moduleComplexe(creeComplexe(0,5)) == 5);
}

bool znResteBorne(Complexe c){
    Complexe zn = creeComplexe(0,0);
    for (int i = 0; i < 1000; ++i){
        zn = ajouterComplexe(multiplierComplexe(zn,zn),c);
    }
    if (moduleComplexe(zn) > 1000) return true;
    else return false;
}

void mandelbrot(){
    const float xmin = -2;
    const float xmax = 0.5;
    const float ymin = -1.5;
    const float ymax = 1.5;
    const int resol = 79;
    for(int i=0; i<=resol; i++) {
        for(int j=0; j<=resol; j++) {
            if(znResteBorne(creeComplexe((resol-j)*xmin/resol+j*xmax/resol,
                                         (resol-i)*ymax/resol+i*ymin/resol))) {
                    cout << '#';
            }
            else {
                    cout << ' ';
            }
        }
        cout << endl;
    }
}

int main(){
    testMultiplierComplexe();
    testModuleComplexe();
    mandelbrot();
    return 0;   
}