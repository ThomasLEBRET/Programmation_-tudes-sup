using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YGO_Designer.Classes;
using YGO_Designer.Classes.Carte;
using YGO_Designer.Classes.Carte.Attribut_Carte;
using YGO_Designer.Classes.Carte.TypeCarte;
using YGO_Designer.Classes.ORM;

namespace YGO_Designer
{
    public partial class FormChercherCarte : Form
    {
        public FormChercherCarte()
        {
            InitializeComponent();
        }

        private void DisplayCard(Carte c)
        {
            lbNom.Text = c.GetNom();
            lbDescription.Text = c.GetDescription();
            switch (c.GetAttr().GetCdAttrCarte())
            {
                case "MON":
                    paCarte.BackColor = Color.Sienna;
                    break;
                case "MAG":
                    paCarte.BackColor = Color.Green;
                    break;
                case "PIE":
                    paCarte.BackColor = Color.Crimson;
                    break;
            }
        }
        private void btChercherParNum_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(tbNoCarte.Text) && tbNoCarte.Text.Length == 8)
            {
                Carte c = ORMCarte.GetCarte(Convert.ToInt32(tbNoCarte.Text));
                lbCartes.Items.Clear();
                lbCartes.Items.Add(c);
            }
            else
            {
                MessageBox.Show("Entrez un numéro valide svp");
                return;
            }
        }

        private void lbCartes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Carte c = (Carte)lbCartes.SelectedItem;
            DisplayCard(c);
        }
    }
}
