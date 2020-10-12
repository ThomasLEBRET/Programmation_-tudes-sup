using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace insee_version_debutant {
    class Program {
        static void Main(string[] args) {
            string insee, key, code;
            int keyNbr;
            long inseeNbr, codeNbr, result; //Permet de stocker de longues valeurs
            Console.WriteLine("Entrez votre numéro INSEE");
            insee = Console.ReadLine();
            inseeNbr = Convert.ToInt64(insee); //On convertie la chaine en Int64 qui équivaut au type long
            if(insee.Length != 15) {
                Console.WriteLine("Erreur : Votre numéro INSEE ne possède pas 15 numéros !");
            }
            else 
            {
                code = insee.Substring(0, 13);
                key = insee.Substring(13, 2);
                codeNbr = Convert.ToInt64(code);
                keyNbr = Convert.ToInt16(key);
                inseeNbr = Convert.ToInt64(insee);
                result = 97 - (codeNbr % 97);
                if(result != keyNbr) {
                    Console.WriteLine("Erreur : Votre numéro INSEE n'est pas valide !");
                }
                else {
                    Console.WriteLine("Votre numéro INSEE est valide, félicitation !");
                }
            }
            Console.ReadKey();
        }
    }
}
