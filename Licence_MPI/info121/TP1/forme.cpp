#include <iostream>
#include <string.h>
using namespace std;

/** Infrastructure minimale de test **/
#define ASSERT(test) if (!(test)) cout << "Test failed in file " << __FILE__ \
				       << " line " << __LINE__ << ": " #test << endl


/** La forme d'un individu
 *  @param repos  nbr de battement cardiaque à la minute au repos
 *  @param effort nbr de battement cardiaque à la minute après l'effort
 *  @param recup  nbr de battement cardiaque à la minute après une minute de récupération
 *  @return une chaîne de caractère décrivant la forme
 **/
string forme(int repos, int effort, int recup) {

  float res = 0.1*(repos + effort + recup - 200);
  if(res <= 0){
  	cout << "excellente"<<endl;
  	return "excellente";
  }
  if(res >= 0 and res <=5){
  	cout << "tres bonne"<<endl;
  	return "tres bonne";
  }
  if(res >=5 and res <= 10){
  	cout << "bonne"<<endl;
  	return "bonne";
  }
  if(res >=10 and res <= 15){
  	cout << "moyenne"<<endl;
  	return "moyenne";
  }
  else{
  	cout << "faible"<<endl;
  	return "faible";
  }
}


void formeTest(void) {
  ASSERT( forme(60,80,60) == "excellente" );
  ASSERT( forme(70,90,80) == "tres bonne" );
  ASSERT( forme(80,120,80) == "bonne" );
  ASSERT( forme(80,150,100) == "moyenne" );
  ASSERT( forme(90,150,130) == "faible" );
}

int main() {
  formeTest();
  int a;
  int b;
  int c;
  cout << "Entrez votre rythme cardiaque au repos" << endl;
  cin >> a;
  cout << "Entrez votre rythme cardiaque avec effort fourni" << endl;
  cin >> b;
  cout << "Entrez votre rythme cardiaque après votre effort, lors de votre repos" << endl;
  cin >> c;
  forme(a, b, c);
}
