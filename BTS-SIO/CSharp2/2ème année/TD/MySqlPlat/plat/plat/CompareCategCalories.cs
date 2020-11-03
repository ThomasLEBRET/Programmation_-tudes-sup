using System;
using System.Collections.Generic;
using System.Text;

namespace plat
{
    class CompareCategCalories : IComparer<Plat>
    {
        public int Compare(Plat a, Plat b)
        {
            int critCatCroiss = a.GetCategorie().CompareTo(b.GetCategorie());
            if (critCatCroiss == 0)
                return a.GetNbcalories().CompareTo(b.GetNbcalories());
            return critCatCroiss;
        }
    }
}
