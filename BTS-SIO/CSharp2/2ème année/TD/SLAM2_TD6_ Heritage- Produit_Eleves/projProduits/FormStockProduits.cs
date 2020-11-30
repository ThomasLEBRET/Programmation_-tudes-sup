using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace projProduitsHeritage {
    public partial class FormStockProduits : Form {
        private Stock stockSARL_SIO1A;

        public FormStockProduits() {
            InitializeComponent();

            //stockSARL_SIO1A = new Stock("fichierStock.seria");
            stockSARL_SIO1A = new Stock();
            stockSARL_SIO1A.AjouterProduit(new JeuInformatique("132", "JeuI132", 10,132,"win","dvd",5));
            stockSARL_SIO1A.AjouterProduit(new JeuPlateau("37", "Citadelles", 15, 37,8,15,10));
            stockSARL_SIO1A.AjouterProduit(new JeuInformatique("23", "JeuI23", 20,23,"mac","telechargement",0));
            stockSARL_SIO1A.AjouterProduit(new JeuPlateau("111", "Dragons", 11.1f, 11,8,40,8));
            stockSARL_SIO1A.AjouterProduit(new JeuPlateau("112", "Vallée mamouths", 11.2f, 12, 5, 180, 11));
            stockSARL_SIO1A.AjouterProduit(new JeuInformatique("234", "LINQ", 20, 23, "mac", "telechargement", 0));
            //List<Produit> ll = new List<Produit> { new Produit("132", "Clock Radio", 10),new Produit ("37", "Mobile Phone", 15) };
        }

        private void btChargerFichier_Click(object sender, EventArgs e) { // FOURNIE
            string nomFichier;
            DialogResult dr;
            string filtreFichier;

            openFileDialogStock.InitialDirectory = Environment.CurrentDirectory;

            filtreFichier = "fichier serialisation (*.seria)|*.seria|";
            filtreFichier += "binaire(*.ser)|*.ser|tout fichier (*.*)|*.*";
            openFileDialogStock.Filter = filtreFichier;

            dr = openFileDialogStock.ShowDialog();

            if (dr == DialogResult.OK)
            {
                nomFichier = openFileDialogStock.FileName;

                // désérialisation
                stockSARL_SIO1A = new Stock(nomFichier);
                listBoxProduits.Items.Clear();

                MessageBox.Show("chargement effectué de " + stockSARL_SIO1A.GetNbProduits() + " produits ");

            }
        }

        private void AfficherDansListe(List<Produit> liste) { // FOURNIE

            listBoxProduits.Items.Clear();
            foreach (Produit p in liste)
            {
                listBoxProduits.Items.Add(p);
            }
        }

        private void btEnregistrerFichier_Click(object sender, EventArgs e) {  //FOURNIE
            string nomFich;
            string filtreFichier;

            saveFileDialogStock.InitialDirectory = Environment.CurrentDirectory;

            filtreFichier = "fichier serialisation (*.seria)|*.seria|";
            filtreFichier += "binaire(*.ser)|*.ser|tout fichier (*.*)|*.*";
            saveFileDialogStock.Filter = filtreFichier;

            DialogResult dr = saveFileDialogStock.ShowDialog();

            if (dr == DialogResult.OK)
            {
                nomFich = saveFileDialogStock.FileName;
                // serialisation
                stockSARL_SIO1A.Serialiser(nomFich);

                MessageBox.Show("enregistrement effectué de " + stockSARL_SIO1A.GetProduits().Count + " produits ");

            }
        }

        private void btAfficherProduits_Click(object sender, EventArgs e) {
            List<Produit> listeP = new List<Produit>();
            // TO DO en tenant compte des cases à cocher chkbPlateau et chkbInformatique
            foreach(Produit p in stockSARL_SIO1A.GetProduits())
            {
                if (chkbAffPlateau.Checked && p is JeuPlateau)
                {
                    listeP.Add(p);
                }
                if (chkbAffInformatique.Checked && p is JeuInformatique)
                {
                    listeP.Add(p);
                }
            }

            this.AfficherDansListe(listeP);
        }

        private void btAfficher_Click(object sender, EventArgs e) {
            Produit p;

            p = stockSARL_SIO1A.GetProduit(txtId.Text);

            if (p != null)
            {
                MessageBox.Show(p.ToString());
            }
            else
            {
                MessageBox.Show("Produit inexistant");
            }
        }

        private void btAjouter_Click(object sender, EventArgs e) {
            Produit p = new Produit(txtIdProduit.Text, txtDesiProduit.Text, int.Parse(txtPrixProduit.Text), int.Parse(txtStockProduit.Text));
           // TO DO
            // tenir comptebouton radio  rdbAjoutPlateau et rdbAjoutInformatique
            if (rdbAjoutPlateau.Checked)
            {
                p = new JeuPlateau(txtIdProduit.Text, txtDesiProduit.Text, int.Parse(txtPrixProduit.Text), int.Parse(txtStockProduit.Text), int.Parse(txtNbJoueur.Text), int.Parse(txtDuree.Text), int.Parse(txtAgeMin.Text));
            }
            else
            {
                p = new JeuInformatique(txtIdProduit.Text, txtDesiProduit.Text, int.Parse(txtPrixProduit.Text), int.Parse(txtStockProduit.Text), txtAjoutSE.Text, txtAjoutSupport.Text, 0);
            }
            stockSARL_SIO1A.AjouterProduit(p);
            MessageBox.Show("Le produit a été ajouté");
        }


        private void btLivrer_Click(object sender, EventArgs e) {
            bool ok;
            if (txtQte.Text == "")
            {
                txtQte.Text = "0";
            }
            ok = stockSARL_SIO1A.Livrer(txtId.Text, int.Parse(txtQte.Text));
            if (ok)
            {
                MessageBox.Show("livraison effectuée");
            }
            else
            {
                MessageBox.Show("Ce produit n'existe pas");
            }

        }

        private void btVendre_Click(object sender, EventArgs e) {
            bool ok;
            if (txtQte.Text == "")
            {
                txtQte.Text = "0";
            }

            try
            {
                ok = stockSARL_SIO1A.Vendre(txtId.Text, int.Parse(txtQte.Text));
                if (ok)
                {
                    MessageBox.Show("Vente effectuée");
                }
                else
                {
                    MessageBox.Show("Ce produit n'existe pas");
                }
            }
            catch (ExceptionStockInsuffisant es)
            {
                MessageBox.Show(es.Message);
            }

        }

        private void btRechercher_Click(object sender, EventArgs e) {
            // TO DO
            // tenir compte cases à cocher chkbRechInformatique et chkbRechPlateau
            var allProd =
                from produit in stockSARL_SIO1A.GetProduits()
                select produit;

            var prodPlat = from produit in allProd
                   where produit is JeuPlateau
                   select produit;

            var prodInfo = from produit in allProd
                   where produit is JeuInformatique
                   select produit;

            if (chkRechDesi.Checked)
            {
                prodPlat =
                    from produit in prodPlat
                    where produit.GetDesignation().ToUpper().Contains(txtRechDesi.Text.ToUpper())
                    select produit;

                prodInfo =
                    from produit in prodInfo
                    where produit.GetDesignation().ToUpper().Contains(txtRechDesi.Text.ToUpper())
                    select produit;
            }


            if (chkRechPlateau.Checked)
            {
                bool possedeConditionTri = false;
                foreach (CheckBox c in grpbRechPlateau.Controls.OfType<CheckBox>())
                {
                    if (c.Checked)
                        possedeConditionTri = true;
                }

                if (possedeConditionTri == false)
                {
                    prodPlat =
                    from JeuPlateau produit in new List<JeuPlateau>()
                    select produit;
                }

                if (chkRechNbJoueur.Checked)
                {
                    prodPlat = from JeuPlateau produit in prodPlat
                           where produit.GetNbJoueur() == int.Parse(txtRechNbJoueur.Text)
                           select produit;
                }

                if (chkRechDuree.Checked)
                {
                    prodPlat =
                       from JeuPlateau produit in prodPlat
                       where produit.GetDuree() <= int.Parse(txtRechDuree.Text)
                       select produit;
                }

                if (chkRechAgneMin.Checked)
                {
                    prodPlat =
                       from JeuPlateau produit in prodPlat
                       where produit.GetAgeMin() <= int.Parse(txtRechAgeMin.Text)
                       select produit;
                }

            }

            if (chkRechInformatique.Checked)
            {
                bool possedeConditionTri = false;
                foreach (CheckBox c in grpbRechInformatique.Controls.OfType<CheckBox>())
                {
                    if (c.Checked)
                        possedeConditionTri = true;
                }

                if(possedeConditionTri == false)
                {
                    prodInfo =
                            from JeuInformatique produit in new List<JeuInformatique>()
                            select produit;
                }

                if (chkRechSE.Checked)
                {
                    prodInfo =
                        from JeuInformatique produit in prodInfo
                        where produit.GetSE().Contains(txtRechSE.Text)
                        select produit;
                }

                if (chkRechSupport.Checked)
                {
                    prodInfo =
                        from JeuInformatique produit in prodInfo
                        where produit.GetSupport().Contains(txtRechSupport.Text)
                        select produit;
                }

            }

            this.AfficherDansListe(prodInfo.ToList().Concat(prodPlat.ToList()).ToList());
        }

        private void btRazStock_Click(object sender, EventArgs e) {
            stockSARL_SIO1A.Raz();
            this.AfficherDansListe(new List<Produit>());
            MessageBox.Show("Magasin fermé");
        }

        private void rdbPlateau_CheckedChanged(object sender, EventArgs e) {
            if (rdbAjoutPlateau.Checked )
            {
                gpbAjoutPlateau.Enabled = true;
                gpbAjoutInformatique.Enabled = false;
            }
            else
            {
                gpbAjoutPlateau.Enabled = false;
                gpbAjoutInformatique.Enabled = true;
            }
        }

        

        

        private void chkRechPlateau_CheckedChanged(object sender, EventArgs e) {
            if (chkRechPlateau.Checked == false)
            {
                grpbRechPlateau.Enabled = false;
            }
            else
            {
                grpbRechPlateau.Enabled = true;
            }
        }

        private void chkRechInformatique_CheckedChanged(object sender, EventArgs e) {
            if (chkRechInformatique.Checked == false)
            {
                grpbRechInformatique.Enabled = false;
            }
            else
            {
                grpbRechInformatique.Enabled = true;
            }
        }

       
       
       
        
    }

}
