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
    /// <summary>
    /// Formulaire d'ajout d'une carte
    /// </summary>
    public partial class FormAjouterCartes : Form
    {
        /// <summary>
        /// Charge le thème et les valeurs par défaut
        /// </summary>
        public FormAjouterCartes()
        {
            InitializeComponent();

            Theme.Add(this, Color.FromArgb(167, 103, 38), Color.FromArgb(187, 174, 152));
            Theme.AddTabControl(tbContainCarte, Color.FromArgb(187, 174, 152), Color.FromArgb(187, 174, 152));

            ORMDatabase.Connexion();

            foreach (Effet e in ORMCarte.GetEffets())
                clbEffets.Items.Add(e);

            cbAttribMon.DataSource = Enum.GetValues(typeof(AttributMonstre));
            cbTypeMon.DataSource = Enum.GetValues(typeof(TypeMonstre));
            cbNbrEtoiles.DataSource = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            clbTypeCarteMonstre.DataSource = Enum.GetValues(typeof(TypeCarteMonstre));
        }

        /// <summary>
        /// Méthode privée contrôlant si les champs sont remplis pour une carte
        /// </summary>
        /// <returns>Un booléen : true si le contrôle de données est réussi, false sinon</returns>
        private bool EstCarteValide()
        {
            if (!string.IsNullOrEmpty(tbNomCarte.Text) && !string.IsNullOrEmpty(tbNoCarte.Text) && tbNoCarte.Text.Length == 8)
                return true;
            return false;
        }

        /// <summary>
        /// Méthode privée créant une carte à partir des zones de saisie du formulaire
        /// </summary>
        /// <param name="attrCarte">L'attribut de la carte préalablement construit</param>
        /// <returns>Un objet de type Carte</returns>
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

        /// <summary>
        /// Procédure privée du formulaire contrôlant si un monstre peut être ajouté à la base de données
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btAddMonstre_Click(object sender, EventArgs e)
        {
            if (EstCarteValide())
            {
                Attribut attrCarte = new Attribut("MON", "Monstre");
                Carte c = CreeCarte(attrCarte);
                if(!ORMCarte.Exist(c))
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

                        if (typesCarteMonstre.Length != 0)
                            typesCarteMonstre = typesCarteMonstre.Substring(0, typesCarteMonstre.Length - 1);


                        c = new Monstre(typeM, attrM, nbEtoiles, atk, def, typesCarteMonstre, c.GetListEffets(), c.GetNo(), attrCarte, c.GetNom(), c.GetDescription());
                        if (ORMMonstre.Add((Monstre)c))
                            Notification.ShowFormSuccess(c.ToString() + " a bien été ajoutée");
                        else
                            Notification.ShowFormAlert("Le monstre n'a pas pu être ajouté");
                    }
                    else
                        Notification.ShowFormAlert("Entrez une valeur d'attaque et de défense valide");
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

        /// <summary>
        /// Procédure privée du formulaire contrôlant si une magie peut être ajouté à la base de données
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btAddMagie_Click(object sender, EventArgs e)
        {
            if (EstCarteValide())
            {
                Attribut attrCarte = new Attribut("MAG", "Magie");
                Carte magie = CreeCarte(attrCarte);
                if(!ORMCarte.Exist(magie))
                {
                    string typeMagie = "";
                    foreach (RadioButton rb in gbTypeMagie.Controls)
                    {
                        if (rb.Checked)
                            typeMagie = rb.Text;
                    }
                    magie = new Magie(magie.GetListEffets(), magie.GetNo(), magie.GetAttr(), magie.GetNom(), magie.GetDescription(), typeMagie);
                    
                    if (ORMMagie.Add((Magie)magie))
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

        /// <summary>
        /// Procédure privée du formulaire contrôlant si un piège peut être ajouté à la base de données
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btAddPiege_Click(object sender, EventArgs e)
        {
            if (EstCarteValide())
            {
                Attribut attrCarte = new Attribut("PIE", "Piège");
                Carte piege = CreeCarte(attrCarte);
                if (!ORMCarte.Exist(piege))
                {
                    string typePiege = "";
                    foreach (RadioButton rb in gbTypePiege.Controls)
                    {
                        if (rb.Checked)
                            typePiege = rb.Text;
                    }
                    piege = new Piege(piege.GetListEffets(), piege.GetNo(), piege.GetAttr(), piege.GetNom(), piege.GetDescription(), typePiege);

                    if (ORMPiege.Add((Piege)piege))
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

        /// <summary>
        /// Procédure privée du formulaire changeant le thème en fonction du Tab sélectionné depuis le TabControl
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbContainCarte_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tbContainCarte.SelectedTab.Text)
            {
                case "Monstre":
                    Theme.Add(this, Color.FromArgb(167, 103, 38), Color.FromArgb(187, 174, 152));
                    Theme.AddTabControl(tbContainCarte, Color.FromArgb(187, 174, 152), Color.FromArgb(187, 174, 152));
                    break;
                case "Magie":
                    Theme.Add(this, Color.FromArgb(64, 130, 109), Color.FromArgb(151, 223, 198));
                    Theme.AddTabControl(tbContainCarte, Color.FromArgb(151, 223, 198), Color.FromArgb(151, 223, 198));
                    break;
                case "Piège":
                    Theme.Add(this, Color.FromArgb(204, 78, 92), Color.FromArgb(253, 223, 224));
                    Theme.AddTabControl(tbContainCarte, Color.FromArgb(253, 223, 224), Color.FromArgb(253, 223, 224));
                    break;

            }
        }
    }
}
