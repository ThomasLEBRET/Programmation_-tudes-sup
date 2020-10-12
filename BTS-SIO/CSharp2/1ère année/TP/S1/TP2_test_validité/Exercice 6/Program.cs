using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TP2_Exercices {
    class Program {
        static void Main(string[] args) {
            string operateur, nbrElevesStr;
            int rouge = 0;
            int jaune = 0;
            int lilas = 0;
            int nbrEleves = 0;
            Console.WriteLine("Combien d'élèves avez-vous ?");
            nbrElevesStr = Console.ReadLine();
            while(!int.TryParse(nbrElevesStr, out nbrEleves) || nbrEleves <= 0)
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
                        Console.WriteLine("Un jaune a été pris en compte");
                        break;
                    case "2":
                        rouge++;
                        Console.WriteLine("Un rouge a été pris en compte");
                        break;
                    case "3":
                        lilas++;
                        Console.WriteLine("Un lilas a été pris en compte");
                        break;
                }
                Console.WriteLine("Appuyer sur une touche pour continuer la sélection");
                Console.ReadLine();
                Console.Clear();
            }
            Console.WriteLine("Nous avons : \n");
            Console.WriteLine(jaune+" Jaune(s)");
            Console.WriteLine(rouge+" Rouge(s)");
            Console.WriteLine(lilas+" Lila(s)");
            Console.ReadKey();
        }
    }
}
