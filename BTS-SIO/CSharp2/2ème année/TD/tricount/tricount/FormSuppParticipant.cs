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
    public partial class FormSuppParticipant : Form
    {
        public FormSuppParticipant()
        {
            InitializeComponent();
            DonneesPubliques.GetMonTricount().AfficherPayeur(ref lbParticipant);
        }

        private void btRetour_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormTricount ft = new FormTricount();
            ft.Show();
        }

        private void btValider_Click(object sender, EventArgs e)
        {
            RadioButton rb;
            for(int i = 0; i < lbParticipant.Items.Count; i++)
            {
                if (lbParticipant.Items[i] is RadioButton)
                {
                    rb = (RadioButton)lbParticipant.Items[i];
                    if(rb.Checked)
                        DonneesPubliques.GetMonTricount().SupprimerParticipant((Participant)rb.Tag);
                    //Actualiser les dépenses
                }
            }
            DonneesPubliques.GetMonTricount().AfficherPayeur(ref lbParticipant);
        }

    }
}
