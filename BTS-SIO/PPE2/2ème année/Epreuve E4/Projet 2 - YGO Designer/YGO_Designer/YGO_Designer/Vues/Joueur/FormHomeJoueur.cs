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
    public partial class FormHomeJoueur : Form
    {
        private List<Deck> listDeck;
        public FormHomeJoueur()
        {
            InitializeComponent();
            listDeck = new List<Deck>();
            lbAllDecks.Items.AddRange(ORMDeck.GetByUser().ToArray());
        }
        private void lbAllDecks_SelectedIndexChanged(object sender, EventArgs e)
        {
            Deck d = (Deck)lbAllDecks.SelectedItem;

            lbDeck.Items.Clear();
            lbDeck.Items.AddRange(d.GetCartes().ToArray());

            lbNomDeck.Text = "Nom : " + d.GetNom();
            lbViable.Text = "Deck jouable : " + d.IsDeckValid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(tbNomDeck.Text) && !string.IsNullOrEmpty(tbNoDeck.Text))
            {
                Deck d = new Deck(int.Parse(tbNoDeck.Text), User.GetUsername(), tbNomDeck.Text);
                if(ORMDeck.Add(d))
                {
                    lbAllDecks.Items.Add(d);
                    FormSuccess fn = new FormSuccess();
                    fn.SetDescription("Le deck a bien été ajouté à votre collection");
                    fn.ShowDialog();
                }
                else
                {
                    FormDanger fd = new FormDanger();
                    fd.SetDescription("Le deck n'a pas pu être rentrée dans la base");
                    fd.ShowDialog();
                }
            } 
            else
            {
                FormAlert fa = new FormAlert();
                fa.SetDescription("Deck non nommé et/ou non numéroté");
                fa.ShowDialog();
            }
        }

        private void btViderDeck_Click(object sender, EventArgs e)
        {
            if (lbAllDecks.SelectedIndex >= 0)
            {
                Deck d = (Deck)lbAllDecks.SelectedItem;
                ORMDeck.DeleteCards(d.GetNo());
                FormInfo fi = new FormInfo();
                fi.SetDescription("Votre deck est maintenant vide");
                fi.ShowDialog();
                lbDeck.Items.Clear();
                lbAllDecks.Items.Clear();
                lbAllDecks.Items.AddRange(ORMDeck.GetByUser().ToArray());
            }
            else
                return;
            
        }

        private void FormHomeJoueur_VisibleChanged(object sender, EventArgs e)
        {
            lbAllDecks.Items.Clear();
            lbAllDecks.Items.AddRange(ORMDeck.GetByUser().ToArray());
            lbDeck.Items.Clear();
        }

        private void btSupprCarte_Click(object sender, EventArgs e)
        {
            if (lbDeck.SelectedIndex < 0)
                return;
            else
            {
                Deck d = (Deck)lbAllDecks.SelectedItem;
                Carte c = (Carte)lbDeck.SelectedItem;
                if (ORMDeck.DeleteCardFromDeck(c, d))
                {
                    FormInfo fi = new FormInfo();
                    fi.SetDescription("La carte " + c.ToString() + " a bien été supprimée du deck " + d.GetNom());
                    fi.ShowDialog();
                }
                else
                {
                    FormDanger fd = new FormDanger();
                    fd.SetDescription("La carte " + c.ToString() + " n'a pas pu être supprimée");
                    fd.ShowDialog();
                }
            }
        }
    }
}
