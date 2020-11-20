using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;
using MySql.Data.MySqlClient;

namespace ORMPlat
{
    public class Plat : IComparable<Plat>
    {
        private string nom;
        private Categorie categorie;
        private int prix;
        private int nbcalories;
        private bool glutenFree;
        private bool vegan;

        public Plat()
        {
            this.nom = "unknow";
            this.categorie = Categorie.Entrée;
            this.prix = 0;
            this.nbcalories = 0;
            this.glutenFree = false;
            this.vegan = false;
        }

        public Plat(string nom, Categorie categorie, int prix, int nbcalories, bool glutenFree, bool vegan)
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

        public Categorie GetCategorie()
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

        public bool GetGlutenFree()
        {
            return this.glutenFree;
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

        public void SetCategorie(Categorie categorie)
        {
            this.categorie = categorie;
        }

        internal void SetPrix(int prix)
        {
            this.prix = prix;
        }

        public void SetVegan(bool vegan)
        {
            this.vegan = vegan;
        }

        public void SetGlutenFree(bool gluten)
        {
            this.glutenFree = gluten;
        }

        public void SetNbCalories(int nbcalories)
        {
            this.nbcalories = nbcalories;
        }

        internal void SetNom(string nom)
        {
            this.nom = nom;
        }
    }
}
