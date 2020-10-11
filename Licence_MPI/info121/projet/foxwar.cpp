#include "hpp/animal.hpp"
#include "hpp/coordonnees.hpp"
#include "hpp/deplacement.hpp"
#include "hpp/ensemble.hpp"
#include "hpp/grille.hpp"
#include "hpp/tools.hpp"

#include <iostream>
#include <string>
#include <stdexcept>
#include <time.h>
#include <unistd.h>
#include <fstream>
#include <sstream>
#include <cmath>
#include <cstdlib>
#include <ctime>
#include <SFML/Window.hpp>
#include <SFML/Graphics.hpp>
#include <SFML/Graphics/Transformable.hpp>
#include <SFML/Window/VideoMode.hpp>
#include <SFML/Graphics/Font.hpp>
#include <SFML/Graphics/Text.hpp>

using namespace std;

int main() {
  srand(time(NULL));
  system("mkdir images");
  grille g,g2;
  int l,r;
  int n = 0;
  grilleVide(g2);
  grilleVide(g);
  initialiseGrille(g);
  compte(g, l ,r);
  string graph;
  string population;
  do {
    cout << "Voulez-vous utiliser le mode graphique ? (o / n)" << endl;
    cin >> graph;
    cout << "Voulez-vous arreter la simulation des qu une population a ete decimee ? (o / n) " << endl;
    cin >> population;
    cout << "Vos choix sont : " << endl << "Affichage graphique : " << graph  << endl << "Fin simulation : " << population << endl;
  }while( (graph != "o" && graph != "n") || (population != "o" && population != "n") );
  cout << endl << "La simulation va commencer  : " << endl;
  sleep(1);
  if(population == "o" && graph == "n") {
    while((l != 0 && r != 0) && n < 300) {
      grilleVide(g2);
      deplace(g, g2);
      copieGrille(g2,g);
      compte(g, l ,r);
      afficherGrille(g);
      cout << endl;
      cout << "Lapins : " << l << endl;
      cout << "Renards : " << r << endl;
      sleep(1);
      n++;
      image(g,n);
      reint_display();
    }
  }
  if(population == "n" && graph == "n") {
    while((l != 0 && r != 0) && n < 300) {
      grilleVide(g2);
      deplace(g, g2);
      copieGrille(g2,g);
      compte(g, l ,r);
      afficherGrille(g);
      cout << endl;
      cout << "Lapins : " << l << endl;
      cout << "Renards : " << r << endl;
      sleep(1);
      n++;
      image(g,n);
      reint_display();
    }
  }

  sf::RenderWindow window(sf::VideoMode(sf::VideoMode::getDesktopMode().width,sf::VideoMode::getDesktopMode().height), "Graphique SFML", sf::Style::Default); /* Créé une fenetre */

  if(population == "n" && graph == "o") {
    while((l != 0 && r != 0) && n < 300) {
      grilleVide(g2);
      deplace(g, g2);
      copieGrille(g2,g);
      compte(g, l ,r);
      afficherGrille_SFML(window,g,l,r,n);
      n++;
      image(g,n);
    }
  }

  if(population == "o" && graph == "o") {
    while((l != 0 && r != 0) && n < 300) {
      grilleVide(g2);
      deplace(g, g2);
      copieGrille(g2,g);
      compte(g, l ,r);
      afficherGrille_SFML(window,g,l,r,n);
      n++;
      image(g,n);
    }
  }
  reint_display();
  cout << "Images generated : " << n << endl;
  system("mkdir anime");
  system("ffmpeg -r 1/0.15 -i images/f%d.ppm -c:v libx264 anime/video.mp4");
  system("ffmpeg -i anime/video.mp4 anime/gif_anime.gif");
  sleep(1);
  return 0;
}
