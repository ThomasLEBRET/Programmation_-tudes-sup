#include <iostream>

using namespace std;

void permuter(int &c, int &d) {
	int temp;
	temp=c; 
	c=d; 
	d=temp;
}

void ordonner(int &a, int &b) {
	if(a>b) {
		permuter(a,b);
	}
}

void test() {
int x=7;
int y=5;
int z=3;
ordonner(x,y); ordonner(y,z); ordonner(x,y);
cout << x << " " << y << " " << z << endl;
}

int main() {
	return 0;
}