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
using YGO_Designer.Classes.Deck;
using YGO_Designer.Classes.User;
using YGO_Designer.Vues.Joueur;

namespace YGO_Designer
{
    /// <summary>
    /// Formulaire d'accueil du joueur
    /// </summary>
    public partial class FormHomeJoueur : Form
    {
        private List<Deck> listDeck;

        /// <summary>
        /// Charge les decks de l'utilisateur et les rends accessibles dans la ListBox des decks de l'utilisateur
        /// </summary>
        public FormHomeJoueur()
        {
            InitializeComponent();
            listDeck = new List<Deck>();

            ActualiseDecks();
        }

        /// <summary>
        /// Affiche les informations du decks ainsi que sa liste de cartes quand le joueur sélectionne un deck
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbAllDecks_SelectedIndexChanged(object sender, EventArgs e)
        {
            Deck d = (Deck)lbAllDecks.SelectedItem;

            lbDeck.Items.Clear();
            lbDeck.Items.AddRange(d.GetCartes().ToArray());

            lbNomDeck.Text = "Nom : " + d.GetNom();
            lbViable.Text = "Deck jouable : " + d.IsDeckValid();
        }

        /// <summary>
        /// Tente d'ajouter un deck à la base de données pour le joueur connecté
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(tbNomDeck.Text) && !string.IsNullOrEmpty(tbNoDeck.Text))
            {
                Deck d = new Deck(int.Parse(tbNoDeck.Text), User.GetUsername(), tbNomDeck.Text);
                if(ORMDeck.Add(d))
                {
                    lbAllDecks.Items.Add(d);
                    Notification.ShowFormSuccess("Le deck a bien été ajouté à votre collection");
                }
                else
                {
                    Notification.ShowFormDanger("Le deck n'a pas pu être rentrée dans la base");
                }
            } 
            else
            {
                Notification.ShowFormAlert("Deck non nommé et/ou non numéroté");
            }
        }

        /// <summary>
        /// Tente de vider les cartes du deck sélectionné
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btViderDeck_Click(object sender, EventArgs e)
        {
            if (lbAllDecks.SelectedIndex >= 0)
            {
                Deck d = (Deck)lbAllDecks.SelectedItem;
                ORMDeck.DeleteCards(d.GetNo());
                ActualiseDecks();
                Notification.ShowFormInfo("Votre deck est maintenant vide");

            }
            else
            {
                Notification.ShowFormAlert("Veuillez sélectionner un deck");
            }
            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormHomeJoueur_VisibleChanged(object sender, EventArgs e)
        {
            ActualiseDecks();
        }

        /// <summary>
        /// Tente de supprimer une carte d'un deck
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btSupprCarte_Click(object sender, EventArgs e)
        {
            if (lbDeck.SelectedIndex >= 0)
            {
                Deck d = (Deck)lbAllDecks.SelectedItem;
                Carte c = (Carte)lbDeck.SelectedItem;
                if (ORMDeck.DeleteCard(c, d))
                {
                    ActualiseDecks();
                    Notification.ShowFormInfo("La carte " + c.ToString() + " a bien été supprimée du deck " + d.GetNom());
                }
                else
                    Notification.ShowFormDanger("La carte " + c.ToString() + " n'a pas pu être supprimée");
            }
        }

        /// <summary>
        /// Procédure privée actualisant la ListBox contenant tous les decks et fait disparaître les cartes du deck en question
        /// </summary>
        private void ActualiseDecks()
        {
            lbAllDecks.Items.Clear();
            lbAllDecks.Items.AddRange(ORMDeck.GetByUser().ToArray());
            lbDeck.Items.Clear();
        }

        /// <summary>
        /// Tente d'enlever un exemplaire de la carte dans le deck
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btSuppExemplaire_Click(object sender, EventArgs e)
        {
            if (lbDeck.SelectedIndex >= 0)
            {
                Deck d = (Deck)lbAllDecks.SelectedItem;
                Carte c = (Carte)lbDeck.SelectedItem;
                if(ORMDeck.RemoveCopyCard(c,d))
                {
                    if(c.GetNbExemplaireFromDeck() - 1 == 0)
                    {
                        if(ORMDeck.DeleteCard(c,d))
                        {

                        }
                    }
                }
            }
        }
    }
}
