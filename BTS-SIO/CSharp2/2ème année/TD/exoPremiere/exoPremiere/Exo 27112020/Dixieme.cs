using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_27112020
{
    class Dixieme : Neuvieme
    {
        public Dixieme(double d)
            : base(true)
        {
            Console.WriteLine("premier constructeur de Dixieme");
        }
        public Dixieme(int x, bool y)
            : base(x)
        {
            Console.WriteLine("second constructeur de Dixieme");
        }
    }
}
