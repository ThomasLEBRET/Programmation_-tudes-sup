using plat;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TPORM
{
    public partial class Form1 : Form
    {

        private List<Plat> listePlatsModif;
        public Form1()
        {
            InitializeComponent();

            if (ORMPlats.Connexion())
                lbConnexion.Text = "Connection ouverte";
            cbCat.DataSource = ORMPlats.GetCategories();
            cbCategoriePlat.DataSource = Enum.GetValues(typeof(Categorie));
            listePlatsModif = new List<Plat>();
        }

        private void btConnexion_Click(object sender, EventArgs e)
        {
            if (ORMPlats.Connexion())
                lbConnexion.Text = "Connection ouverte";
            else
                lbConnexion.Text = "Connection fermée";
        }

        private void btDeconnexion_Click(object sender, EventArgs e)
        {
            if (ORMPlats.Deconnexion())
                lbConnexion.Text = "Connection fermée";
            else
                MessageBox.Show("La déconnexion a échouée");
        }

        private void btAfficherAllPlats_Click(object sender, EventArgs e)
        {
            List<Plat> lp = ORMPlats.AfficherPlats();
            lbPlats.Items.Clear();
            lbPlats.Items.AddRange(lp.ToArray());
        }

        private void btAjouterPlat_Click(object sender, EventArgs e)
        {
            string nom = tbNom.Text;
            Categorie categorie = (Categorie)cbCat.SelectedItem;
            string prix = tbPrix.Text;
            string cal = tbCal.Text;
            bool vegan = false;
            bool gluten = false;

            if (string.IsNullOrEmpty(nom) || string.IsNullOrEmpty(prix) || string.IsNullOrEmpty(cal))
            {
                MessageBox.Show("Rentrez des informations valides svp");
                return;
            }

            if (cbVegan.Checked)
                vegan = true;

            if (cbGlutenFree.Checked)
                gluten = true;

            Plat p = new Plat(nom, categorie, Convert.ToInt16(prix), Convert.ToInt16(cal), vegan, gluten);
            if (ORMPlats.AjouterPlat(p))
                MessageBox.Show("Votre plat a bien été ajouté !");
            else
                MessageBox.Show("Le plat existe déjà, changez le nom du plat");
        }

        private void btNbrPlats_Click(object sender, EventArgs e)
        {
            int nbPlats = ORMPlats.GetNbPlats();
            if(nbPlats <= 0)
                MessageBox.Show("Votre carte est tristement vide.\n Il n'y a aucun plat.");
            else
                MessageBox.Show("Il y a " + nbPlats + " plats à votre carte.");
        }

        private void btQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btValiderModif_Click(object sender, EventArgs e)
        {
            Plat p = (Plat)lbPlats.SelectedItem;
            if(p == null)
            {
                MessageBox.Show("Veuillez choisir un plat svp");
                return;
            }

            Categorie categorie = (Categorie)cbCat.SelectedItem;
            string prix = tbPrix.Text;
            string cal = tbCal.Text;

            if(!string.IsNullOrEmpty(tbNom.Text))
            {
                MessageBox.Show("Vous ne pouvez pas modifier le nom d'un plat");
                return;
            }

            if (!string.IsNullOrEmpty(prix))
                p.SetPrix(Convert.ToInt16(prix));

            if (!string.IsNullOrEmpty(cal))
                p.SetNbCalories(Convert.ToInt16(cal));

            if (cbVegan.Checked)
                p.SetVegan(true);
            else
                p.SetVegan(false);

            if (cbGlutenFree.Checked)
                p.SetGlutenFree(true);
            else
                p.SetGlutenFree(false);

            p.SetCategorie(categorie);
            listePlatsModif.Add(p);
            MessageBox.Show("Les modifications sont bien prises en compte");
        }

        private void btPlatMoinsCher_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Le plat le moins cher est le plat suivant :\n " + ORMPlats.GetPlatMoinsCher());
        }

        private void btPrixMoyen_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Le prix moyen de la carte est de " + ORMPlats.GetPrixMoyen() + "€");
        }

        private void btAffichPlatCat_Click(object sender, EventArgs e)
        {
            List<Plat> lp = ORMPlats.GetPlatsByCategorie((Categorie)cbCategoriePlat.SelectedItem);
            lbPlats.Items.Clear();
            lbPlats.Items.AddRange(lp.ToArray());
        }

        private void btSuppPlat_Click(object sender, EventArgs e)
        {
            Plat p = (Plat)lbPlats.SelectedItem;
            if(p == null)
            {
                MessageBox.Show("Aucun plat n'a été sélectionné");
                return;
            }

            if(ORMPlats.DeletePlat(p))
                MessageBox.Show("Votre plat a été supprimé");
        }

        private void btPlatPlusCal_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Le plat le plus calorique de notre carte est :\n " + ORMPlats.GetPlatPlusCalorique()); 
        }

        private void btValidModif_Click(object sender, EventArgs e)
        {
            if (listePlatsModif.Count > 0)
            {
                foreach (Plat p in listePlatsModif)
                    if (!ORMPlats.ModifierPlat(p))
                        MessageBox.Show("Le plat " + p.ToString() + " n'a pas pu être modifié");
                    else
                        MessageBox.Show("Le plat " + p.ToString() + " a été modifié");
                listePlatsModif.Clear();
            }
            else
                MessageBox.Show("Il faut modifier au moins 1 plat avant de pouvoir valider les modifications");
        }
    }
}
