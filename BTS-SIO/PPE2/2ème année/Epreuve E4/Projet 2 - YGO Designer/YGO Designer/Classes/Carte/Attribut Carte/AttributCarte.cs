using System;
using System.Collections.Generic;
using System.Text;

namespace YGO_Designer.Classes.Carte.Attribut_Carte
{
    public class AttributCarte
    {
        private string cdAttrC;
        private string nomAttrC;

        public AttributCarte(string cdAttrC, string nomAttrC)
        {
            this.cdAttrC = cdAttrC;
            this.nomAttrC = nomAttrC;
        }

        public override string ToString()
        {
            return nomAttrC;
        }

        public string GetCodeAttribut()
        {
            return this.cdAttrC;
        }
    }
}
