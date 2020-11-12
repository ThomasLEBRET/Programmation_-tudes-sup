using System;
using System.Collections.Generic;
using System.Text;

namespace YGO_Designer.Classes.Monstre.Attribut_Monstre
{
    public class AttributMonstre
    {
        private string cdAttrMo;
        private string nomAttrMo;

        public AttributMonstre(string cdAttrMo, string nomAttrMo)
        {
            this.cdAttrMo = cdAttrMo;
            this.nomAttrMo = nomAttrMo;
        }

        public override string ToString()
        {
            return nomAttrMo;
        }
    }
}
