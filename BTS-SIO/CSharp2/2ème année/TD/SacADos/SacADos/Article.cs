using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SacADos
{
    class Article : IComparable <Article>
    {
        private string nom;
        private int poids;
        private int utilite;
        private float utiliteSurPoids;

        public Article(string nom, int poids, int utilite)
        {
            this.nom = nom;
            this.poids = poids;
            this.utilite = utilite;
            this.utiliteSurPoids = (float)Math.Round((double)utilite / poids, 5);
        }

        public string GetNom()
        {
            return this.nom;
        }

        public int GetPoids()
        {
            return this.poids;
        }

        public int GetUtilite()
        {
            return this.utilite;
        }

        public float GetUtiliteSurPoids()
        {
            return this.utiliteSurPoids;
        }

        public void SetNom(string nom)
        {
            this.nom = nom;
        }

        public void SetPoids(int poids)
        {
            this.poids = poids;
        }

        public void SetUtilite(int utilite)
        {
            this.utilite = utilite;
        }

        public void SetUtiliteSurPoids(float utiliteSurPoids)
        {
            this.utiliteSurPoids = utiliteSurPoids;
        }

        public override string ToString()
        {
            return this.nom + " / Poids = " + Outils.ConvertiPoidsEnKg(this.poids)  + " / Utilité = " + this.utilite + " / Rapport = " + this.utiliteSurPoids;
        }

        public int CompareTo(Article a)
        {
            int triValueRapport = this.utiliteSurPoids.CompareTo(a.utiliteSurPoids);
            int triValuePoids = this.poids.CompareTo(a.poids);
            if(triValueRapport == 0)
                return triValuePoids * -1;
            return triValueRapport * -1;
        }
    }
}
