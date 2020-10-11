#include <iostream>

using namespace std;

void syracuse(int &u) {
	if(u%2 == 0) {
		u = u/2;
	}
	else {
		u = 3*u+1;
	}
}

int longueurTransient(int un){
	int i=0;
	while (un != 1) { 
		syracuse(un); i++; 
	}
	return i;
}

void test(){
	for(int i=0; i<1000; i++) {
		cout<<longueurTransient(i)<<", ";
	}
}

int main() {
	test();
	return 0;
}