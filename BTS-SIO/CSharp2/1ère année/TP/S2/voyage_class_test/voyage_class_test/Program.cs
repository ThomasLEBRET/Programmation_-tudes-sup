using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace voyage_class_test
{
    class Program
    {
        static void Main(string[] args)
        {
            Passager passager1 = new Passager(54, 1);
            Passager passager2 = new Passager(55, 2);
            Passager passager3 = new Passager(56, 1);

            Bagage bagage1 = new Bagage(1, 7, passager1);
            Bagage bagage2 = new Bagage(2, 5, passager1);
            Bagage bagage3 = new Bagage(3, 13, passager2);
            Bagage bagage4 = new Bagage(4, 10, passager3);
            Bagage bagage5 = new Bagage(5, 8, passager3);
            Bagage bagage6 = new Bagage(6, 5, passager3);

            Soute laSoute = new Soute();
            laSoute.AjouterBagage(bagage1);
            laSoute.AjouterBagage(bagage2);
            laSoute.AjouterBagage(bagage3);
            laSoute.AjouterBagage(bagage4);
            laSoute.AjouterBagage(bagage5);
            laSoute.AjouterBagage(bagage6);
            float poidsTotal = laSoute.PoidsTotal();
            float poids = laSoute.PoidsBagages(passager3);
            Console.WriteLine(poidsTotal);
            Console.WriteLine(poids);
            Console.ReadKey();
        }
    }
}
