using System;
using System.Collections.Generic;
using System.Text;

namespace plat
{
    class Plat : IComparable<Plat>
    {
        private string nom;
        private string categorie;
        private int prix;
        private int nbcalories;
        private bool glutenFree;
        private bool vegan;

        public Plat(string nom, string categorie, int prix, int nbcalories, bool glutenFree, bool vegan)
        {
            this.nom = nom;
            this.categorie = categorie;
            this.prix = prix;
            this.nbcalories = nbcalories;
            this.glutenFree = glutenFree;
            this.vegan = vegan;
        }

        public string GetNom()
        {
            return this.nom;
        }

        public string GetCategorie()
        {
            return this.categorie;
        }

        public int GetPrix()
        {
            return this.prix;
        }

        public int GetNbcalories()
        {
            return this.nbcalories;
        }

        public bool GetVegan()
        {
            return this.vegan;
        }

        public int CompareTo(Plat p)
        {
            return this.nom.CompareTo(p.nom);
        }

        public override bool Equals(Object o)
        {
            if (o == null || !this.GetType().Equals(o.GetType()))
                return false;
            else 
            {
                Plat p = (Plat) o;
                return (nom == p.nom) && (categorie == p.categorie) && (nbcalories == p.nbcalories) && (prix == p.prix) && (glutenFree == p.glutenFree) && (vegan == p.vegan);
            }
        }

        public override string ToString()
        {
            return "NOM : " + nom + " - CATEGORIE : " + categorie + " - PRIX : " + prix + "€ - " + nbcalories + "cal - GLUTEN : " + glutenFree + " - VEGAN : " + vegan;
        }
    }
}
