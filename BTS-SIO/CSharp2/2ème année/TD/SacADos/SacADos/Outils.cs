using System;
using System.Drawing;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SacADos
{
    class Outils
    {
        public static void EffacerZonesDeTexte(Form maFenetre)
        {
            foreach (Control c in maFenetre.Controls)
            {
                if (c is TextBox)
                    c.Text = "";
            }
        }

        public static string ConvertiPoidsEnKg(int grammes)
        {
            string unite = "g";
            if (grammes < 1000)
                return grammes.ToString() + unite;
            unite = "kg";
            return Convert.ToSingle((float)grammes / 1000).ToString() + unite;
        }
    }
}
