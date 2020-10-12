using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace classe_rectangle
{
    class Rectangle
    {
        private float longueur;
        private float largeur;
        private String couleur;

        //Methode privées de la classe
        private void MetAJourCouleur()
        {
            if(longueur == largeur)
                couleur = "rouge";
            else 
                couleur = "bleu";
        }

        /* Interface */

        //Constructeurs + surcharges
        public Rectangle()
        {

        }

        public Rectangle(float uneLongueur, float uneLargeur)
        {
            longueur = uneLongueur;
            largeur = uneLargeur;
            MetAJourCouleur();
        }

        //Mutateurs
        public void SetLongueur(float uneLongueur)
        {
            longueur = uneLongueur;
            MetAJourCouleur();
        }

        public void SetLargeur(float uneLargeur)
        {
            largeur = uneLargeur;
            MetAJourCouleur();
        }

        //Accesseurs
        public float GetLongueur()
        {
            return longueur;
        }

        public float GetLargeur()
        {
            return largeur;
        }

        public String GetCouleur()
        {
            return couleur;
        }

        //Méthodes spécifiques de cette classe
        public float Perimetre()
        {
            float perimetre = (this.longueur + this.largeur) * 2;
            return perimetre;
        }

        public float Surface()
        {
            float surface = this.longueur * this.largeur;
            return surface;
        }

        public bool EstUnCarre()
        {
            if (this.largeur == this.longueur)
                return true;
            return false;
        }

        public bool AMemesDimensionsQue(Rectangle unRectangle)
        {
            if (this.largeur == unRectangle.largeur && this.longueur == unRectangle.longueur)
                return true;
            return false;
        }
    }
}
