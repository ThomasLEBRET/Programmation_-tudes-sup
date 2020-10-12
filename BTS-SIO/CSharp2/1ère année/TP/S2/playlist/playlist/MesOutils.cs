using System;
using System.Drawing;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace playlist
{
    class MesOutils
    {
        /*
         * Permet d'effacer une zone de texte d'une fenêtre Windows Form
         * @param: une fenêtre Windows Form 
         * @return: void
         */
        public static void EffacerZonesDeTexte(Form maFenetre)
        {
            foreach (Control c in maFenetre.Controls)
            {
                if (c is TextBox || c is NumericUpDown)
                    c.Text = "";
            }
        }

        /*
         * Permet de traduire un numéro de mois compris entre 1 et 12 en texte
         * @param: un numéro de mois int
         * @return: une chaine de caractère comportant le numéro du mois
         */
        public static string MoisEnClair(int unNumMois)
        {
            ArrayList lesMois = new ArrayList();
            lesMois.Add("Janvier");
            lesMois.Add("Février");
            lesMois.Add("Mars");
            lesMois.Add("Avril");
            lesMois.Add("Mai");
            lesMois.Add("Juin");
            lesMois.Add("Juillet");
            lesMois.Add("Août");
            lesMois.Add("Septembre");
            lesMois.Add("Octobre");
            lesMois.Add("Novembre");
            lesMois.Add("Décembre");
            return (string)lesMois[unNumMois];
        }

        /* 
         *Colore les boutons d'une fenêtre de type Windows Form 
         *@param: une fenetre Form, une couleur Color
         *@return: void
         */
        public static void ColorerBoutons(Form maFenetre, Color uneCouleur)
        {
            foreach (Control c in maFenetre.Controls)
            {
                if (c is Button)
                    c.BackColor = uneCouleur;
            } 
        }
        /*
         * Converti un nombre de secondes en heure, minute, seconde
         * @param in: un nombre de secondes int
         * @param out: un nombre d'heure, de minute et de seconde int
         * @return: void
         */
        public static void ConvertiSecondes(int mesSecondes, out int heure, out int minute, out int seconde)
        {
            heure = mesSecondes / 3600;
            int resteSecondes = mesSecondes % 3600;
            minute = resteSecondes / 60;
            resteSecondes = resteSecondes % 60;
            seconde = resteSecondes;
        }
    }
}
