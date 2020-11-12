using System;
using System.Collections.Generic;
using System.Text;
using YGO_Designer.Classes.Carte.Attribut_Carte;
using YGO_Designer.Classes.Monstre.Attribut_Monstre;

namespace YGO_Designer.Classes.Carte
{
    public class Monstre : Carte
    {
        private TypeMonstre cdTypeMo;
        private AttributMonstre cdAttrMo;
        private int nbrEtoiles;
        private int atk;
        private int def;

        public Monstre(TypeMonstre cdTypeMo, int no, AttributMonstre cdAttrMo, int nbrEtoiles, int atk, int def, AttributCarte codeAttr, string nom, string description) 
            : base(no, codeAttr, nom, description)
        {
            this.cdTypeMo = cdTypeMo;
            this.cdAttrMo = cdAttrMo;
            this.nbrEtoiles = nbrEtoiles;
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
    }
}
