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
            stockSARL_SIO1A.AjouterProduit(new JeuPlateau("112", "Vallée mamouths", 11.2f, 12,5,180,11));
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
            List<Produit> listeP = null;
            // TO DO en tenant compte des cases à cocher chkbPlateau et chkbInformatique

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
            Produit p = null;
           // TO DO
            // tenir comptebouton radio  rdbAjoutPlateau et rdbAjoutInformatique
        }


        private void btLivrer_Click(object sender, EventArgs e) {
            bool ok;

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
            List<Produit> listeP = null;

                // TO DO
                // tenir compte cases à cocher chkbRechInformatique et chkbRechPlateau
           
            this.AfficherDansListe(listeP);
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
