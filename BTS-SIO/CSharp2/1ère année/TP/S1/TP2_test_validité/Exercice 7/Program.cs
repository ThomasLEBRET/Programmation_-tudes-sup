using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercice_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatoire = new Random();
            int hazard = aleatoire.Next(1, 101);
            int rep = 0;
            int cpt = 0;
            string reponse = "";
            Console.WriteLine("Trouve la valeur à laquelle je pense qui est comprise entre 1 et 100 :");
            reponse = Console.ReadLine();
            while (hazard != rep)
            {
                while (!int.TryParse(reponse, out rep) || rep <= 0)
                {
                    Console.WriteLine("Réponse invalide !");
                    reponse = Console.ReadLine();
                }
                if (rep > hazard)
                {
                    Console.WriteLine("C'est moins");
                    reponse = Console.ReadLine();
                }
                else 
                    if (rep < hazard)
                        {
                            Console.WriteLine("C'est plus");
                            reponse = Console.ReadLine();
                        }
                cpt++;
            }
            Console.WriteLine("Eh bah enfin ! Tu as quand même mis " + cpt + " essais avant de trouver ...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
