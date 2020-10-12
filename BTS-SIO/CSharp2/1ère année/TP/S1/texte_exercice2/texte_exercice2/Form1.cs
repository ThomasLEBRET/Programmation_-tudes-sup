using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace texte_exercice2
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

        private void lbTexte_Click(object sender, EventArgs e)
        {

        }

        private void cbISouligne_CheckedChanged(object sender, EventArgs e)
        {
            if (cbISouligne.Checked == true)
            {
                lbTexte.Font = new Font(lbTexte.Font, lbTexte.Font.Style | FontStyle.Underline); //desactiver
            }
            else
            {
                lbTexte.Font = new Font(lbTexte.Font, lbTexte.Font.Style ^ FontStyle.Underline); //desactiver
            }
        }

        private void cbGras_CheckedChanged(object sender, EventArgs e)
        {
            if (cbGras.Checked == true)
            {
                lbTexte.Font = new Font(lbTexte.Font, lbTexte.Font.Style | FontStyle.Bold); //desactiver
            }
            else
            {
                lbTexte.Font = new Font(lbTexte.Font, lbTexte.Font.Style ^ FontStyle.Bold); //desactiver
            }
        }

        private void cbItalique_CheckedChanged(object sender, EventArgs e)
        {
            if (cbItalique.Checked == true)
            {
                lbTexte.Font = new Font(lbTexte.Font, lbTexte.Font.Style | FontStyle.Italic); //desactiver
            }
            else
            {
                lbTexte.Font = new Font(lbTexte.Font, lbTexte.Font.Style ^ FontStyle.Italic); //desactiver
            }
        }
    }
}
