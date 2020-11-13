using System;
using System.Collections.Generic;
using System.Text;

namespace YGO_Designer.Classes.Carte
{
    public class Monstre : Carte
    {
        private string typeMo;
        private string attrMo;
        private int nbrEtoiles;
        private int atk;
        private int def;
        public Monstre(string typeMo, string attrMo, int nivMo, int atk, int def, List<Effet> eff, int no, Attribut attr, string nom, string description)
            : base(eff, no, attr, nom, description)
        {
            this.typeMo = typeMo;
            this.attrMo = attrMo;
            this.nbrEtoiles = nivMo;
            this.atk = atk;
            this.def = def;
        }

        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
                return false;
            else
            {
                Monstre m = (Monstre)obj;
                return no == m.no;
            }
        }

        public string GetTypeMonstre()
        {
            return this.typeMo;
        }

        public string GetAttrMonstre()
        {
            return this.attrMo;
        }

        public int GetNivMonstre()
        {
            return this.nbrEtoiles;
        }

        public int GetAtk()
        {
            return this.atk;
        }
        public int GetDef()
        {
            return this.def;
        }
    }
}
