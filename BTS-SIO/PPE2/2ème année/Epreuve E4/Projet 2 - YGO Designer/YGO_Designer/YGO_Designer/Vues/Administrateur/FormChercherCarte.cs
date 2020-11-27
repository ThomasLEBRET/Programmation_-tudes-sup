using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using YGO_Designer.Classes;
using YGO_Designer.Classes.Carte;
using YGO_Designer.Classes.Carte.Attribut_Carte;
using YGO_Designer.Classes.Carte.TypeCarte;
using YGO_Designer.Classes.ORM;
using YGO_Designer.Classes.User;
using YGO_Designer.Classes.Deck;
using YGO_Designer.Vues.Joueur;

namespace YGO_Designer
{
    /// <summary>
    /// Formulaire de recherche d'une carte
    /// </summary>
    public partial class FormChercherCarte : Form
    {
        /// <summary>
        /// Affiche certaines informations en fonction du type d'utilisateur accédant à ce formulaire
        /// </summary>
        public FormChercherCarte()
        {
            InitializeComponent();

            HideCard();

            if (User.GetTypeuser() != null && User.GetTypeuser() == "ADM")
            {
                btDelete.BackColor = Color.Red;
                btDelete.Text = "Supprimer";
                gbDecks.Visible = false;
            }
            else
            {
                btDelete.BackColor = Color.Green;
                btDelete.Text = "Ajouter au deck";
                lbDecks.Visible = true;
                btDelete.Enabled = true;
            }

            lbDecks.Items.AddRange(ORMDeck.GetByUser().ToArray());
        }

        private void HideCard()
        {
            foreach (Control c in paCarte.Controls)
                c.Hide();
        }

        /// <summary>
        /// Procédure privée affichant une représentation virtuelle d'une carte de type Monstre
        /// </summary>
        /// <param name="mo">Une carte de type Monstre</param>
        private void DisplayMonster(Monstre mo)
        {
            pbNv.Show();
            lbNv.Text = mo.GetNiveau().ToString();
            lbNv.Show();
            string st = mo.GetAttribut().ToLower() + ".png";
            int index = ilAttrib.Images.IndexOfKey(st);
            pbAttr.Image = ilAttrib.Images[index];
            pbAttr.Show();
            rtbNom.Text = mo.GetNom();
            rtbNom.Show();
            string typeMoCa = mo.GetSousTypes();
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

        /// <summary>
        /// Procédure privée affichant une représentation virtuelle d'une carte de type Magie
        /// </summary>
        /// <param name="ma">Une carte de type Magie</param>
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

                st = ma.GetNomType() + ".png";
                index = ilAttrib.Images.IndexOfKey(st);
                pbTypeMP.Image = ilAttrib.Images[index];
                pbTypeMP.Show();
            
        }

        /// <summary>
        /// Procédure privée affichant une représentation virtuelle d'une carte de type Piege
        /// </summary>
        /// <param name="pi">Une carte de type Piege</param>
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

        /// <summary>
        /// Procédure privée affichant une représentation virtuelle d'une carte 
        /// </summary>
        /// <param name="c">Une carte de type Carte</param>
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

        /// <summary>
        /// Contrôle si une carte peut être recherchée par son numéro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btChercherParNum_Click(object sender, EventArgs e)
        {
            int noC = 0;
            if (!string.IsNullOrEmpty(tbNoCarte.Text) && tbNoCarte.Text.Length == 8 && int.TryParse(tbNoCarte.Text, out noC))
            {
                Carte c = ORMCarte.GetByNo(Convert.ToInt32(tbNoCarte.Text));
                lbCartes.Items.Clear();
                lbCartes.Items.Add(c);
                if (lbCartes.Items.Count > 0)
                    lbCartes.SelectedItem = lbCartes.Items[0];
            }
            else
                Notification.ShowFormAlert("Entrez un numéro valide svp");
        }

        /// <summary>
        /// Affiche la carte sélectionnée dans la ListBox de résultat
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbCartes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Carte c = (Carte)lbCartes.SelectedItem;
            DisplayCard(c);
        }

        /// <summary>
        /// Tente de rechercher une carte en fonction du contenu saisie dans la TextBox de recherche de carte par nom partiel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbNomCarte_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbNomCarte.Text))
            {
                Task<List<Carte>> lC = Task.Run(() => ORMCarte.GetByPartialName(tbNomCarte.Text));
                lbCartes.Items.Clear();
                lbCartes.Items.AddRange(lC.Result.ToArray());
                if (lbCartes.Items.Count > 0)
                    lbCartes.SelectedItem = lbCartes.Items[0];
            }
        }

        /// <summary>
        /// Supprime une carte si l'utilisateur est un administrateur, sinon l'ajoute à un deck pour un joueur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btDelete_Click(object sender, EventArgs e)
        {
            if (User.GetTypeuser() == "ADM")
                Delete();
            else
                AddToDeck();
        }

        /// <summary>
        /// Tente d'ajouter une carte à un deck pour un joueur
        /// </summary>
        private void AddToDeck()
        {
            if (lbCartes.SelectedIndex < 0 || lbDecks.SelectedIndex < 0)
                Notification.ShowFormAlert("Sélectionnez le deck dans lequel ajouter la carte et/ou une carte recherchée");
            Carte c = (Carte)lbCartes.SelectedItem;
            Deck d = (Deck)lbDecks.SelectedItem;
            if (ORMDeck.AddCard(c.GetNo(), d.GetNo()))
            {
                Notification.ShowFormSuccess("La carte " + c.GetNom() + " a bien été ajoutée dans ce deck");

                lbDecks.Items.Clear();
                lbDecks.Items.AddRange(ORMDeck.GetByUser().ToArray());
            }
            else
                Notification.ShowFormDanger("L'ajout de cette carte a échouée");
            
        }

        /// <summary>
        /// Tente de supprimer une carte de la base de données lorsqu'un administrateur accède à ce formulaire et clique sur le bouton
        /// </summary>
        private void Delete()
        {
            if (lbCartes.SelectedIndex < 0)
                return;
            Carte c = (Carte)lbCartes.SelectedItem;
            if (ORMCarte.Delete(c))
            {
                Notification.ShowFormInfo("La carte " + c.GetNom() + " a bien été supprimée ainsi que tous ses effets");
                lbCartes.Items.Clear();
                tbNoCarte.Text = "";
                tbNomCarte.Text = "";
            }
            else
                Notification.ShowFormDanger("La carte " + c.GetNom() + " n'a pas pu être supprimée");
        }

        /// <summary>
        /// Rend le bouton enabled quand un deck est sélectionné
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbDecks_SelectedIndexChanged(object sender, EventArgs e)
        {
            btDelete.Enabled = true;
        }

        /// <summary>
        /// Quand le formulaire est visible, charge la liste des decks de l'utilisateur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormChercherCarte_VisibleChanged(object sender, EventArgs e)
        {
            lbDecks.Items.Clear();
            lbDecks.Items.AddRange(ORMDeck.GetByUser().ToArray());
        }
    }
}
