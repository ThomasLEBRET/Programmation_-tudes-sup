#ifndef GRILLE_HPP_INCLUDED
#define GRILLE_HPP_INCLUDED

#include "coordonnees.hpp"
#include "animal.hpp"
#include <SFML/Graphics.hpp>

const float ProbR = 0.07;
const float ProbL = 0.20;

struct grille{
    animal t[TAILLE][TAILLE];
};

/* _Fonctions grille.cpp_ */
void reint_display();
void setAnimal(grille &g, animal a);
void grilleVide(grille &g);
void initialiseGrille (grille &g);
void afficherGrille(grille g);
void afficherGrille_SFML(sf::RenderWindow &window, grille g, int l, int r, int n);
animal getAnimal(grille g, coord c);
void copieGrille (grille g1, grille &g2);
tab_coord voisinsEspeces(grille g, animal a, Animal e);

#endif
