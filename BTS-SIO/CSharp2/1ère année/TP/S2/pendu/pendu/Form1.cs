using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace pendu
{
    public partial class Form1 : Form
    {
        Pendu partie;
        public Form1()
        {
            InitializeComponent();
        }

        private void btQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            partie = new Pendu();
            lbMot.Text = partie.ToString();
        }

        private void tbLettre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btLettre_Click(object sender, EventArgs e)
        {
            char lettre = Convert.ToChar(tbLettre.Text.Substring(0,1).ToLower());
            if (partie.PlaceLettre(lettre))
            {
                MessageBox.Show("La lettre " + lettre + " apparait " + partie.GetNbrLettres() + " fois");
                if (partie.IsMotValide())
                    MessageBox.Show("Bravo, vous avez trouvé le mot");
            }
            else
                MessageBox.Show("La lettre n'est pas dans le mot !");
            lbMot.Text = partie.ToString();
        }

        private void lbMot_Click(object sender, EventArgs e)
        {

        }
    }
}
