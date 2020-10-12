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
    public partial class FormTricount : Form
    {

        public FormTricount()
        {
            InitializeComponent();
            DonneesPubliques.GetMonTricount().AfficherParticipants(ref lbParticipants);
            DonneesPubliques.GetMonTricount().AfficherPayeur(ref lbPayeur);
            lbDepense = MesOutils.ActualiserListBox(lbDepense);
        }

        private void btQuitter_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormListeTricount flt = new FormListeTricount();
            flt.Show();
        }

        private void lbDepense_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indDepense = Convert.ToInt16(lbDepense.SelectedIndex);
            if (indDepense > -1)
            {
                DonneesPubliques.SetUneDepense(DonneesPubliques.GetMonTricount().GetListeDepenses()[indDepense]);
                this.Hide();
                FormMaDepense fmd = new FormMaDepense();
                fmd.Show();
            }
        }

        private void lbParticipants_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        private void lbPayeur_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btPayer_Click(object sender, EventArgs e)
        {
            RadioButton rb;
            CheckBox cb;
            List<Participant> concernes = new List<Participant>();
            Participant payeur = new Participant("unknow");
            Participant p = new Participant("unknow");

            //Payeur
            for (int i = 0; i < lbPayeur.Items.Count; i++)
            {
                if (lbPayeur.Items[i] is RadioButton)
                {
                    rb = (RadioButton)lbPayeur.Items[i];
                    if (rb.Checked)
                        payeur = (Participant)rb.Tag;
                }
            }

            //Participant
            for (int i = 0; i < lbParticipants.Items.Count; i++)
            {
                if (lbParticipants.Items[i] is CheckBox)
                {
                    cb = (CheckBox)lbParticipants.Items[i];
                    if (cb.Checked)
                    {
                        p = (Participant)cb.Tag;
                        concernes.Add(p);
                    }
                }
            }

            float somme = Convert.ToSingle(tbSomme.Text);

            if(tbSomme.Text != "" || tbTitre.Text != "")
            {
                Depense d = new Depense(tbTitre.Text, somme, concernes, payeur);
                if (!d.GetConcerne().Contains(payeur))
                    payeur.AjouterDepense(d);
                else
                {
                    foreach (Participant pa in concernes)
                        pa.AjouterDepense(d);
                }
                DonneesPubliques.GetMonTricount().GetListeDepenses().Add(d);
                lbDepense = MesOutils.ActualiserListBox(lbDepense);
                DonneesPubliques.SetUneDepense(d);
            }
            else 
            {
                MessageBox.Show("Entrez une somme et un titre svp.");
            }
        }

        private void btSupprimerTricount_Click(object sender, EventArgs e)
        {
            DonneesPubliques.SupprimerTricount(DonneesPubliques.GetMonTricount());
            this.Hide();
            FormListeTricount flt = new FormListeTricount();
            flt.Show();
        }

        private void btAddParticipant_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAddParticipant fap = new FormAddParticipant();
            fap.Show();
        }

        private void btSupprimerParticipant_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormSuppParticipant fsp = new FormSuppParticipant();
            fsp.Show(); 
             
        }

        private void btBalances_Click(object sender, EventArgs e)
        {
            List<Participant> listePayeurs = new List<Participant>();
            List<Participant> listeRembourse = new List<Participant>();
            lbRemboursement.Items.Clear();
            lbRembourse.Items.Clear();
            DonneesPubliques.GetMonTricount().GetListeParticipants().Sort();
            string estPayeur = "";
            foreach (Participant p in DonneesPubliques.GetMonTricount().GetListeParticipants())
            {
                if (p.GetBalance() > 0)
                {
                    estPayeur = "payeur";
                    listePayeurs.Add(p);
                    lbRemboursement.Items.Add(p.GetName() + " (" + estPayeur + ")" + " : balance => " + p.GetBalance() + " : coût total => " + p.GetMonCoutTotal());
                }
                else if (p.GetBalance() < 0)
                {
                    estPayeur = "rembourse";
                    listeRembourse.Add(p);
                    lbRemboursement.Items.Add(p.GetName() + " (" + estPayeur + ")" + " : balance => " + p.GetBalance() + " : coût total => " + p.GetMonCoutTotal());
                }
            }
            DonneesPubliques.GetMonTricount().EffectueLesRemboursements(listePayeurs, listeRembourse, ref lbRembourse);
        }

        private void lbRemboursement_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
