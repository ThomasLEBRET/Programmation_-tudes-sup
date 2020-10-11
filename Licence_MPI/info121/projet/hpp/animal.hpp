#ifndef ANIMAL_HPP_INCLUDED
#define ANIMAL_HPP_INCLUDED

#include "coordonnees.hpp"

//Pour les Renards
const int FoodInit = 5;
const int FoodLapin = 5;
const int FoodReprod = 8;
const int MaxFood = 10;
const float ProbBirthRenard = 0.05;
//Pour les Lapins
const float ProbBirthLapin = 0.30;
const int MinFreeBirthLapin = 4;

enum Animal{Lapin, Renard, Rien};

struct animal{
    Animal genre;
    coord c;
    int nourriture;
    int age;
};

/* _Fonctions animal.cpp_ */

/*
  Créer un animal.
Entrée : Une espèce et une coordonnée.
Sortie : Un nouvel animal avec tous ses paramètres.
*/
animal creerAnimal( Animal g, coord c);

/* Retourne une coordonnées d'un animal */
coord coordAnimal( animal a);

/* Retourne l'espèce d'un animal */
Animal especeAnimal( animal a);

/* Retourne le niveau de nourriture d'un animal */
int nourritureAnimal(animal a);

/* Renvoi true si il n'y a pas d'animal */
bool estVide ( animal a);

/* Change les coordonnées d'un animal */
void changeCoordAnimal (animal &a, coord c);

/* Vérifie que l'animal est un renard et augmente son niveau
    de nourriture si il n'a pas atteidn maxFood */
void mangeRenard (animal &a);

/* Diminue le niveau de nourriture d'un renard */
void faimRenard (animal &a);

/* Test si un animal doit mourir ou non en fonction de paramètres aléatoire
    pour plus de crédibilité */
bool mortAnimal(animal a);

/* Test si un animal peut se reproduire */
bool seReproduitAnimal(animal a, int nombreCaseVide);

#endif
