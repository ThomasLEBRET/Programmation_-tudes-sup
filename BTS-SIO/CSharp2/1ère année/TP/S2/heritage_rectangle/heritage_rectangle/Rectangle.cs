using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace heritage_rectangle
{
    class Rectangle : System.Windows.Forms.Panel
    {
        //Variables privées
        private int longueur;
        private int largeur;

        private void MetAJourCouleur()
        {
            if (this.EstUnCarre())
                this.BackColor = Color.Red;
            else
                this.BackColor = Color.Blue;
        }

        /* Interface */

        //Constructeurs + surcharges

        public Rectangle()
        {

        }

        public Rectangle(int uneLongueur, int uneLargeur)
        {
            longueur = uneLongueur;
            largeur = uneLargeur;
            MetAJourCouleur();
        }

        //Accesseurs
        public int GetLongueur()
        {
            return longueur;
        }

        public int GetLargeur()
        {
            return largeur;
        }

        //Mutateurs
        public void SetLongueur(int uneLongueur)
        {
            longueur = uneLongueur;
            MetAJourCouleur();
        }

        public void SetLargeur(int uneLargeur)
        {
            largeur = uneLargeur;
            MetAJourCouleur();
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
