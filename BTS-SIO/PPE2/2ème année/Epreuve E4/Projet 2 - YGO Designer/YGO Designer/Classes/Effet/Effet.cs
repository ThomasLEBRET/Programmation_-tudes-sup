using System;
using System.Collections.Generic;
using System.Text;

namespace YGO_Designer.Classes.Effet
{
    public class Effet
    {
        private string cdE;
        private string nomE;

        public Effet(string cdE, string nomE)
        {
            this.cdE = cdE;
            this.nomE = nomE;
        }

        public override string ToString()
        {
            return nomE;
        }
    }
}
