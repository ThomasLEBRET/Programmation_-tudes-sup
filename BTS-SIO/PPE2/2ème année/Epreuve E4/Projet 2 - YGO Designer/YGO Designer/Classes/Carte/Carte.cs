using System;
using System.Collections.Generic;
using System.Text;
using YGO_Designer.Classes.Carte.Attribut_Carte;

namespace YGO_Designer.Classes.Carte
{
    public class Carte
    {
        protected int no; //PK
        protected AttributCarte codeAttr; //FK -> attribut_carte
        protected string nom;
        protected string description;

        public Carte(int no, AttributCarte codeAttr, string nom, string description)
        {
            this.no = no;
            this.codeAttr = codeAttr;
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

        public int GetNo()
        {
            return this.no;
        }

        public AttributCarte GetCdAttr()
        {
            return this.codeAttr;
        }
        public string GetNom()
        {
            return this.nom;
        }

        public string GetDescription()
        {
            return this.description;
        }
    }
}
