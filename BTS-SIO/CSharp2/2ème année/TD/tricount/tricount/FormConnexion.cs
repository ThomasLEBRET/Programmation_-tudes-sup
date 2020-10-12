using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace tricount
{
    public partial class FormConnexion : Form
    {
        public FormConnexion()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btValiderUser_Click(object sender, EventArgs e)
        {
            if (tbUser.Text.Length > 0)
            {
                DonneesPubliques.SetParticipantMoi(new Participant(tbUser.Text));
                this.Hide();
                FormListeTricount flt = new FormListeTricount();
                flt.Show();
            }
            else
                MessageBox.Show("Vous n'avez pas rentré de nom !");
        }
    }
}
