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
using YGO_Designer.Classes.User;

namespace YGO_Designer
{
    public partial class FormChercherCarte : Form
    {
        public FormChercherCarte()
        {
            InitializeComponent();

            HideCard();

            if (User.GetTypeuser() != null && User.GetTypeuser() == "ADM")
            {
                if (!btDelete.Enabled && !btDelete.Visible)
                {
                    btDelete.Enabled = true;
                    btDelete.Visible = true;
                }
            }
        }

        private void HideCard()
        {
            foreach (Control c in paCarte.Controls)
                c.Hide();
        }

        private void DisplayMonster(Monstre mo)
        {
            pbNv.Show();
            lbNv.Text = mo.GetNivMonstre().ToString();
            lbNv.Show();
            string st = mo.GetAttrMonstre().ToLower() + ".png";
            int index = ilAttrib.Images.IndexOfKey(st);
            pbAttr.Image = ilAttrib.Images[index];
            pbAttr.Show();
            rtbNom.Text = mo.GetNom();
            rtbNom.Show();
            string typeMoCa = mo.GetTypesCarteMonstre();
            if (mo.GetListEffets().Count() != 0)
                typeMoCa = typeMoCa + "/Effet";
            rtbDescription.Text = typeMoCa + "\n";
            rtbDescription.SelectionStart = rtbDescription.Text.Length;
            rtbDescription.SelectionFont = new Font("Candara", 14, FontStyle.Regular);
            rtbDescription.AppendText(mo.GetDescription());
            rtbDescription.BackColor = Color.BurlyWood;
            rtbDescription.Show();
            lbAtk.Text = "ATK/" + mo.GetAtk().ToString();
            lbAtk.Show();
            lbDef.Text = "DEF/" + mo.GetDef().ToString();
            lbDef.Show();
        }

        private void DisplaySpell(Magie ma)
        {
            Color colorMa = new Color();
            colorMa = Color.FromArgb(47, 134, 113);
            paCarte.BackColor = colorMa;
            rtbNom.Text = ma.GetNom();
            rtbDescription.Text = ma.GetDescription();
            rtbNom.Show();
            rtbDescription.BackColor = Color.PaleGreen;
            rtbDescription.Show();
            lbMaPi.Text = "[CARTE MAGIE]";
            lbMaPi.Show();

            string st = ma.GetAttr().GetNomAttrCarte().ToLower() + ".png";
            int index = ilAttrib.Images.IndexOfKey(st);
            pbAttr.Image = ilAttrib.Images[index];
            pbAttr.Show();

                st = ma.GetNomTypeMa() + ".png";
                index = ilAttrib.Images.IndexOfKey(st);
                pbTypeMP.Image = ilAttrib.Images[index];
                pbTypeMP.Show();
            
        }

        private void DisplayTrap(Piege pi)
        {
            Color colorPi = new Color();
            colorPi = Color.FromArgb(133, 47, 90);
            paCarte.BackColor = colorPi;

            rtbNom.Text = pi.GetNom();
            rtbDescription.Text = pi.GetDescription();
            rtbNom.Show();
            rtbDescription.BackColor = Color.MistyRose;
            rtbDescription.Show();
            lbMaPi.Text = "[CARTE PIEGE]";
            lbMaPi.Show();
            string st = "piege.png";
            int index = ilAttrib.Images.IndexOfKey(st);
            pbAttr.Image = ilAttrib.Images[index];
            pbAttr.Show();

            
                st = pi.GetNomTypePi() + ".png";
                index = ilAttrib.Images.IndexOfKey(st);
                pbTypeMP.Image = ilAttrib.Images[index];
                pbTypeMP.Show();
        }

        private void DisplayCard(Carte c)
        {
            HideCard();
            rtbNom.Text = c.GetNom();
            rtbDescription.Text = c.GetDescription();
            switch (c.GetAttr().GetCdAttrCarte())
            {
                case "MON":
                    paCarte.BackColor = Color.Sienna;
                    DisplayMonster((Monstre)c);
                    break;
                case "MAG":
                    paCarte.BackColor = Color.Green;
                    DisplaySpell((Magie)c);
                    break;
                case "PIE":
                    paCarte.BackColor = Color.Crimson;
                    DisplayTrap((Piege)c);
                    break;
            }
        }
        private void btChercherParNum_Click(object sender, EventArgs e)
        {
            int noC = 0;
            if(!string.IsNullOrEmpty(tbNoCarte.Text) && tbNoCarte.Text.Length == 8 && int.TryParse(tbNoCarte.Text, out noC))
            {
                Carte c = ORMCarte.GetCarteByNo(Convert.ToInt32(tbNoCarte.Text));
                lbCartes.Items.Clear();
                lbCartes.Items.Add(c);
                if (lbCartes.Items.Count > 0)
                    lbCartes.SelectedItem = lbCartes.Items[0];
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

        private void tbNomCarte_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbNomCarte.Text))
            {
                List<Carte> lC = ORMCarte.GetCarteByPartialName(tbNomCarte.Text);
                lbCartes.Items.Clear();
                lbCartes.Items.AddRange(lC.ToArray());
                if (lbCartes.Items.Count > 0)
                    lbCartes.SelectedItem = lbCartes.Items[0];
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (lbCartes.SelectedIndex < 0)
                return;
            Carte c = (Carte)lbCartes.SelectedItem;
            if (ORMCarte.DeleteCard(c))
            {
                MessageBox.Show("La carte " + c.GetNom() + " a bien été supprimée ainsi que tous ses effets");
                lbCartes.Items.Clear();
                tbNoCarte.Text = "";
                tbNomCarte.Text = "";
            }
            else
                MessageBox.Show("La carte " + c.GetNom() + " n'a pas pu être supprimée");
        }
    }
}
