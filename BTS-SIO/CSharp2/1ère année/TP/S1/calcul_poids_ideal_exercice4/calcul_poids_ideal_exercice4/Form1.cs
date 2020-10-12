using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace calcul_poids_ideal_exercice4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rbHomme_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbFemme_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tbTaille_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbAge_TextChanged(object sender, EventArgs e)
        {

        }

        private void btCalculer_Click(object sender, EventArgs e)
        {
            double pdIdeal = 0;
            if ((rbHomme.Checked == false && rbFemme.Checked == false) || tbTaille.Text == "" || tbAge.Text == "")
            {
                tbPoids.Text = "Erreur !";
            }
            else
                if (rbHomme.Checked == true)
                {
                    double taille = Convert.ToDouble(tbTaille.Text);
                    int age = Convert.ToInt16(tbAge.Text);
                    //Calcul pour un homme
                    pdIdeal = ((taille - 100) + (age / 10)) * 0.9;
                }
                else
                {
                    double taille = Convert.ToDouble(tbTaille.Text);
                    int age = Convert.ToInt16(tbAge.Text);
                    //Calcul pour une femme
                    pdIdeal = ((taille - 100) + (age / 10)) * 0.8;
                }
            tbPoids.Text = pdIdeal.ToString();
        }

        private void tbPoids_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
