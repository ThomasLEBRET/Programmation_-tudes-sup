using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SLAM45_TPTDHeritageConstructeur
{
    public class Voiture : Vehicule
    {
        private int nbVitesse;
        private string typeBoite;

        public Voiture(string immat, string couleur, string typeBoite, int nbVitesse)
            :base(immat, couleur)
        {
            this.typeBoite = typeBoite;
            this.nbVitesse = nbVitesse;
        }
        public Voiture(string immat, string typeBoite,int nbVitesse)
            :base(immat)
        {
            this.typeBoite = typeBoite;
            this.nbVitesse = nbVitesse;
        }
        public Voiture(string immat, int nbVitesse)
            :base(immat)
        {
            this.nbVitesse = nbVitesse;
        }

        public override string ToString()
        {
            return base.ToString()+ nbVitesse+"/"+typeBoite;
        }
    }
}