#include <iostream>
#include <vector>
using namespace std;

#define ASSERT(test) if (!(test)) cout << "Test failed in file " << __FILE__ \
<< " line " << __LINE__ << ": " #test << endl

int median(int a, int b, int c){

	int med = 0;

	if((a > b && a < c) || (a < b && a > c)) {
		med = a;
		return med;
	}
	else if((b > a && b < c) || (b < a && b > c)) {
		med = b;
		return med;
	}
	else if((c > b && c < a) || (c < b && c > a)) {
		med = c;
		return med;
	}

	return 0;
}

void testMedian() {
  ASSERT(median(10,5,3) == 5);
  ASSERT(median(30,60,90) == 60);
  ASSERT(median(-10,-5,0) == -5);
  ASSERT(median(-6,-8,-10) == -8);
}

int main(){
	testMedian();
	int a;
	int b;
	int c;
	cout << "Entrez 3 nombres :" << endl;
	cin >> a;
	cout << endl;
	cin >> b;
	cout << endl;
	cin >> c;
	cout << endl;
	cout << "La valeur médiane au 3 valeurs est : " << median(a,b,c) << endl;
	return 0;

}