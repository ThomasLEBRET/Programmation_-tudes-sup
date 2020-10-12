using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TP2_Exercices
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 5°) Menu + choix x4 des sports (s'arrete a 4) */

            Console.WriteLine(" *** 4°) *** \n");
            Console.ForegroundColor = ConsoleColor.Green; //Colore la console en magenta (rose pâle sous Linux)
            Console.WriteLine("*** MENU ***\n\n\n");
            Console.WriteLine("Quel sport préférez-vous ?\n");
            Console.WriteLine("1. Le Kin-Ball");
            Console.WriteLine("2. Le Taichi Chuan");
            Console.WriteLine("3. Le Cricket");
            Console.WriteLine("4. Quitter le menu");
            Console.Write("\nVotre Choix (1 ,2 ,3 ,4) :");
            string operateur = Console.ReadLine();
            while(operateur != "4")
            {
                switch(operateur)
                {
                    case "1":
                        Console.WriteLine("Le but est de servir le ballon à l’une des équipes adverses de façon que cette dernière ne puisse pas le récupérer avant qu’il ne touche le sol.");
                        break;
                    case "2":
                        Console.WriteLine("Le Taichi Chuan est un art martial chinois souvent réduit à une gymnastique de santé.");
                        break;
                    case "3":
                        Console.WriteLine("Le cricket est un sport collectif de balle et de batte opposant deux équipes composées normalement de onze joueurs chacune.");
                        break;
                    default:
                        Console.WriteLine("Le choix n'est pas valide !");
                        break;
                }
                operateur = Console.ReadLine();
            }
            Console.WriteLine("Quitter");
            Console.ReadKey();
        }
    }
}
