using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLAM45_TPTDHeritageConstructeur
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicule v1, v2, v3, v4, v5;

            v1 = new Vehicule("aaa", "bleue");
            v2 = new Vehicule("bbb");

            v3 = new Voiture("ccc", "rouge", "automatique", 5);
            v4 = new Voiture("ddd", "automatique", 5);
            v5 = new Voiture("eee", 6);

            Console.WriteLine(v1);
            Console.WriteLine(v2);
            Console.WriteLine(v3);
            Console.WriteLine(v4);
            Console.WriteLine(v5);

            Console.ReadLine();
        }
    }
}
