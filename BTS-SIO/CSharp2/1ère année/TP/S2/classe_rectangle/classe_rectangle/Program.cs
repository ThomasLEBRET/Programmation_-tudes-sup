using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace classe_rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle(5, 5);
            Rectangle r2 = new Rectangle();
            Console.WriteLine("Entrez une longueur :");
            float longueur = Convert.ToSingle(Console.ReadLine());
            r2.SetLongueur(longueur);
            Console.WriteLine("Entrez une largeur :");
            float largeur = Convert.ToSingle(Console.ReadLine());
            r2.SetLargeur(largeur);
            Console.WriteLine("La longueur du rectangle r1 vaut : " + r1.GetLongueur());
            Console.WriteLine("La largeur du rectangle r1 vaut : " + r1.GetLargeur() + "\n");

            Console.WriteLine("La longueur du rectangle r2 vaut : " + r2.GetLongueur());
            Console.WriteLine("La largeur du rectangle r2 vaut : " + r2.GetLargeur() + "\n");

            Console.WriteLine("Le périmètre de r1 vaut : " + r1.Perimetre());
            Console.WriteLine("Le périmètre de r2 vaut : " + r2.Perimetre() + "\n");

            if (r1.EstUnCarre())
                Console.WriteLine("r1 est un carré et est de couleur " + r1.GetCouleur());
            else
                Console.WriteLine("r1 n'est pas un carré, il est donc de couleur " + r1.GetCouleur());

            if (r2.EstUnCarre())
                Console.WriteLine("r2 est un carré et est de couleur " + r1.GetCouleur());
            else
                Console.WriteLine("r2 n'est pas un carré, il est donc de couleur " + r2.GetCouleur());

            if (r1.AMemesDimensionsQue(r2))
                Console.WriteLine("r1 et r2 ont les mêmes dimensions !");
            else
                Console.WriteLine("r1 et r2 n'ont pas les mêmes dimensions !");

            Console.ReadKey();
        }
    }
}
