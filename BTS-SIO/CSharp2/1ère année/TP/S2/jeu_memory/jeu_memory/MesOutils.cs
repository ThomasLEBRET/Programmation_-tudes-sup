using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace jeu_memory
{
    /* Auteur : Thomas LEBRET
     * Class générale permettant d'utiliser des méthodes universelles 
     */
    class MesOutils
    {
        /*
         * Auteur : Thomas LEBRET
         * @param : un nombre de secondes <int>
         * @return : une chaine de caractères contenant un nombre de minutes et secondes <string>
         * Permet de convertir un nombre entier de secondes en minutes et secondes. Une chaine de caractère est renvoyée
         */
        public static string ConvertiSecondes(int mesSecondes)
        {
            if (mesSecondes >= 60)
            {
                int minutes = mesSecondes / 60;
                int secondes = mesSecondes % 60;
                return minutes.ToString() + ":" + secondes.ToString();
            }
            return mesSecondes.ToString();
        }
    }
}
