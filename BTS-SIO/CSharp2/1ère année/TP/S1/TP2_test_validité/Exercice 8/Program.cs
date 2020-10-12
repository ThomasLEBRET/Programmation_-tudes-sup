using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercice_8
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Boucle for imbriquées (pour i allant de 1 à 3 inclus / pour i allant de 1 à 3 exclus ? */
            string operateur, nbrElevesStr;
            int rouge = 0;
            int jaune = 0;
            int lilas = 0;
            int totalRouge = 0;
            int totalJaune = 0;
            int totalLilas = 0;
            int nbrEleves = 0;
            int totalMms = 0;
            for (int classe = 1; classe <= 2; classe++)
            {
                for (int groupe = 1; groupe <= 3; groupe++)
                {
                    Console.WriteLine("Combien d'élèves avez-vous pour le groupe "+groupe+" de la classe "+classe+" ?");
                    rouge = 0;
                    jaune = 0;
                    lilas = 0;
                    nbrElevesStr = Console.ReadLine();
                    while (!int.TryParse(nbrElevesStr, out nbrEleves) || nbrEleves <= 0)
                    {
                        Console.WriteLine("Le nombre d'élèves est invalide !");
                        Console.WriteLine("Combien d'élève avez-vous ?");
                        nbrElevesStr = Console.ReadLine();
                    }
                    for (int i = 1; i <= nbrEleves; i++)
                    {
                        Console.WriteLine("Entrer un nombre entre 1 et 3 :\n");
                        Console.WriteLine("Jaune poussin (1)");
                        Console.WriteLine("Rouge cerise (2)");
                        Console.WriteLine("Lilas (3)");
                        operateur = Console.ReadLine();
                        while (operateur != "1" && operateur != "2" && operateur != "3")
                        {
                            Console.WriteLine("Erreur, la valeur n'est pas comprise entre 1 et 3 !");
                            Console.WriteLine("Appuyer sur une touche pour reséléctionner une valeur");
                            Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine("Entrer votre couleur de M&M's : \n");
                            Console.WriteLine("Rouge cerise (1)");
                            Console.WriteLine("Jaune Poussin (2)");
                            Console.WriteLine("Lilas (3)");
                            operateur = Console.ReadLine();
                        }
                        switch (operateur)
                        {
                            case "1":
                                jaune++;
                                totalJaune++;
                                Console.WriteLine("Un jaune a été pris en compte");
                                break;
                            case "2":
                                rouge++;
                                totalRouge++;
                                Console.WriteLine("Un rouge a été pris en compte");
                                break;
                            case "3":
                                lilas++;
                                totalLilas++;
                                Console.WriteLine("Un lilas a été pris en compte");
                                break;
                        }
                        totalMms++;
                        Console.WriteLine("Appuyer sur une touche pour continuer la sélection");
                        Console.ReadLine();
                        Console.Clear();
                    }
                    Console.WriteLine("Nous avons pour le groupe "+groupe+" de la classe "+classe+" :");
                    Console.WriteLine(jaune + " Jaune(s)");
                    Console.WriteLine(rouge + " Rouge(s)");
                    Console.WriteLine(lilas + " Lila(s)");
                }
            }
            Console.WriteLine("Nous avons à distribuer au total: \n");
            Console.WriteLine(totalJaune + " Jaune(s)");
            Console.WriteLine(totalRouge + " Rouge(s)");
            Console.WriteLine(totalLilas + " Lila(s)");
            Console.WriteLine("Soit un total de : "+totalMms+" M&M's");
            Console.ReadKey();
        }
    }
}