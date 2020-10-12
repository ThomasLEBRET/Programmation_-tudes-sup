using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace heritage_rectangle
{
    public partial class Form1 : Form
    {
        int longueur = 0;
        int largeur = 0;
        Rectangle r1 = new Rectangle();
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
            longueur = Convert.ToInt16(numLongueur.Value);
            largeur = Convert.ToInt16(numLargeur.Value);
            r1.SetLongueur(longueur);
            r1.SetLargeur(largeur);
            r1.Location = new Point(360, 30);
            r1.Size = new Size(longueur, largeur);
            this.Controls.Add(r1);
        }
    }
}
