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
using YGO_Designer.Classes.ORM;

namespace YGO_Designer
{
    public partial class FormAjouterCartes : Form
    {
        public FormAjouterCartes()
        {
            InitializeComponent();

            ORMDatabase.Connexion();
            cbTypeCarte.DataSource = ORMCarte.GetAttributs();

            foreach (Effet e in ORMCarte.GetEffets())
                clbEffets.Items.Add(e);

            cbAttribMon.DataSource = Enum.GetValues(typeof(AttributMonstre));
            cbTypeMon.DataSource = Enum.GetValues(typeof(TypeMonstre));
        }

        private void btAddMonstre_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty((string)cbTypeCarte.SelectedItem.ToString()) && !string.IsNullOrEmpty(tbNomCarte.Text) && !string.IsNullOrEmpty(tbNoCarte.Text) && tbNoCarte.Text.Length == 8)
            {
                int noC = Convert.ToInt32(tbNoCarte.Text);
                Attribut attrCarte =  (Attribut)cbTypeCarte.SelectedItem;
                string nom = tbNomCarte.Text;
                string description = rtbDescriptCarte.Text;
                List<Effet> lE = new List<Effet>();
                foreach (Effet eff in clbEffets.CheckedItems)
                    lE.Add(eff);

                Carte c = new Carte(lE, noC, attrCarte, nom, description);
                if(!ORMCarte.ExistCard(c))
                {
                    if (!string.IsNullOrEmpty(tbAtkMo.Text) && !string.IsNullOrEmpty(tbDefMo.Text))
                    {
                        string typeM = TypeMonstre.GetName(typeof(TypeMonstre), (TypeMonstre)cbTypeMon.SelectedItem);
                        string attrM = AttributMonstre.GetName(typeof(AttributMonstre), (AttributMonstre)cbAttribMon.SelectedItem);
                        int nbEtoiles = Convert.ToInt32((string)cbNbrEtoiles.SelectedItem);
                        if (nbEtoiles == 0)
                            nbEtoiles++;
                        int atk = Convert.ToInt16(tbAtkMo.Text);
                        int def = Convert.ToInt16(tbDefMo.Text);


                        Monstre m = new Monstre(typeM, attrM, nbEtoiles, atk, def, lE, noC, attrCarte, nom, description);
                        if (ORMMonstre.AjouterMonstre(m))
                        {
                            MessageBox.Show(m.ToString() + " a bien été ajouté.");
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
    }
}
