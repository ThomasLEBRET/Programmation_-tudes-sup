#include <iostream>
#include <cmath>
#include <cstdlib>

#include "PolyAbstr.hpp"
/*  Premiere Partie  */
/*
void  PolynomeNul(Polynome &p) {
  for (int i = 0; i < MAX_DEGRE+1; i++) {
    p.coeffs[i] = 0;
  }
}

bool egalPoly(Polynome p1, Polynome p2) {
  for (int i = 0; i < MAX_DEGRE+1; i++) {
    if (p1.coeffs[i] == p2.coeffs[i]) {
      return true;
    }
    else return false;
  }
}

void  modifierCoeffPoly(Polynome &p, int d, float co) {
  p.coeffs[d] = co;
}

int degrePoly(Polynome p) {
  int n = -1;
    for (int i = 0; i < MAX_DEGRE+1; i++) {
    if(p.coeffs[i] != 0){
      n = i;
    }
  }
    return n;
}

float coeffPoly(Polynome p, int d) {
  return p.coeffs[d];
}

bool estNulPoly(Polynome p) {
  for (int i = 0; i < MAX_DEGRE+1; i++) {
    if (p.coeffs[i] == 0) {
      return true;
    }
  }
  return false;
}
*/

/*   Ameliorations   */

void PolynomeNul(Polynome &p) {
  p.degre = -1;
  for (int i = 0; i < MAX_DEGRE+1; i++) {
    p.coeffs[i] = 0;
  }
}

bool egalPoly(Polynome p1, Polynome p2) {
    if (p1.degre != p2.degre) {
      return false;
    }
    else {
      for (int i = 0; i < MAX_DEGRE+1; i++) {
        if (p1.coeffs[i] != p2.coeffs[i]) {
          return false;
        }
      }
    }
    return true;
  }

void  modifierCoeffPoly(Polynome &p, int d, float co) {

}

int degrePoly(Polynome p) {
  return p.degre;
}

float coeffPoly(Polynome p, int d) {
  return p.coeffs[d];
}

bool estNulPoly(Polynome p) {
  return p.degre == -1;
}

/////////////////////////////////////////////////////////////////////////////////
//                             fonctions de tests                              //
/////////////////////////////////////////////////////////////////////////////////

/** Infrastructure minimale de test **/
#define ASSERT(test) if (!(test)) std::cout << "Test failed in file " << __FILE__ \
                                       << " line " << __LINE__ << ": " #test << std::endl

void test_PolynomeNul() {
    Polynome p;
    PolynomeNul(p);
    ASSERT(estNulPoly(p));
    ASSERT(coeffPoly(p, 0)==0);
    ASSERT(coeffPoly(p, 1)==0);
}

void test_modifierCoeffPoly() {
    Polynome p;
    PolynomeNul(p);
    modifierCoeffPoly(p, 0, 2);
    ASSERT(coeffPoly(p, 0)==2);
    ASSERT(coeffPoly(p, 1)==0);
    modifierCoeffPoly(p, 1, 42);
    ASSERT(coeffPoly(p, 0)==2);
    ASSERT(coeffPoly(p, 1)==42);
}

void test_degrePoly() {
    Polynome p;
    PolynomeNul(p);
    ASSERT(degrePoly(p) == -1);
    modifierCoeffPoly(p, 0, 2);
    ASSERT(degrePoly(p) == 0);
    modifierCoeffPoly(p, 5, 2);
    ASSERT(degrePoly(p) == 5);
    modifierCoeffPoly(p, 3, 1);
    ASSERT(degrePoly(p) == 5);
    modifierCoeffPoly(p, 5, 0);
    ASSERT(degrePoly(p) == 3);
}

void test_coeffPoly(){
    Polynome p;
    PolynomeNul(p);
    for (int i=0; i<10; i++)
        ASSERT(coeffPoly(p, i)==0);
    modifierCoeffPoly(p, 0, 2);
    ASSERT(coeffPoly(p, 0)==2);
    for (int i=1; i<10; i++)
        ASSERT(coeffPoly(p, i)==0);
    modifierCoeffPoly(p, 3, 42);
    ASSERT(coeffPoly(p, 0)==2);
    ASSERT(coeffPoly(p, 1)==0);
    ASSERT(coeffPoly(p, 2)==0);
    ASSERT(coeffPoly(p, 3)==42);
    for (int i=4; i<10; i++)
        ASSERT(coeffPoly(p, i)==0);
}

void test_estNulPoly(){
    Polynome p;
    PolynomeNul(p);
    ASSERT(estNulPoly(p));
    modifierCoeffPoly(p, 0, 2);
    ASSERT(! estNulPoly(p));
    modifierCoeffPoly(p, 2, 2);
    ASSERT(! estNulPoly(p));
    modifierCoeffPoly(p, 0, 0);
    ASSERT(! estNulPoly(p));
    modifierCoeffPoly(p, 2, 0);
    ASSERT(estNulPoly(p));
}
