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
using YGO_Designer.Vues.Joueur;

namespace YGO_Designer
{
    public partial class FormAjouterCartes : Form
    {
        public FormAjouterCartes()
        {
            InitializeComponent();

            Theme.AjouterCarte(this, Color.FromArgb(167, 103, 38), Color.FromArgb(187, 174, 152));
            Theme.AjouterCarteTabControl(tbContainCarte, Color.FromArgb(187, 174, 152), Color.FromArgb(187, 174, 152));

            ORMDatabase.Connexion();

            foreach (Effet e in ORMCarte.GetEffets())
                clbEffets.Items.Add(e);

            cbAttribMon.DataSource = Enum.GetValues(typeof(AttributMonstre));
            cbTypeMon.DataSource = Enum.GetValues(typeof(TypeMonstre));
            cbNbrEtoiles.DataSource = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            clbTypeCarteMonstre.DataSource = Enum.GetValues(typeof(TypeCarteMonstre));
        }

        private bool EstCarteValide()
        {
            if (!string.IsNullOrEmpty(tbNomCarte.Text) && !string.IsNullOrEmpty(tbNoCarte.Text) && tbNoCarte.Text.Length == 8)
                return true;
            return false;
        }

        private Carte CreeCarte(Attribut attrCarte)
        {
            int noC = Convert.ToInt32(tbNoCarte.Text);
            string nom = tbNomCarte.Text;
            string description = rtbDescriptCarte.Text;
            List<Effet> lE = new List<Effet>();
            foreach (Effet eff in clbEffets.CheckedItems)
                lE.Add(eff);
            return new Carte(lE, noC, attrCarte, nom, description);
        }

        private void btAddMonstre_Click(object sender, EventArgs e)
        {
            if (EstCarteValide())
            {
                Attribut attrCarte = new Attribut("MON", "Monstre");
                Carte c = CreeCarte(attrCarte);
                if(!ORMCarte.ExistCard(c))
                {
                    if (!string.IsNullOrEmpty(tbAtkMo.Text) && !string.IsNullOrEmpty(tbDefMo.Text))
                    {
                        string typeM = Classes.Carte.Attribut_Carte.TypeMonstre.GetName(typeof(Classes.Carte.Attribut_Carte.TypeMonstre), (Classes.Carte.Attribut_Carte.TypeMonstre)cbTypeMon.SelectedItem);
                        string attrM = AttributMonstre.GetName(typeof(AttributMonstre), (AttributMonstre)cbAttribMon.SelectedItem);
                        int nbEtoiles = Convert.ToInt32(cbNbrEtoiles.SelectedItem.ToString());
                        if (nbEtoiles == 0)
                            nbEtoiles++;
                        int atk = Convert.ToInt16(tbAtkMo.Text);
                        int def = Convert.ToInt16(tbDefMo.Text);
                        string typesCarteMonstre = "";
                        foreach (TypeCarteMonstre tcm in clbTypeCarteMonstre.CheckedItems)
                            typesCarteMonstre = typesCarteMonstre + tcm.ToString() + "/";

                        if(typesCarteMonstre.Length != 0)
                            typesCarteMonstre = typesCarteMonstre.Substring(0, typesCarteMonstre.Length - 1);


                        c = new Monstre(typeM, attrM, nbEtoiles, atk, def, typesCarteMonstre, c.GetListEffets(), c.GetNo(), attrCarte, c.GetNom(), c.GetDescription());
                        if (ORMMonstre.AjouterMonstre((Monstre)c))
                        {
                            FormSuccess fs = new FormSuccess();
                            fs.SetDescription(c.ToString() + " a bien été ajouté.");
                            fs.ShowDialog();
                            return;
                        }
                        else
                        {
                            FormAlert fa = new FormAlert();
                            fa.SetDescription("Le monstre n'a pas pu être ajouté.");
                            fa.ShowDialog();
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Entrez une valeur d'attaque et de défense valide.");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Entrez un numéro de carte non existant dans la base de données.");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Entrez des valeurs valides pour la conception d'une carte");
                return;
            }
        }

        private void btAddMagie_Click(object sender, EventArgs e)
        {
            if (EstCarteValide())
            {
                Attribut attrCarte = new Attribut("MAG", "Magie");
                Carte magie = CreeCarte(attrCarte);
                if(!ORMCarte.ExistCard(magie))
                {
                    string typeMagie = "";
                    foreach (RadioButton rb in gbTypeMagie.Controls)
                    {
                        if (rb.Checked)
                            typeMagie = rb.Text;
                    }
                    magie = new Magie(magie.GetListEffets(), magie.GetNo(), magie.GetAttr(), magie.GetNom(), magie.GetDescription(), typeMagie);
                    
                    if (ORMMagie.AjouterMagie((Magie)magie))
                    {
                        MessageBox.Show(magie.ToString() + " a bien été ajouté.");
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Le monstre n'a pas pu être ajouté.");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("La carte existe déjà");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Entrez des valeurs valides pour la conception d'une carte");
                return;
            }
        }

        private void btAddPiege_Click(object sender, EventArgs e)
        {
            if (EstCarteValide())
            {
                Attribut attrCarte = new Attribut("PIE", "Piège");
                Carte piege = CreeCarte(attrCarte);
                if (!ORMCarte.ExistCard(piege))
                {
                    string typePiege = "";
                    foreach (RadioButton rb in gbTypePiege.Controls)
                    {
                        if (rb.Checked)
                            typePiege = rb.Text;
                    }
                    piege = new Piege(piege.GetListEffets(), piege.GetNo(), piege.GetAttr(), piege.GetNom(), piege.GetDescription(), typePiege);

                    if (ORMPiege.AjouterPiege((Piege)piege))
                    {
                        MessageBox.Show(piege.ToString() + " a bien été ajouté.");
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Le monstre n'a pas pu être ajouté.");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("La carte existe déjà");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Entrez des valeurs valides pour la conception d'une carte");
                return;
            }
        }

        private void tbContainCarte_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tbContainCarte.SelectedTab.Text)
            {
                case "Monstre":
                    Theme.AjouterCarte(this, Color.FromArgb(167, 103, 38), Color.FromArgb(187, 174, 152));
                    Theme.AjouterCarteTabControl(tbContainCarte, Color.FromArgb(187, 174, 152), Color.FromArgb(187, 174, 152));
                    break;
                case "Magie":
                    Theme.AjouterCarte(this, Color.FromArgb(64, 130, 109), Color.FromArgb(151, 223, 198));
                    Theme.AjouterCarteTabControl(tbContainCarte, Color.FromArgb(151, 223, 198), Color.FromArgb(151, 223, 198));
                    break;
                case "Piège":
                    Theme.AjouterCarte(this, Color.FromArgb(204, 78, 92), Color.FromArgb(253, 223, 224));
                    Theme.AjouterCarteTabControl(tbContainCarte, Color.FromArgb(253, 223, 224), Color.FromArgb(253, 223, 224));
                    break;

            }
        }
    }
}
