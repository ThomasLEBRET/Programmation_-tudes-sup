using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SLAM45_TPTDHeritageConstructeur
{
    public class Vehicule
    {
        private string couleur;
        private string immat;

        public override string ToString()
        {
            return immat + " : " + couleur + "/";
        }
        public Vehicule(string immat)
        {
            this.immat = immat;
        }
        public Vehicule(string immat, string couleur)
            :this(immat)
        {
            this.couleur = couleur;
        }
    }
}