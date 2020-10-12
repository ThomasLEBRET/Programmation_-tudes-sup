using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace calculatrice 
{
    public partial class Form1 :Form
    {
        double resultat, valeur1, valeur2;
        string nombre1, nombre2;
        public Form1() 
        {
            InitializeComponent();
        }

        private void btQuitter_Click(object sender, EventArgs e) 
        {
            Application.Exit();
        }

        private void btCalculer_Click(object sender, EventArgs e) 
        {
            nombre1 = tbNombre1.Text;
            nombre2 = tbNombre2.Text;
            valeur1 = 0;
            double.TryParse(nombre1, out valeur1);
            valeur2 = 0;
            double.TryParse(nombre2, out valeur2);
            resultat = 0;
            if(rbAddition.Checked == false && rbSoustraire.Checked == false
                && rbMultiplier.Checked == false && rbDiviser.Checked == false)
            {
                tbResultat.Text = "Erreur, aucun opérateur n'a été saisi !";
            }
            else
                if (valeur2 == 0 && rbDiviser.Checked == true)
                    {
                        tbResultat.Text = "Division par 0 impossible !";
                    }
            else
            {
                if(rbAddition.Checked == true)
                {
                    resultat = valeur1 + valeur2;
                }
                else if(rbSoustraire.Checked == true)
                {
                    resultat = valeur1 - valeur2;
                }
                else if(rbDiviser.Checked == true)
                {
                    resultat = valeur1 / valeur2;
                }
                else if(rbMultiplier.Checked == true)
                {
                    resultat = valeur1 * valeur2;
                }
                tbResultat.Text = resultat.ToString();
            }
        }

        private void btRAZ_Click(object sender, EventArgs e) 
        {
            tbResultat.Text = "";
            tbNombre1.Text = "";
            tbNombre2.Text = "";
            rbAddition.Checked = false;
            rbSoustraire.Checked = false;
            rbMultiplier.Checked = false;
            rbDiviser.Checked = false;
        }

        private void formulaire1_Load(object sender, EventArgs e)
        {
            tbResultat.Text = "";
            tbNombre1.Text = "";
            tbNombre2.Text = "";
        }
    }
}
