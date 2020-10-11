#include<iostream>
#include <fstream>
#include <sstream>
#include "../hpp/tools.hpp"

using namespace std;
/*Fonctions outils*/
void afficherCoord(coord c) {
  cout << " x : " << getX(c) << " y : " << getY(c) <<endl;
}

void compte (grille g, int &l, int &r) {
  l=0; r=0;
  for (int i=0; i < TAILLE ; i++){
    for (int j=0; j <TAILLE ; j++){
      if (especeAnimal(g.t[i][j])==Lapin) l++;
      if (especeAnimal(g.t[i][j])==Renard) r++;
    }
  }
}

void image (grille g, int n) {
  ostringstream oss;
  oss << "images/" << "f" << n << ".ppm";
  string img = oss.str();
  ofstream f(img.c_str());
  f << "P3" << endl;
  f << "160 160" << endl;
  f << "255" << endl;
  for (int i =0; i < TAILLE; i++){
    for (int w=0 ; w<8 ;w++){
      for (int j =0; j<TAILLE; j++){
        switch (especeAnimal(g.t[i][j])){
          case 0: f<< " 0 0 255 0 0 255 0 0 255 0 0 255 0 0 255 0 0 255 0 0 255 0 0 255 "; break;
          case 1: f<< " 255 0 0 255 0 0 255 0 0 255 0 0 255 0 0 255 0 0 255 0 0 255 0 0"; break;
          default: f<< " 255 255 255 255 255 255 255 255 255 255 255 255 255 255 255 255 255 255 255 255 255 255 255 255 ";
        }
      }
      f<<endl;
    }

    f<<endl;
  }
  f.close();
}
