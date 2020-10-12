using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace inscription_serialisation
{
    class MesOutils
    {
        public static void EffacerZonesDeTexte(Form maFenetre)
        {
            foreach (Control c in maFenetre.Controls)
            {
                if (c is TextBox)
                    c.Text = "";
            }
        }

        public static string MoisEnClair(int unNumMois)
        {
            List<string> lesMois = new List<string>();
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

        public static void ColorerBoutons(Form maFenetre, Color uneCouleur)
        {
            foreach (Control c in maFenetre.Controls)
            {
                if (c is Button)
                    c.BackColor = uneCouleur;
            }
        }

        public static string ConvertiSecondes(int mesSecondes)
        {
            if (mesSecondes >= 60)
            {
                int heures = mesSecondes / 3600;
                int secondes = mesSecondes % 3600;
                int minutes = mesSecondes / 60;
                secondes = secondes % 60;
                return (heures.ToString() + ":" + minutes.ToString() + ":" + secondes.ToString());
            }
            return mesSecondes.ToString();
        }
    }
}
