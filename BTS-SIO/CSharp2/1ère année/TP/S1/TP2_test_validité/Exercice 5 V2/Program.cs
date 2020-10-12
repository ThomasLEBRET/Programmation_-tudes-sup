using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercice_6_V2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] operateurValable = new string[] { "1", "2", "3" };
            string operateur = "";
            string nbrElevesStr = "";
            int rouge = 0;
            int jaune = 0;
            int lilas = 0;
            int nbrEleves = 0;
            int cpt = 0;
            int cptTableau = 0;
            Console.WriteLine("Combien d'élèves avez-vous ?");
            nbrElevesStr = Console.ReadLine();
            while (!int.TryParse(nbrElevesStr, out nbrEleves) || nbrEleves <= 0)
            {
                Console.WriteLine("Le nombre d'élèves est invalide !");
                Console.WriteLine("Combien d'élève avez-vous ?");
                nbrElevesStr = Console.ReadLine();
            }
            while (cpt != nbrEleves)
            {
                cptTableau = operateurValable.Length;
                Console.WriteLine("Rentrer votre choix de M&M's :\n");
                Console.WriteLine("Rouge (1)");
                Console.WriteLine("Jaune (2)");
                Console.WriteLine("Lilas (3)");
                while (cptTableau == operateurValable.Length)
                {
                    cptTableau = 0;
                    operateur = Console.ReadLine();
                    for (int i = 0; i <= 2; i++)
                    {
                        if (operateur != operateurValable[i])
                        {
                            cptTableau++;
                        }
                    }
                    if (cptTableau == operateurValable.Length)
                    {
                        Console.WriteLine("Erreur, l'opérateur n'est pas reconnu !");
                        Console.WriteLine("Rentrer une nouvelle valeur");
                    }
                }
                switch (operateur)
                {
                    case "1":
                        jaune++;
                        Console.WriteLine("Un jaune a été ajouté");
                        break;
                    case "2":
                        rouge++;
                        Console.WriteLine("Un rouge a été ajouté");
                        break;
                    case "3":
                        lilas++;
                        Console.WriteLine("Un lilas a été ajouté");
                        break;
                }
                cpt++;
            }
            Console.WriteLine("Il y a au total : \n");
            Console.WriteLine(jaune + " M&M's jaune(s)");
            Console.WriteLine(rouge + " M&M's rouge(s)");
            Console.WriteLine(lilas + " M&M's lilas");
            Console.ReadKey();
        }
    }
}
