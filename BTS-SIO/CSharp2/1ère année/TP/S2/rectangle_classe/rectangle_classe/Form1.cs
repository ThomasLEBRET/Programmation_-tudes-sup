using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace rectangle_classe
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

        private void btValider_Click(object sender, EventArgs e)
        {
            int longueur = Convert.ToInt16(numLongueur.Text);
            int largeur = Convert.ToInt16(numLargeur.Text);
            MessageBox.Show(numLongueur.Text);
        }

        private void numLongueur_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numLargeur_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
