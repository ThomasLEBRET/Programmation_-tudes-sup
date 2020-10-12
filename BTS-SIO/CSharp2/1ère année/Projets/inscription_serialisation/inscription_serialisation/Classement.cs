using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace inscription_serialisation
{
    public partial class Classement : Form
    {
        public Classement()
        {
            InitializeComponent();
        }

        private void pbQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu menu = new Menu();
            menu.Show();
        }

        private void Classement_Load(object sender, EventArgs e)
        {
            GroupeEnfants.ClassementParScore(this);
        }
    }
}
