using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TP2 {
    class TP2 {
        static void Main(string[] args) {
            /* 1°) Année comportant un 29 Février : */
            Console.WriteLine("Entrez une année afin de vérifier si elle comporte un 29 Février :");
            string date;
            int dateBis; 
            do 
            {
                date = Console.ReadLine();
            } while(!int.TryParse(date, out dateBis));
            if(DateTime.IsLeapYear(dateBis)) {
                Console.WriteLine("L'année comporte un 29 Février.\n");
            }
            else {
                Console.WriteLine("L'année ne comporte pas un 29 Février.\n");
            }
            Console.ReadKey();
            Console.Clear();
            /* 2°) Quizz 2 Décembre suivi d'un 20 Décembre */
            Console.WriteLine("En quelle année, en France, le 9 Décembre a-t-il été suivi, dès le lendemain, du 20 Décembre ?");
            string ans;
            int answer;
            do 
            {
                ans = Console.ReadLine();
            } while(!int.TryParse(ans, out answer));
            if(answer == 1582) {
                Console.WriteLine("Bravo pour votre culture !\n");
            }
            else {
                Console.WriteLine("Eh non ! En raison de la transition du calendrier Julien au calendrier Georgien en 1582, les français ont dormi le 9 Décembre pour se réveiller le 20 Décembre ;)\n");
            }
            Console.ReadKey();
            Console.Clear();

            /* 3°) Copier 50x "Je ne dois pas tomber en panne pendant les TP de SI4" */

            for(int i = 1; i <= 50; i++) {
                Console.WriteLine(i + " : Je ne dois pas tomber en panne pendant les TP de SI4");
            }
            Console.ReadKey();
            Console.Clear();

            /* 4°) Poids idéal d'une personne */
            double h = 0.9;
            double f = 0.8;
            double size, age, sexe, result;
            string taille, ageHumain, genre;
            Console.WriteLine("Calcul idéal de votre poids :\n");
            Console.WriteLine("Etes vous un homme ou une femme ? (1 -> homme | 2 -> femme)");
            do 
            {
                genre = Console.ReadLine();
                double.TryParse(genre, out sexe);
            } while(sexe > 2 || sexe < 1);
            Console.WriteLine("Quel âge avez-vous ?");
            do 
            {
                ageHumain = Console.ReadLine();
                double.TryParse(ageHumain, out age);
            } while(age < 1 || age > 130);
            Console.WriteLine("Combien mesurez-vous ? (en cm)");
            do 
            {
                taille = Console.ReadLine();
                double.TryParse(taille, out size);
            } while(size < 50 || size > 300);
            if(sexe == 1) 
            {
                result = ((size - 100) + (age / 10)) * h;
                if(result <= 0) 
                {
                    result = -result;
                }
                Console.WriteLine("Votre poids idéal serait : " + result + "Kg pour un homme.");
            }
            else 
            {
                result = ((size - 100) + (age / 10)) * f;
                Console.WriteLine("Votre poids idéal serait : " + result + "Kg pour une femme.");
            }
            Console.ReadKey();
            Console.Clear();

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
                int select;
                string selection = "";
                do {
                    selection = Console.ReadLine();
                    int.TryParse(selection, out select);// Convertie la sélection en integer
                } while((select < 1 || select > 4));
                switch(select) {
                    case 1:
                        Console.WriteLine("Le but est de servir le ballon à l’une des équipes adverses de façon que cette dernière ne puisse pas le récupérer avant qu’il ne touche le sol.");
                        break;
                    case 2:
                        Console.WriteLine("Le Taichi Chuan est un art martial chinois souvent réduit à une gymnastique de santé.");
                        break;
                    case 3:
                        Console.WriteLine("Le cricket est un sport collectif de balle et de batte opposant deux équipes composées normalement de onze joueurs chacune.");
                        break;
                    case 4:
                        Console.WriteLine("Quitter");
                        break;
                }
                Console.ReadKey();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            
            /* 6°) M&M's */
            int jaune = 0;
            int lilas = 0;
            int rouge = 0;
            int abandon = 0;
            int choice = 0;
            int nbEleves = 0;
            string eleve, choix;
            Console.WriteLine("Combien d'élèves sont dans le groupe ? ");
            do 
            {
                eleve = Console.ReadLine();
            } while(!int.TryParse(eleve, out nbEleves));
            for(int i = 0; i < nbEleves; i++) {
                Console.WriteLine("Choisissez votre couleur de M&M's :\n");
                Console.WriteLine("Jaune poussin (1)");
                Console.WriteLine("Lilas (2)");
                Console.WriteLine("Rouge cerise (3)");
                Console.WriteLine("Je laisse ma part (autre valeur)");
                do
                {
                    choix = Console.ReadLine();
                } while(!int.TryParse(choix, out choice));
                switch(choice) {
                    case 1:
                        jaune++;
                        break;
                    case 2:
                        lilas++;
                        break;
                    case 3:
                        rouge++;
                        break;
                    default:
                        Console.WriteLine("Un eleve n'aura pas de M&M's");
                        abandon++;
                        break;
                }
                Console.Clear();
                Console.WriteLine("Il y a : \n");
                Console.WriteLine(jaune + " M&M's jaune poussin");
                Console.WriteLine(lilas + " M&M's Lilas");
                Console.WriteLine(rouge + " M&M's Rouge cerise");
                Console.WriteLine(abandon + " M&M's restant");
            }
            Console.WriteLine("La distribution est terminée !");
            Console.ReadKey();
            Console.Clear();

            /* 7°) Génération d'aléatoires */
            Random aleatoire = new Random();
            int hazard = aleatoire.Next(1, 100);
            int rep = 0;
            int cpt = 0;
            string reponse;
            Console.WriteLine("Trouve la valeur à laquelle je pense qui est comprise entre 1 et 100 :");
            do {
                do 
                {
                reponse = Console.ReadLine();
                } while(!int.TryParse(reponse ,out rep));
                if(rep > hazard) {
                    Console.WriteLine("C'est moins");
                }
                else if(rep < hazard) {
                    Console.WriteLine("C'est plus");
                }
                cpt++;
            } while(hazard != rep);
            Console.WriteLine("Eh bah enfin ! Tu as quand même mis " + cpt + " essais avant de trouver ...");
            Console.ReadKey();
            Console.Clear();
            /* 8°)  Recensement M&M's 2 classes / 3 groupes par classe*/
            int totalEleves = 0;
            int totalMms = 0;
            jaune = 0;
            rouge = 0;
            lilas = 0;
            abandon = 0;
            cpt = 0;
            string nbElevesString;
            for(int classe = 1; classe <= 2; classe++) {
                for(int groupe = 1; groupe<= 3; groupe++) {
                    Console.WriteLine("Entrez le nombre d'élèves du groupe "+groupe+ " de la classe "+classe);
                    do 
                    {
                        nbElevesString = Console.ReadLine();
                    } while(!int.TryParse(nbElevesString, out nbEleves));
                    totalEleves += nbEleves;
                    while(cpt != nbEleves) {
                        Console.WriteLine("Choisissez votre couleur de M&M's :\n");
                        Console.WriteLine("Jaune poussin (1)");
                        Console.WriteLine("Lilas (2)");
                        Console.WriteLine("Rouge cerise (3)");
                        Console.WriteLine("Je laisse ma part (autre valeur)");
                        do
                        {
                            choix = Console.ReadLine();
                        } while(!int.TryParse(choix, out choice));
                        cpt++;
                        switch(choice) {
                            case 1:
                                jaune++;
                                totalMms++;
                                break;
                            case 2:
                                lilas++;
                                totalMms++;
                                break;
                            case 3:
                                rouge++;
                                totalMms++;
                                break;
                            default:
                                Console.WriteLine("Un eleve n'aura pas de M&M's");
                                abandon++;
                                break;
                        }
                        Console.Clear();
                        Console.WriteLine("Il y a pour "+nbEleves+" eleves du groupe "+groupe+" de la classe "+classe+": \n");
                        Console.WriteLine(jaune + " M&M's jaune poussin");
                        Console.WriteLine(lilas + " M&M's Lilas");
                        Console.WriteLine(rouge + " M&M's Rouge cerise");
                        Console.WriteLine(abandon + " M&M's restant");
                    }
                    jaune = 0;
                    rouge = 0;
                    lilas = 0;
                    abandon = 0;
                    cpt = 0;
                    nbEleves = 0;
                }
            }
            Console.WriteLine("La distribution de M&M's est terminée ");
            Console.WriteLine("La prof doit donner "+totalMms+" M&M's à "+totalEleves+" élèves !");
            Console.ReadKey();
            /* 9°)  Création et résolution d'exercice */
            /*s
            Console.WriteLine("Calcul de la moyenne de la classe :");
            Console.Write("Combien d'élèves sont dans votre classe ?");
            nbElevesString = "";
            double nbrEleves = 0;
            string valeurString = "";
            do {
                nbElevesString = Console.ReadLine();
                double.TryParse(nbElevesString, out nbrEleves);
            } while(nbrEleves <= 0);
            double val = 0.00;
            double moyenne = 0.00;
            double total = 0.00;
            for(int i = 1; i <= nbrEleves; i++) {
                do {
                    Console.WriteLine("Entrez la note de l'élève " + i + " :");
                    valeurString = Console.ReadLine();
                } while(double.TryParse(valeurString, out val) == false || val < 0 || val > 20);
                moyenne += val;
                val = 0;
                valeurString = "";
            }
            total = moyenne / nbrEleves;
            Console.WriteLine("La moyenne de vos " + nbrEleves + " élèves est de "+total); */
            Console.ReadKey(); 
        }
    }
}


