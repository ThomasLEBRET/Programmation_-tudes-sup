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
    public partial class FormAddParticipant : Form
    {
        public FormAddParticipant()
        {
            InitializeComponent();
        }

        private void btRetour_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormTricount ft = new FormTricount();
            ft.Show();
        }

        private void btValider_Click(object sender, EventArgs e)
        {
            string name = tbNomParticipant.Text;
            Participant p = new Participant(name);
            DonneesPubliques.GetMonTricount().AjouterParticipants(p);
            tbNomParticipant.Clear();
            MessageBox.Show("Le participant : " + name + " a été ajouté à votre Tricount.");
        }
    }
}
