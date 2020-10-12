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
    public partial class FormListeTricount : Form
    {
        public FormListeTricount()
        {
            InitializeComponent();
            lbName.Text = DonneesPubliques.GetParticipantMoi().GetName();
        }

        private void btQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormListeTricount_Load(object sender, EventArgs e)
        {
            DonneesPubliques.AfficherTricount(ref lbTricount);
        }

        private void lbTricount_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indTricount = Convert.ToInt16(lbTricount.SelectedIndex);
            if (indTricount > -1)
            {
                DonneesPubliques.SetMonTricount(DonneesPubliques.GetMesTricounts()[indTricount]);
                FormTricount ft = new FormTricount();
                ft.Show();
            }
        }

        private void btAjouter_Click(object sender, EventArgs e)
        {
            if(tbNomTricount.Text.Length == 0 || tbMesParticipants.Text.Length == 0)
                MessageBox.Show("Entrez un nom de Tricount et un participant au minimum svp.");
            else
            {
                string nomTricount = tbNomTricount.Text;
                string nomParticipant = tbMesParticipants.Text;

                Participant invite = new Participant(nomParticipant);
                Tricount ceTricount = new Tricount(nomTricount, DonneesPubliques.GetParticipantMoi());
                ceTricount.AjouterParticipants(invite);
                if(DonneesPubliques.GetMesTricounts() == null)
                    DonneesPubliques.SetMaListeTricounts(new List<Tricount>());
                DonneesPubliques.AjouterTricount(ceTricount);
                DonneesPubliques.AfficherTricount(ref lbTricount);
            }
        }
    }
}
