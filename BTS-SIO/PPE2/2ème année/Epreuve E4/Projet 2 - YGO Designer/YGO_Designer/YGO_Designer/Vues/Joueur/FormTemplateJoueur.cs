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
using YGO_Designer.Classes.User;
using YGO_Designer.Vues.Joueur;

namespace YGO_Designer
{
    /// <summary>
    /// Formulaire servant de template aux formulaires de l'utilisateur se connectant
    /// </summary>
    public partial class FormTemplateJoueur : Form
    {
        private Form activeForm = null;

        private FormHomeJoueur fhj;
        private FormChercherCarte fcc;
        public FormTemplateJoueur()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Ouvre le formulaire d'accueil
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btHome_Click(object sender, EventArgs e)
        {
            openChildForm(fhj);
        }

        /// <summary>
        /// Ouvre le formulaire de recherche d'une carte
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btChercherCarte_Click(object sender, EventArgs e)
        {
            openChildForm(fcc);
        }

        /// <summary>
        /// Permet de charger un formulaire dans un panel
        /// </summary>
        /// <param name="childForm"></param>
        private void openChildForm(Form childForm)
        {
            if (childForm != activeForm)
            {
                if (activeForm != null)
                    activeForm.Hide(); //On cache le formulaire enfant actif
                activeForm = childForm;
                childForm.TopLevel = false; //Le formulaire s'affiche en tant que formulaire enfant à celui-ci
                childForm.FormBorderStyle = FormBorderStyle.None; //Pas de bordures
                childForm.Dock = DockStyle.Fill; //Ancrage bord à bord du formulaire enfant
                pnFormChild.Controls.Add(childForm); //Ajout du formulaire enfant dans le panel
                pnFormChild.Tag = childForm; //On y associe le tag
                childForm.BringToFront(); //On affiche le formulaire enfant au premier plan devant le panel
                childForm.Show(); //On affiche le formulaire enfant
            }
        }

        /// <summary>
        /// Charge le formulaire Template
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormTemplate_Load(object sender, EventArgs e)
        {
            fhj = new FormHomeJoueur();
            fcc = new FormChercherCarte();
            openChildForm(fhj);
        }

        private void btCreerDeck_Click(object sender, EventArgs e)
        {
            //TO DO 
            //Affiche un form pour générer un deck stratégique
        }

        /// <summary>
        /// Quitte l'application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
