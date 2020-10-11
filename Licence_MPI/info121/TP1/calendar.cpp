#include <iostream>
#include <vector>
using namespace std;

int main () {
	vector<string> nom_mois = {
		"Janvier", "Fevrier", "Mars", "Avril", "Mai", "Juin", "Juillet",
		"Aout", "Septembre", "Octobre", "Novembre", "Decembre"
	};
	vector<string> semaine={"lu","ma","me","je","ve","sa","di"};
	vector<string> semaine_complete={"lundi","mardi","mercredi","jeudi","vendredi","samedi","dimanche"};
	vector<int> long_mois = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
	int jour;
	int mois;
	int an;
	int cpt_sem = 0;
	int u = 1;

	do {
		cout << "Entrez l'année de votre choix :" << endl;
		cin >> an;
		cout << "Entrez le mois de votre choix :" << endl;
		cin >> mois;
		cout << "Entrez le jour de votre choix :" << endl;
		cin >> jour;

	} while(jour > 31 || mois > 12 || jour < 1 || mois < 1 || an < 1583); //1583 : année de référence
	if (an%4==0 || (an%100==0 && an%400!=0))
	{
		long_mois[1] = 29;
	}

	int c = (14-mois)/12; //c=1 pour janvier et 0 pour le reste
	int a = an - c; 
	int m = mois + (12*c) - 2;
	int j = (jour + a + a/4 - a/100 + a/400 + (31*m)/12)%7; // retourne le jour tel que dim = 0, lun = 1 etc...

	if (j==0)
	{
		j=7;
	}
	cpt_sem = jour-1;

	cout << "	   " << nom_mois[mois-1] << "	 "<<endl<<endl;

	for (int i = 0; i < 7; i++) {
		cout << " " <<  semaine[i] << " ";
	}
	cout << endl;
			
	for (int o = 0; o <= 4; o++) {
		cout << endl;
		for(int k = 1; k <= 7; k++){

			if (o==0){
				while(j!=u){
					cout << "    ";
					u++;
					k++;
			}
		}
			if(cpt_sem < long_mois[mois-1]){
				cpt_sem++;
			}
			else{
				break;
			}

			//esthetisme
			if (cpt_sem >9)
			{
				cout << "  " << cpt_sem;
			}
			else{
				cout << "  " << cpt_sem << " ";
			}
		}
		cout << endl;
	}
cout << endl;
	cout << "Le " << jour << "/" << mois << "/" << an << " est un " << semaine_complete[j-1] << endl;
	return 0;
}