using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace YGO_Designer.Classes.Carte
{
    public class Carte
    {
        private int no; //PK
        private Attribut attr; 
        private string nom;
        private string description;
        private List<Effet> eff;
        private int nbExemplaireDansDeck;

        public Carte()
        {
            this.eff = new List<Effet>();
            this.no = 00000000;
            this.attr = new Attribut();
            this.nom = "Unknow";
            this.description = "Void";
            this.nbExemplaireDansDeck = -1;
        }

        public Carte(List<Effet> eff, int no, Attribut attr, string nom, string description)
        {
            this.eff = new List<Effet>();
            this.eff = eff;
            this.no = no;
            this.attr = attr;
            this.nom = nom;
            this.description = description;
            this.nbExemplaireDansDeck = -1;
        }

        public Carte(List<Effet> eff, int no, Attribut attr, string nom, string description, int nbExemplaireDansDeck)
            :this(eff,no,attr,nom,description)
        {
            this.nbExemplaireDansDeck = nbExemplaireDansDeck;
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
            string maCarte = "";
            if (nbExemplaireDansDeck <= 0)
                maCarte = this.no + " : " + this.attr + " " + this.nom;
            else
                maCarte = this.no + " : " + this.attr + " " + this.nom + " x" + this.GetNbExemplaireDansDeck();
            return maCarte;
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

        public int GetNbExemplaireDansDeck()
        {
            return this.nbExemplaireDansDeck;
        }

    }
}
