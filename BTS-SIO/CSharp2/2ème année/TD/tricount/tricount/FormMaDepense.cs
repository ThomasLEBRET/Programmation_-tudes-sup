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
    public partial class FormMaDepense : Form
    {
        public FormMaDepense()
        {
            InitializeComponent();
            this.Text = DonneesPubliques.GetUneDepense().GetTitre();
            lbDate.Text = DonneesPubliques.GetUneDepense().GetDate().ToString("d");
            DonneesPubliques.GetMonTricount().AfficherParticipants(ref lbParticipants);
            DonneesPubliques.GetMonTricount().AfficherPayeur(ref lbPayeur);
            lbFinanceur.Text = "Payeur actuel : " + DonneesPubliques.GetUneDepense().GetLePayeur().GetName();
            DonneesPubliques.GetUneDepense().CalculerBalanceDuneDepense(ref lbConcerne);
        }

        private void btRetour_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormTricount ft = new FormTricount();
            ft.Show();
        }

        private void btValider_Click(object sender, EventArgs e)
        {
            string titre = tbTitre.Text;
            float somme = Convert.ToSingle(tbSomme.Text);

            List<Participant> concernes = new List<Participant>();
            Participant payeur = new Participant("unknow");
            Participant lesParticipantsConcernes = new Participant("unknow");

            RadioButton rb;
            CheckBox cb;

            for (int i = 0; i < lbPayeur.Items.Count; i++)
            {
                if (lbPayeur.Items[i] is RadioButton)
                {
                    rb = (RadioButton)lbPayeur.Items[i];
                    if (rb.Checked)
                        payeur = (Participant)rb.Tag;
                }
            }

            for (int i = 0; i < lbParticipants.Items.Count; i++)
            {
                if (lbParticipants.Items[i] is CheckBox)
                {
                    cb = (CheckBox)lbParticipants.Items[i];
                    if (cb.Checked)
                    {
                        lesParticipantsConcernes = (Participant)cb.Tag;
                        concernes.Add(lesParticipantsConcernes);
                    }
                }
            }

            Depense d = new Depense(titre, somme, concernes, payeur);
            DonneesPubliques.GetMonTricount().GetListeDepenses().Add(d);
            DonneesPubliques.GetMonTricount().GetListeDepenses().Remove(DonneesPubliques.GetUneDepense());
            DonneesPubliques.SetUneDepense(d);
            //payeur.ActualiserDepense(d, ref lbConcerne);

            this.Hide();
            FormTricount ft = new FormTricount();
            ft.Show();
        }
    }
}
