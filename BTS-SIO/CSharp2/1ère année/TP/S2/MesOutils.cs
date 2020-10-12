using System;
using System.Drawing;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Test_des_méthodes_de_la_classe_MesOutils
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

        public static void ColorerBoutons(Form maFenetre, Color uneCouleur)
        {
            foreach (Control c in maFenetre.Controls)
            {
                if (c is Button)
                    c.BackColor = uneCouleur;
            } 
        }

        public static void ConvertiSecondes(int mesSecondes)
        {
            if(mesSecondes >= 60)
            {
                int heures = mesSecondes / 3600;
                int secondes = mesSecondes % 3600;
                int minutes = secondes / 60;
                MessageBox.Show(heures.ToString() + ":" + minutes.ToString() + ":" + secondes.ToString());
            }
        }
    }
}
