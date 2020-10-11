/*Fonctions Grille */

#include <iostream>
#include <unistd.h>
#include "../hpp/grille.hpp"
#include <sstream>

using namespace std;
using namespace sf;

/* Nettoie l'affichage */
void reint_display() {
  cout << "\x1B[2J\x1B[H" << endl;
}

/* range un animal dans la grille */
void setAnimal(grille &g, animal a) {
  g.t[getY(coordAnimal(a))][getX(coordAnimal(a))]=a;
}

/*initialise une grille vide*/
void grilleVide(grille &g) {
  for (int i =0; i < TAILLE; i++){
    for (int j =0; j<TAILLE; j++){
      setAnimal(g,creerAnimal(Rien,creeCoord(j,i)));
    }
  }
}

/*initialise une grille aleatoirement*/
void initialiseGrille (grille &g) {
  float r;
  Animal e;
  for (int i =0; i < TAILLE; i++){
    for (int j =0; j<TAILLE; j++){
      r= rand()%100/100.;
      e=Rien;
      if (r< ProbR+ProbL) e=Lapin;
      if (r< ProbR) e=Renard;
      setAnimal(g,creerAnimal(e,creeCoord(j,i)));
    }
  }
}

void afficherGrille(grille g) {
for (int i =0; i < TAILLE; i++){
for (int j =0; j<TAILLE; j++){
switch (especeAnimal(g.t[i][j])){
case 0: cout << "\033[1;34m" <<" L "; break;
case 1: cout << "\033[1;31m" << " R "; break;
default: cout << "\033[1;37m" << " O ";
}
}
cout<<endl;
}
}

/*affiche une grille SFML */
void afficherGrille_SFML(RenderWindow& window, grille g, int l, int r, int n) {
  n++;
  RectangleShape lapin(Vector2f(30,30)); /* Initialise un rectangle de 10x10 px */
  lapin.setFillColor(Color(0, 0, 255)); /* Colorie le rectable "LAPIN" en bleu */
  RectangleShape renard(Vector2f(30,30));
  renard.setFillColor(Color(255,0,0));
  RectangleShape rien(Vector2f(30,30));
  rien.setFillColor(Color(255,255,255));
  Font font;
  if (!font.loadFromFile("cinzel.otf")) {}

  stringstream nbr;
  nbr  << "Number of images generated :  " << n;
  string nbr2 = nbr.str();

  int x = 610;
  int y = 50;

  int size_police = 25;
  Text iteration;
  iteration.setFont(font);
  iteration.setString(nbr2.c_str());
  iteration.setCharacterSize(size_police);
  iteration.setPosition(x,y);

  stringstream lapin_text;
  stringstream renard_text;
  lapin_text << "Rabbits : " << l ;
  renard_text  << "Foxes : " << r;
  string nbr_lapin = lapin_text.str();
  string nbr_renard = renard_text.str();

  Text lap;
  lap.setFont(font);
  lap.setString(nbr_lapin.c_str());
  lap.setCharacterSize(size_police);
  lap.setPosition(x,3*y);

  Text ren;
  ren.setFont(font);
  ren.setString(nbr_renard.c_str());
  ren.setCharacterSize(size_police);
  ren.setPosition(x,4*y);

  Text continu;
  continu.setFont(font);
  continu.setString("Press A to continue");
  continu.setCharacterSize(25);
  continu.setPosition(x,6*y);

  Text quit;
  quit.setFont(font);
  quit.setString("Press Q to quit the main function");
  quit.setCharacterSize(size_police);
  quit.setPosition(x,7*y);

  Text fast;
  fast.setFont(font);
  fast.setString("Press F to finish quickly");
  fast.setCharacterSize(size_police);
  fast.setPosition(x,8*y);
  //ren.setColor(Color::Red);
  while (window.isOpen()) { /* Tant que la fenêtre est ouverte, on récupère tous les evenements */
    Event event;
    while (window.pollEvent(event)) { /* Action des evenements : Si on clique sur fermer, la fenetre se ferme */
      if (event.type == Event::Closed)
      window.close();
    }
    /* Sinon, on fait notre travail dans la fenêtre en cours */
    window.clear(Color::Black);
    for (int i = 0; i < TAILLE; i++) {
      for (int j = 0; j < TAILLE; j++) {
        switch (especeAnimal(g.t[i][j])){
          case 0: lapin.setPosition(j*30.f, i*30.f); window.draw(lapin); break;
          case 1: renard.setPosition(j*30.f, i*30.f); window.draw(renard); break;
          default: rien.setPosition(j*30.f, i*30.f); window.draw(rien);
        }
      }
    }
    window.draw(iteration);
    window.draw(continu);
    window.draw(quit);
    window.draw(fast);
    window.draw(lap);
    window.draw(ren);
    window.display();
    Time t3 = seconds(0.1);
    if(Keyboard::isKeyPressed(Keyboard::F)) {
      sleep(0);
      return;
    }
    if (Keyboard::isKeyPressed(Keyboard::A)) {
      window.clear(Color::Black);
      sleep(t3);
      return;
    }
    if(Keyboard::isKeyPressed(Keyboard::Q)) exit(EXIT_SUCCESS);
  }
}

/*retourne une copie de l animal situe aux coordonnees "c" dans la grille */
animal getAnimal(grille g, coord c) {
  animal a;
  a= g.t[getY(c)][getX(c)];
  return a;
}

/*Copie grille 1 dans grille 2*/
void copieGrille (grille g1, grille &g2) {
  coord c; animal a;
  for (int i =0; i < TAILLE; i++){
    for (int j =0; j<TAILLE; j++){
      c=creeCoord(j,i);
      a= getAnimal(g1, c);
      setAnimal(g2,a);
    }
  }
}

/*Retourne lensemble des cases voisines contenant l espece e */
tab_coord voisinsEspeces(grille g, animal a, Animal e) {
  tab_coord t,v;
  t.n=0;
  v=retourne_voisins(coordAnimal(a));
  for (int i=0; i<v.n ; i++){
    if (especeAnimal(getAnimal(g,v.tab[i]))==e)ajoute_coord(t,v.tab[i]);
  }
  return t;
}
