using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RGB_exercice_3
{
    public partial class Form1 : Form
    {
        int r, g, b;
        public Form1()
        {
            InitializeComponent();
        }

        private void panelCouleur_Paint(object sender, PaintEventArgs e)
        {
            panelCouleur.BackColor = SystemColors.Control;
            panelCouleur.BackColor = Color.FromArgb(r, g, b);
        }

        private void hsbarreRouge_Scroll(object sender, ScrollEventArgs e)
        {
            r = hsbarreRouge.Value;
        }

        private void hsbarreVert_Scroll(object sender, ScrollEventArgs e)
        {
            g = hsbarreVert.Value;
        }

        private void hsbarreBleu_Scroll(object sender, ScrollEventArgs e)
        {
            b = hsbarreBleu.Value;
        }

        private void btQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbRouge_Click(object sender, EventArgs e)
        {
            
        }

        private void lbVert_Click(object sender, EventArgs e)
        {

        }

        private void lbBleu_Click(object sender, EventArgs e)
        {

        }
    }
}
