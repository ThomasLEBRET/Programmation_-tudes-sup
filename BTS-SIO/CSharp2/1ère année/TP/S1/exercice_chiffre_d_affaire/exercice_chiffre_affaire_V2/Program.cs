using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exercice_chiffre_affaire_V2
{
    class Program
    {
        static void Main(string[] args)
        {
            double CA = 0;
            double cumulCA = 0;
            double CAHaut = 0;
            double CABas = 0;
            string moisHaut = "";
            string moisBas = "";
            string[] mois = {"Janvier","Février","Mars","Avril","Mai","Juin"};
            for (int i = 1; i <= 6; i++)
            {
                Console.WriteLine("Rentrer le chiffre d'affaire du mois " + mois[i-1]);
                CA = Convert.ToInt32(Console.ReadLine());
                    if (CA > CAHaut)
                    {
                        CAHaut = CA;
                        moisHaut = mois[i - 1];
                    }
                    if (CA < CABas)
                    {
                        CABas = CA;
                        moisBas = mois[i - 1];
                    }
                cumulCA += CA;
            }
            Console.WriteLine("Le cumul du chiffre d'affaire semestriel est de : " + cumulCA);
            Console.WriteLine("Le chiffre d'affaire le plus haut est de : " + CAHaut + " pour " + moisHaut);
            Console.WriteLine("Le chiffre d'affaire le plus bas est de : " + CABas + " pour " + moisBas);
            Console.ReadKey();
        }
    }
}
