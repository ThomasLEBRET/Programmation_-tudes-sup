using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SacADos
{
    public partial class FormAppliSac : Form
    {
        private SacADos sacADos;
        private Armoire armoire;

        public FormAppliSac()
        {
            InitializeComponent();

            sacADos = new SacADos(1);
            armoire = new Armoire();
            Article a1, a2, a3, a4, a5, a6;
            a1 = new Article("a1" , 500, 20);
            a2 = new Article("a2", 50, 20);
            a3 = new Article("a3", 250, 20);
            a4 = new Article("a4", 100, 2);
            a5 = new Article("a5", 200, 4);
            a6 = new Article("a6", 50, 1);
            armoire.AjouterArticle(a1);
            armoire.AjouterArticle(a2);
            armoire.AjouterArticle(a3);
            armoire.AjouterArticle(a4);
            armoire.AjouterArticle(a5);
            armoire.AjouterArticle(a6);
            lbArmoire.Items.AddRange(armoire.GetListeArticles().ToArray());
            ActualiserAffichagePoids();
        }

        /* Méthodes locales */

        private void ActualiserArmoire()
        {
            /* On met la listBox armoire à jour */
            lbArmoire.Items.Clear();
            lbArmoire.Items.AddRange(armoire.GetListeArticles().ToArray());
        }

        private void ActualiserSacADos()
        {
            /* On met la listBox sacADos à jour */
            lbSacADos.Items.Clear();
            lbSacADos.Items.AddRange(sacADos.GetArticlesEmportes().ToArray());
        }

        private void ActualiserAffichagePoids()
        {
            string poidsActuel = Outils.ConvertiPoidsEnKg(sacADos.GetPoidsActuel());
            lbPoidsMax.Text = "Poids max : " + Convert.ToString(sacADos.GetPoidsMax()) + "kg";
            lbPoidsActuel.Text = "Poids actuel : " + poidsActuel + " / " + Convert.ToString(sacADos.GetPoidsMax()) + "kg";
        }

        private void ViderSacADos()
        {
            /* Transfère les objets du sac à dos à l'armoire */
            foreach (Article a in sacADos.GetArticlesEmportes())
            {
                armoire.AjouterArticle(a);
            }
            sacADos.SetArticlesEmportes(new List<Article>());
            sacADos.SetPoidsActuel(0);
            ActualiserArmoire();
            ActualiserSacADos();
            ActualiserAffichagePoids();
        }

        /* Fin méthode locales */

        private void btQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btAjouterArticle_Click(object sender, EventArgs e)
        {
            string nom = tbNom.Text;
            int poids;
            int utilite;
            if (!String.IsNullOrEmpty(nom))
            {
                if (Int32.TryParse(tbPoids.Text, out poids))
                {
                    if (Int32.TryParse(tbUtilite.Text, out utilite) && utilite > 0 & utilite <= 20)
                    {
                        Article a = new Article(nom, poids, utilite);
                        armoire.AjouterArticle(a);
                        ActualiserArmoire();
                        Outils.EffacerZonesDeTexte(this);

                    }
                    else
                        MessageBox.Show("Entrez un nombre utilité valide (non vide et compris entre 1 et 20 inclus");
                }
                else
                    MessageBox.Show("Entrez un poids entier valide");
            }
            else
                MessageBox.Show("Veuillez entrer un nom d'article");
        }

        private void btViderSac_Click(object sender, EventArgs e)
        {
            ViderSacADos();
        }

        private void btVersSacADos_Click(object sender, EventArgs e)
        {
            int indArticle = -2;
            indArticle = lbArmoire.SelectedIndex;
            Article a;
            if (indArticle >= 0)
            {
                /* On ajoute l'article au sac à dos */
                a = (Article)lbArmoire.Items[indArticle];
                if (a.GetPoids() + sacADos.GetPoidsActuel() <= sacADos.GetPoidsMax() * 1000)
                {
                    sacADos.AjouterArticle(a);

                    /* Puis on supprime l'item de l'armoire */
                    armoire.SupprimerArticle(a);

                    /* On ajoute le poids de l'article au sac à dos */
                    sacADos.SetPoidsActuel(sacADos.GetPoidsActuel() + a.GetPoids());
                    ActualiserAffichagePoids();

                    ActualiserArmoire();
                    ActualiserSacADos();
                }
                else
                    MessageBox.Show("Si cet article est ajouté au sac, ce dernier aura dépassé sa capacité maximum");
            }
            else
                MessageBox.Show("Choisissez un article");
        }

        private void btVersArmoire_Click(object sender, EventArgs e)
        {
            int indArticle = -2;
            indArticle = lbSacADos.SelectedIndex;
            Article a;
            if (indArticle >= 0)
            {
                /* On ajoute l'article à l'armoire */
                a = (Article)lbSacADos.Items[indArticle];
                armoire.AjouterArticle(a);

                /* Puis on supprime l'item du sac à dos */
                sacADos.SupprimerArticle(a);

                ActualiserArmoire();
                ActualiserSacADos();
            }
            else
                MessageBox.Show("Choisissez un article");
        }

        private void btSupprimerArticle_Click(object sender, EventArgs e)
        {
            /* Supprime un article de l'armoire */
            int indArticle = -2;
            indArticle = lbArmoire.SelectedIndex;
            Article a;
            if (indArticle >= 0)
            {
                a = (Article)lbArmoire.Items[indArticle];
                armoire.SupprimerArticle(a);
                ActualiserArmoire();
            }
            else
                MessageBox.Show("Choisissez un article à supprimer dans l'armoire");
        }

        private void btModifierPoidsMax_Click(object sender, EventArgs e)
        {
            int poidsMax = 0;
            if (Int32.TryParse(tbPoidsMaxSacADos.Text, out poidsMax))
            {
                sacADos.SetPoidsMax(poidsMax);
                ActualiserAffichagePoids();
            }
            else
                MessageBox.Show("Le poids n'est pas valide");
            Outils.EffacerZonesDeTexte(this);
        }

        private void btRempliAutoSac_Click(object sender, EventArgs e)
        {
            ViderSacADos();
            armoire.GetListeArticles().Sort();
            foreach(Article a in armoire.GetListeArticles())
            {
                if(a.GetPoids() + sacADos.GetPoidsActuel() <= sacADos.GetPoidsMax() * 1000)
                {
                    sacADos.AjouterArticle(a);
                    sacADos.SetPoidsActuel(sacADos.GetPoidsActuel() + a.GetPoids());
                }
            }
            foreach(Article a in sacADos.GetArticlesEmportes())
                armoire.SupprimerArticle(a);

            ActualiserAffichagePoids();
            ActualiserArmoire();
            ActualiserSacADos();
        }

        private void btModifPoids_Click(object sender, EventArgs e)
        {
            int indArticleArmoire = lbArmoire.SelectedIndex;
            int poids;
            if (indArticleArmoire >= 0)
            {
                if (Int32.TryParse(tbUtilPoids.Text, out poids))
                {
                    Article a = (Article)lbArmoire.Items[indArticleArmoire];
                    a.SetPoids(poids);
                    armoire.ModifierArticle(indArticleArmoire, a);
                    ActualiserArmoire();
                }
                else
                    MessageBox.Show("Veuillez choisir un poids valide pour l'article choisi");
            }
            else
                MessageBox.Show("Veuillez choisir un article dans l'armoire");
            Outils.EffacerZonesDeTexte(this);
        }

        private void btModifUtilite_Click(object sender, EventArgs e)
        {
            int indArticleArmoire = lbArmoire.SelectedIndex;
            int utilite;
            if (indArticleArmoire >= 0)
            {
                if (Int32.TryParse(tbUtilUtilite.Text, out utilite))
                {
                    if (utilite > 0 && utilite <= 20)
                    {
                        Article a = (Article)lbArmoire.Items[indArticleArmoire];
                        a.SetUtilite(utilite);
                        armoire.ModifierArticle(indArticleArmoire, a);
                        ActualiserArmoire();
                    }
                    else
                        MessageBox.Show("L'utilité n'est pas comprise entre 1 et 20");
                }
                else
                    MessageBox.Show("Veuillez choisir une valeur pour l'utilité comprise entre 1 et 20");
            }
            else
                MessageBox.Show("Veuillez choisir un article dans l'armoire");
            Outils.EffacerZonesDeTexte(this);
        }

        private void btTriArmoire_Click(object sender, EventArgs e)
        {
            armoire.GetListeArticles().Sort();
            ActualiserArmoire();
        }
    }
}
