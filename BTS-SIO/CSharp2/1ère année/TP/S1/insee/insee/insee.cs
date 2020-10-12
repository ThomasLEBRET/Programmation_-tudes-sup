using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1 {
    class Program {
        static void Main(string[] args) {
            string insee = "";
            bool cdt = true;
            do {
                Console.WriteLine("Entrez votre numéro de sécurité sociale : ");
                insee = Console.ReadLine();
                if(verify(insee)) {
                    sexe(insee);
                    birthYear(insee);
                    birthMonth(insee);
                    depBirth(insee);
                    codeCommune(insee);
                    birthOrder(insee);
                    controlKey(insee);
                    cdt = false;
                }
            } while(cdt == true);
            Console.ReadKey();
        }

        /*
        *Méthode pour vérifier de manière booléenne
        *qu'une chaine de caractères ne possède que des entiers
        *@param string chaine
        *@return booleen
        */
        static bool checkNumber(string chaine) {
            long nbr = 0;
            bool success = long.TryParse(chaine, out nbr);
            /*Vérifie si une chaine de caractère
            ne possède que des entiers de type int */
            if(success == true) {
                return true;
            }
            return false;
        }
        /*
        *Vérifie qu'une chaine possède 15 valeurs
        *@param string chaine
        *@return booleen
        */
        static bool sameNbrSecu(string chaine) {
            if(chaine.Length != 15) {
                return false;
            }
            return true;
        }
        /*
        *Vérifie que le 1er chiffre vaut 1 ou 2
        *@param string chaine
        *@return booleen
        */
        static bool isMenOrWomen(string chaine) {
            string other = chaine.Substring(0, 1);
            if(other == "1" || other == "2") {
                return true;
            }
            else {
                return false;
            }
        }
        /*
        *Vérifie que le mois est compris entre 1 et 12
        *@param string chaine
        *@return booleen
        */
        static bool verifyMonth(string chaine) {
            string other = chaine.Substring(3, 2);
            int nbr;
            Int32.TryParse(other, out nbr);
            if(nbr < 01 || nbr > 12) {
                return false;
            }
            return true;
        }
        /*
        *Vérifie que le département est compris entre 1 et 95
        *@param string chaine
        *@return booleen
        */
        static bool verifyDep(string chaine) {
            string other = chaine.Substring(5, 2);
            int nbr;
            Int32.TryParse(other, out nbr);
            if(nbr < 01 || nbr > 95) {
                return false;
            }
            return true;
        }
        /*
        *Fonction vérifiant si le code INSEE est valide
        *@param string chaine
        *@return booleen
        */
        static bool verify(string chaine) {
            if(sameNbrSecu(chaine) == false) {
                Console.WriteLine("-Votre numéro ne possède pas 15 chiffres ou vous n'avez pas rentré de code");
                return false;
            }
            else if(checkNumber(chaine) == false) {
                Console.WriteLine("-Il y a des lettres dans votre numéro");
                return false;
            }
            else if(isMenOrWomen(chaine) == false) {
                Console.WriteLine("-Le 1er numéro ne vaut pas 1 ou 2");
                return false;
            }
            else if(verifyMonth(chaine) == false) {
                Console.WriteLine("-Le mois n'est pas valide");
                return false;
            }
            else if(verifyDep(chaine) == false) {
                Console.WriteLine("-Le département n'est pas compris entre 01 et 95");
                return false;
            }
            else {
                return true;
            }
        }
        /*
        *Procédure affichant un texte en fonction du sexe
        *@param string chain
        *@return void
        */
        static void sexe(string chaine) {
            string other = chaine.Substring(0, 1);
            if(other == "2")
                Console.WriteLine("Bonjour Madame.");
            else
                Console.WriteLine("Bonjour Monsieur.");
        }
        /*
        *Procédure affichant un texte en fonction de l'année de naissance
        *@param string chaine
        *@return void
        */
        static void birthYear(string chaine) {
            string other = chaine.Substring(1, 2);
            int nbr;
            Int32.TryParse(other, out nbr);
            if(nbr > 19) {
                int result = 1900 + nbr;
                Console.WriteLine("Vous année de naissance est l'année " + result);
            }
            else {
                int otherResult = 2000 + nbr;
                Console.WriteLine("Vous année de naissance est l'année " + otherResult);
            }
        }
        /*
        *Procédure affichant une phrase en fonction du mois de naissance
        *@param string chaine
        *@return void
        */
        static void birthMonth(string chaine) {
            string[] months = new string[] { "Janvier", "Février", "Mars", "Avril", "Mai", "Juin", "Juillet", "Août", "Septembre", "Octobre", "Novembre", "Décembre" };
            string other = chaine.Substring(3, 2);
            int nbr;
            Int32.TryParse(other, out nbr);
            Console.WriteLine("Votre mois de naissance est : " + months[nbr - 1]);
        }
        /*
        *Procédure affichant une phrase en fonction du département de naissance
        *@param string chaine
        *@return void
        */
        static void depBirth(string chaine) {
            string other = chaine.Substring(5, 2);
            int nbr;
            Int32.TryParse(other, out nbr);
            Console.WriteLine("Votre département de naissance est le " + nbr);
        }
        /*
        *Procédure affichant une phrase en fonction du code INSEE
        *@param string chaine
        *@return void
        */
        static void codeCommune(string chaine) {
            string other = chaine.Substring(7, 3);
            int nbr;
            Int32.TryParse(other, out nbr);
            Console.WriteLine("Votre code commune Insee est le " + nbr);
        }
        /*
        *Procédure affichant une phrase en fonction du n° d'ordre de naissance
        *@param string chaine
        *@return void
        */
        static void birthOrder(string chaine) {
            string other = chaine.Substring(10, 3);
            int nbr;
            Int32.TryParse(other, out nbr);
            Console.WriteLine("Votre numéro d'ordre de naissance est le " + nbr);
        }
        /*
        *Procédure affichant une phrase en fonction de la clé de contrôle
        *@param string chaine
        *@return void
        */
        static void controlKey(string chaine) {
            string other = chaine.Substring(13, 2);
            int nbr;
            Int32.TryParse(other, out nbr);
            Console.WriteLine("Votre clé de contrôle est le " + nbr);
        }
    }
}
