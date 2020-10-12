using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace TP1 {
    class TP1 {
        static void Main(string[] args) {
            Console.Clear();
            string answer;
            /* 1°) */
            Console.WriteLine(" *** 1°) *** \n");
            Console.WriteLine("bonjour"); //Affiche "bonjour"
            Console.ReadKey();
            Console.Clear(); //Nettoie l'affichage sur le terminal
            /* 2°) */
            Console.WriteLine(" *** 2°) *** \n");
            Console.WriteLine("Entrez votre nom :"); //Affiche "Entrez votre nom :"
            string name = Console.ReadLine(); //Créé une chaine string name et créer un champ d'insertion dans le terminal
            Console.WriteLine("Bonjour " + name); //Affiche "Bonjour " + le nouveau contenu de la variable name
            Console.ReadKey();
            Console.Clear();
            /* 3°) */
            Console.WriteLine(" *** 3°) *** \n");
            Console.WriteLine("*******  *");
            Console.WriteLine("   *     *");
            Console.WriteLine("   *     *");
            Console.WriteLine("   *     *");
            Console.WriteLine("   *     *");
            Console.WriteLine("   *     ********");
            Console.ReadKey();
            Console.Clear();
            /* 4°) */
            Console.WriteLine(" *** 4°) *** \n");
            Console.ForegroundColor = ConsoleColor.Magenta; //Colore la console en magenta (rose pâle sous Linux)
            Console.WriteLine("*** MENU ***\n\n\n");
            Console.WriteLine("Quel sport préférez-vous ?\n");
            Console.WriteLine("1. Escalade");
            Console.WriteLine("2. Taichi chuan");
            Console.WriteLine("3. Aqua gym");
            Console.Write("\nVotre Choix (1,2,3) :");
            int select;
            do {
                select = Convert.ToInt16(Console.ReadLine()); // Convertie la sélection en integer
            } while (select < 1 || select > 3);
            switch (select) { 
                /* Switch case : en fonction du numéro tapé
                 * au clavier précédemment, le programme va 
                 * sélectionner une "case" et va afficher la ligne correspondante 
                 */
                case 1:
                    Console.WriteLine("\nVous avez choisi Escalade");
                    break; //Une case se fini toujours par un break pour continuer automatiquement le programme
                case 2:
                    Console.WriteLine("\nVous avez choisi Taichi chuan");
                    break;
                case 3:
                    Console.WriteLine("\nVous avez choisi Aqua gym");
                    break;
                default: //Si aucune des cases n'a été séléctionnée, on a une "case" par default
                    Console.WriteLine("Erreur, vous n'avez pas tapé 1,2 ou 3");
                    break;
            }
            Console.ReadKey();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            /* 5°) */
            Console.WriteLine(" *** 5°) *** \n");
            Console.WriteLine("Quelle est votre année de naissance ?");
            int dateBirth, CurrentYear;
            do {
                dateBirth = Convert.ToInt16(Console.ReadLine()); //On demande l'année de naissance
                CurrentYear = DateTime.Today.Year; //On récupère l'année actuelle au type int
            } while (dateBirth < 1800 && dateBirth >= CurrentYear++);
            int res = CurrentYear - dateBirth;
            Console.WriteLine("Vous avez "+res+" ans."); //On affiche l'âge supposé de l'utilisateur
            Console.ReadKey();
            Console.Clear();
            /* 6°) */
            /* ***Méthode Prof */
            /*
            Int16 date = Convert.ToInt16(Console.ReadLine());
            if(date%4 == 0){
              if(date%100 != 0){
                Console.WriteLine("L annee est bissextile ! ");
              }
          }
            else if (date%400==0){
            Console.WriteLine("L annee est bissextile !");
          }
          else {
          Console.WriteLine("L annee n est pas bissextile !");
        }
          */
            Console.WriteLine("*** 6°) *** \n");
            Console.WriteLine("Entrez une année afin de vérifier si elle est bien bissextile :");
            int dateBis = Convert.ToInt16(Console.ReadLine());
            /*Année bissextile si divisible par 4 mais non par 400 OU si divisible par 100*/
            /*TIPS : On peut ignorer les accolades lors d'une instruction conditionnelle si et seulement si
            elle ne possède qu'une seule et unique instruction */
            if ((dateBis % 4 == 0 && dateBis % 100 != 0) || dateBis % 400 == 0)
                Console.WriteLine("L'année est bissextile !");
            else
                Console.WriteLine("L'année n'est pas bissetile.");
            if (DateTime.IsLeapYear(dateBis))
                Console.WriteLine("La fonction IsLeapYear indique true -> l'année est donc bissetile !");
            else
                Console.WriteLine("La fonction IsLeapYear indique false -> l'année n'est donc pas bissetile !");
            Console.ReadKey();
            Console.Clear();
            /* 7°) */
            Console.WriteLine("*** 7°) *** \n");
            Console.WriteLine("Rappelez moi votre nom :");
            string newName = Console.ReadLine();
            for (int i = 0; i < newName.Length; i++) //Avec une boucle for
                Console.Write("-");
            Console.Write(" : Avec une boucle for\n");
            int cpt = 0;
            while (cpt < newName.Length) {
                Console.Write("-");
                cpt++;
            }
            Console.Write(" : Avec une boucle while");
            Console.ReadKey();
            Console.Clear();

            /* 8°) */
            Console.WriteLine("*** 8°) *** \n");
            Console.WriteLine("Je sais compter ! Voulez-vous que je vous montre ? (yes / no)");
            do {
                answer = Console.ReadLine();
            } while (answer != "yes" && answer != "no");
            if (answer == "yes") {
                for (int i = 1; i <= 10; i++) {
                    if (i == 10) {
                        Console.Write(i + ".");
                        break;
                    }
                    Console.Write(i + ", ");
                }
            }
            Console.ReadKey();
            Console.Clear();
            /* 9°) */
            Console.WriteLine("*** 9°) *** \n");
            Console.WriteLine("Voici le tirage du loto !");
            Random aleatoire = new Random();
            int hazardOne; 
            int[] array = new int[] {0, 0, 0, 0, 0};
            for(int i = 0; i < 4; i++) {
                hazardOne = aleatoire.Next(1,50);
                array[i] = hazardOne;
            }
            int lastHazard = aleatoire.Next(1, 10);
            array[4] = lastHazard;
            bool cnd = true;
            while(cnd == true) {
                for(int i = 1; i < 5; i++) {
                    if(array[i-1] == array[i]){
                        cnd = false;
                        break;
                    }
                }
                Console.WriteLine("Le résultat du loto est : \n");
                for(int i = 0; i < 5; i++) {
                    Console.Write(array[i]+"    ");
                    cnd = false;
                }
                Console.Write("\n\nEt le numéro mystère est : " + lastHazard);
            }
            Console.ReadKey();
            Console.Clear();


            /* 10°) */
            Console.WriteLine("*** 10°) *** \n");
            Console.WriteLine("Je sais dessiner, voulez-vous que je vous montre ? (yes / no) \n");
            string end;
            do
            {
                end = Console.ReadLine();
            } while (end != "yes" && end != "no");

            if (end == "yes")
            {
                int l, j, k;

                for (l = 0; l < 19; l++)
                {
                    for (j = l; j < 19; j++)
                        Console.Write(" ");
                    for (j = 0; j <= l; j++)
                        Console.Write("*");
                    for (k = 0; k < l; k++)
                        Console.Write("*");
                    Console.Write("\n");
                }
                for (l = 0; l < 19; l++)
                {
                    for (j = 0; j < l + 1; j++)
                        Console.Write(" ");
                    for (k = 0; k < 18 - l; k++)
                        Console.Write("*");
                    for (k = 0; k < 19 - l; k++)
                        Console.Write("*");
                    Console.Write("\n");
                }
            }
            Console.WriteLine("");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
