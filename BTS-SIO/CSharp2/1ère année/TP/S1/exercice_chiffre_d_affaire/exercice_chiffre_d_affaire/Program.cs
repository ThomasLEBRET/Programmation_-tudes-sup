using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exercice_chiffre_d_affaire
{
    class Program
    {
        static void Main(string[] args)
        {
            double ca;
            double cumulCA = 0;
            double caHaut = 0;
            double caBas = 0;
            int valMoisHaute = 0;
            int valMoisBasse = 0;
            string moisH = "";
            string moisB = "";
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine("Rentrer le chiffre d'affaires du mois "+i+" :");
                ca = Convert.ToDouble(Console.ReadLine());
                if (i != 1)
                {
                    if (ca > caHaut)
                    {
                        caHaut = ca;
                        valMoisHaute = i;
                    }
                    if (ca < caBas)
                    {
                        caBas = ca;
                        valMoisBasse = i;
                    }
                }
                else
                {
                    caHaut = ca;
                    valMoisHaute = i;
                    caBas = ca;
                    valMoisBasse = i;
                }
                cumulCA += ca;
            }
            moisH = LibelleMois(valMoisHaute);
            moisB = LibelleMois(valMoisBasse);
            Console.WriteLine("Le cumul du chiffre d'affaires annuel est de : "+cumulCA);
            Console.WriteLine("Le chiffre d'affaires le plus haut est de : " + caHaut + " pour " + moisH);
            Console.WriteLine("Le chiffre d'affaires le plus bas est de : " + caBas + " pour " + moisB);
            Console.ReadKey();
        }
        static string LibelleMois(int mois)
        {
            string libMois = "";
            switch (mois)
            {
                case 1:
                    libMois = "Janvier";
                    break;
                case 2:
                    libMois = "Février";
                    break;
                case 3:
                    libMois = "Mars";
                    break;
                case 4:
                    libMois = "Avril";
                    break;
                case 5:
                    libMois = "Mai";
                    break;
                case 6:
                    libMois = "Juin";
                    break;
                case 7:
                    libMois = "Juillet";
                    break;
                case 8:
                    libMois = "Août";
                    break;
                case 9:
                    libMois = "Septembre";
                    break;
                case 10:
                    libMois = "Octobre";
                    break;
                case 11:
                    libMois = "Novembre";
                    break;
                case 12:
                    libMois = "Décembre";
                    break;
            }
            return libMois;
        }
    }
}
