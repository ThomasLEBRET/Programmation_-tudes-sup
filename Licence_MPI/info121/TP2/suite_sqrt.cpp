#include <iostream>
#include <iomanip>

using namespace std;


int main()
{
  const float EPSILON = 1e-6;
  int n;
  float a=2., un, un1; // u_n et u_{n+1}

  n = 0;  un = a;
  cout << "Entrez une valeur positive : " << endl;
  cin >> a;
   while(a<0){
  	cout << "Valeur négative ! Entrez un nouveau nombre :" << endl;
  	cin >> a;
  }

  while ( (un*un != (un*un/a)-1) && (((un*un/a)-1) >= EPSILON) && (((un*un/a)-1) >= 0) ) {
    un1 = (un + a/un)/2.;       // calcul de u_{n+1}
    n = n+1; un = un1;         // passage de n à n+1
    cout << setprecision(10) << "n=" << n << ", un=" << un << ", un^2=" << un*un << endl;
  }
  return 0;
}
