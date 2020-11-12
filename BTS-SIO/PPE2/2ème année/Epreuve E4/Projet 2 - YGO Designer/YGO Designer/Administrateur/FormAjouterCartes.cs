using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YGO_Designer.Classes.Carte;
using YGO_Designer.Classes.Carte.Attribut_Carte;
using YGO_Designer.Classes.Effet;
using YGO_Designer.Classes.Monstre.Attribut_Monstre;
using YGO_Designer.Classes.ORM;

namespace YGO_Designer
{
    public partial class FormAjouterCartes : Form
    {
        public FormAjouterCartes()
        {
            InitializeComponent();

            ORMDatabase.Connexion();
            clbEffets.Items.AddRange(ORMEffet.GetEffetsCartes().ToArray());
            cbTypeCarte.DataSource = ORMAttributCarte.GetAttributsCartes();

            cbAttribMon.DataSource = ORMAttributMonstre.GetAttribMonstre();
            cbTypeMon.DataSource = ORMTypeMonstre.GetTypeMonstre();
            cbNbrEtoiles.DataSource = ORMMonstre.GetNbrEtoiles();
        }

        private void btAddMonstre_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty((string)cbTypeCarte.SelectedItem.ToString()) && !string.IsNullOrEmpty(tbNomCarte.Text) && !string.IsNullOrEmpty(tbNoCarte.Text) && tbNoCarte.Text.Length == 8)
            {
                int noC = Convert.ToInt32(tbNoCarte.Text);
                AttributCarte attrCarte = (AttributCarte)cbTypeCarte.SelectedItem;
                string nom = tbNomCarte.Text;
                string description = rtbDescriptCarte.Text;

                Carte c = new Carte(noC, (AttributCarte)cbTypeCarte.SelectedItem, nom, description);

                if (!string.IsNullOrEmpty(tbAtkMo.Text) && !string.IsNullOrEmpty(tbDefMo.Text))
                {
                    TypeMonstre typeM = (TypeMonstre)cbTypeMon.SelectedItem;
                    AttributMonstre attrM = (AttributMonstre)cbAttribMon.SelectedItem;
                    int nbEtoiles = (int)cbNbrEtoiles.SelectedItem;
                    int atk = Convert.ToInt16(tbAtkMo.Text);
                    int def = Convert.ToInt16(tbDefMo.Text);

                    List<Effet> lE = new List<Effet>();
                    foreach (Effet eff in clbEffets.CheckedItems)
                        lE.Add(eff);

                    Monstre m = new Monstre(typeM, noC, attrM, nbEtoiles, atk, def, attrCarte, nom, description);
                    if(ORMMonstre.AjouterMonstre(m)) 
                        //Utilisation d'un trigger pour insérer tous les effets du monstre après ajout d'une carte de type monstre 
                        MessageBox.Show(m.ToString() + "a bien été ajouté.");
                    else
                        MessageBox.Show("Le monstre n'a pas pu être ajouté.");
                }
                else 
                {
                    MessageBox.Show("Entrez une valeur d'attaque et de défense valide.");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Entrez des valeurs valides pour la carte à ajouter.");
                return;
            }
        }
    }
}
