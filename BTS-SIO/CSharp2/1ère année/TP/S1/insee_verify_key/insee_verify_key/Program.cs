using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace insee_verify_key {
    class Program {
        static void Main(string[] args) {
            /*
             * On supposera dans ce TD que la clé INSEE vérifie le sexe,
             * l'age, le mois et l'année de naissance de l'utilisateur.
             */
            string insee, key, code;
            long verify, codeNbr, result;
            Int16 keyNbr;
            bool cund = true;
            Console.WriteLine("Entrez votre code INSEE :");
            do {
                insee = "";
                insee = Console.ReadLine();
                if(insee.Length != 15 || long.TryParse(insee, out verify) == false) {
                    Console.WriteLine("Un des erreurs suivantes se sont produites :");
                    Console.WriteLine("-Votre numéro INSEE ne comporte pas 15 caractères");
                    Console.WriteLine("-Il y a des caractères alphabétiques dans votre numéro INSEE");
                }
                else {
                    code = insee.Substring(0, 13);
                    key = insee.Substring(13, 2);
                    long.TryParse(code, out codeNbr);
                    Int16.TryParse(key, out keyNbr);
                    result = 97 - (codeNbr % 97);
                    if(result != keyNbr) {
                        Console.WriteLine("Erreur, le numéro INSEE est invalide !");
                        Console.WriteLine(insee);
                        Console.WriteLine(result);
                        Console.WriteLine(keyNbr);
                    }
                    else {
                        Console.WriteLine("Le numéro INSEE est valide.");
                        Console.WriteLine(result);
                        Console.WriteLine(keyNbr);
                        cund = false;
                    }
                }
            } while(cund);
            Console.ReadKey();
        }
    }
}
