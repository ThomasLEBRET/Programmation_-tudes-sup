#include <iostream>
#include <vector>

using namespace std;

vector<int> permutation (vector<int> perm){
	int N = perm.size();
	int pos0;
	/* On regarde déjà si N <= aux valeurs du vecteur ET on regarde si aucune des valeurs sont identiques
	 */
	for (int i = 0; i <= perm.size(); i++) { // si une valeur du vector dépasse N, la suite n'est pas permutable 
		if (perm[i] >= N) {
			cout << "La suite n'est pas permutable !" << endl;
			break;
		}
	}

	for (int i = 0; i <= perm.size(); i++) {
		for (int j = 1; j <= perm.size(); j++) {
			if (perm[i] == perm[j]) {
				cout << "La suite n'est pas permutable !" << endl;
				break;
			}
		}
	}

	cout << "La suite est permutable" << endl;
}

int main()
{
	int n;
	int a;
	int cpt = 0;
	vector<int> perm;
	cout << "Entrez le nombre de valeurs voulu dans votre tableau :" << endl;
	cin >> n;
	perm = vector<int>(n);
	while(cpt != n){
		cout << "Entrez vos valeurs (une valeur puis appuyez sur Entrer) :" << endl;
		cin >> a;
		cpt++;
	}
	permutation(perm);
	
	return 0;
}