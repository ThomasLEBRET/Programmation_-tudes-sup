using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace YGO_Designer.Classes.Carte
{
    public class Carte
    {
        protected int no; //PK
        protected Attribut attr; 
        protected string nom;
        protected string description;
        protected List<Effet> eff;

        public Carte()
        {
            this.eff = new List<Effet>();
            this.no = 00000000;
            this.attr = new Attribut();
            this.nom = "Unknow";
            this.description = "Void";
        }

        public Carte(List<Effet> eff, int no, Attribut attr, string nom, string description)
        {
            this.eff = new List<Effet>();
            this.eff = eff;
            this.no = no;
            this.attr = attr;
            this.nom = nom;
            this.description = description;
        }

        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
                return false;
            else
            {
                Carte c = (Carte)obj;
                return no == c.no;
            }
        }

        public override string ToString()
        {
            return this.nom;
        }

        public List<Effet> GetListEffets()
        {
            return this.eff;
        }

        public int GetNo()
        {
            return this.no;
        }

        public Attribut GetAttr()
        {
            return this.attr;
        }
        public string GetNom()
        {
            return this.nom;
        }

        public string GetDescription()
        {
            return this.description;
        }

        public void SetCdAttr(Attribut attr)
        {
            this.attr = attr;
        }

        public void SetNo(int no)
        {
            this.no = no;
        }
    }
}
