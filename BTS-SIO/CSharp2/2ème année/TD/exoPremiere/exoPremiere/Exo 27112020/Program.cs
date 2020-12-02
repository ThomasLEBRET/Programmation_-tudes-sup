using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_27112020
{
    class Program
    {
        public static void Main(String[] args)
        {
            new Premiere();
            Console.WriteLine("=============================");
            new Seconde(true);
            Console.WriteLine("=============================");
            new Troisieme(15);
            Console.WriteLine("=============================");
            new Quatrieme(12.3);
            Console.WriteLine("=============================");
            new Cinquieme();
            Console.WriteLine("=============================");
            new Sixieme();
            Console.WriteLine("=============================");
            new Septieme(6);
            Console.WriteLine("=============================");
            new Huitieme(3); 
            new Dixieme(10.5); 
            Console.WriteLine("=============================");
            new Dixieme(45, true);


            Console.ReadKey();
        }
    }
}
