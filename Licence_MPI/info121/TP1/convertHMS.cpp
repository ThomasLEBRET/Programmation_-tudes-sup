#include <iostream>
#include <vector>
using namespace std;

/** Infrastructure minimale de test **/
#define ASSERT(test) if (!(test)) cout << "Test failed in file " << __FILE__ \
<< " line " << __LINE__ << ": " #test << endl


/** Converti une durée en Heure, Minute, Seconde en seconde
 *  @param  entiers dans un vecteur
 *  @return À une case d'un vecteur
 **/
int convertHMS2S(vector<int> hms) {
  return (hms[0]*3600) + (hms[1]*60) + (hms[2]);
}

void testConvertHMS2S() {
  ASSERT( convertHMS2S({0,1,15}) == 75 );
  ASSERT( convertHMS2S({1,20,15}) == 4815 );
  ASSERT( convertHMS2S({4,0,15}) == 14415 );
  ASSERT( convertHMS2S({2,50,0}) == 10200 );
}

/** À compléter
 *  @param un entier s
 *  @return un vecteur de 3 entiers hms
 **/
vector<int> convertS2HMS(int d) {
  vector<int> hms;
  hms = vector<int> (3);
  hms[2] = d;
  while(hms[2] >= 60){
    hms[2] = hms[2] - 60;
    hms[1] = hms[1] + 1;
  }
  while(hms[1] >= 60){
    hms[1] = hms[1] - 60;
    hms[0] = hms[0] + 1;
  }
  return hms;
}

void testConvertS2HMS() {
  ASSERT( convertS2HMS(75) == vector<int>({0,1,15}) );
  ASSERT( convertS2HMS(120) == vector<int>({0,2,0}) );
  ASSERT( convertS2HMS(3600) == vector<int>({1,0,0}) );
}


void testHMS(vector<int> hms) {
    ASSERT( hms[0] >=0 and hms[0] < 24  );
    ASSERT( hms[1] >= 0 and hms[1] < 60 );
    ASSERT( hms[2] >= 0 and hms[2] < 60 );
}

int main() {
  testConvertHMS2S();
  testConvertS2HMS();

  int d;
  vector<int >t;
  t = vector<int >(3);

  for(int i =0; i <= 80000; i++){
    t = convertS2HMS(i);
    testHMS(t);
    d = convertHMS2S(t); 
    d==i; 
  }
}
