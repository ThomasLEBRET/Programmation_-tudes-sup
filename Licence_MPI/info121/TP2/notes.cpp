#include <iostream>
#include <vector>

using namespace std;

void repartition(){
	vector<int> notes = 
	{3, 1, 3, 1, 2, 2, 5, 5, 5, 2, 3, 2, 2, 1, 1, 1, 2,
		0, 5, 2, 4, 3, 5, 5, 1, 5, 2, 5, 1, 0, 2, 2, 1, 5};
		int cpt = 0;
		int pos = 0;
		int k = 0;

		for (cpt = 0; cpt <= 5; cpt++) {
			cout << cpt << "  ";
		}

		cout << endl;
		cpt = 0;

		for (cpt = 0; cpt <= 5; cpt++) {
			for (pos = 0; pos <= notes.size(); pos++) {
				if(notes[pos] == cpt){
					k++;
				}
			}
			cout << k << "  ";
			k = 0;
		}
		cout << endl;
	}

	int main(int argc, char const *argv[])
	{
		repartition();
		return 0;
	}