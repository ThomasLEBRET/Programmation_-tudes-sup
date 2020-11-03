using System;
using System.Collections.Generic;
using System.Text;

namespace plat
{
    class CompareCategPrix : IComparer<Plat>
    {
        public int Compare(Plat a, Plat b)
        {
            int critCatCroiss = a.GetCategorie().CompareTo(b.GetCategorie());
            if(critCatCroiss == 0)
                return a.GetPrix().CompareTo(b.GetPrix());
            return critCatCroiss;   
        }

    }
}
