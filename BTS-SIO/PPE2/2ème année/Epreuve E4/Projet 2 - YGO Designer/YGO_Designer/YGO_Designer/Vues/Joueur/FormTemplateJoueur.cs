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
    public partial class FormTemplateJoueur : Form
    {
        private Form activeForm = null;

        private FormHomeJoueur fhj;
        private FormChercherCarte fcc;
        public FormTemplateJoueur()
        {
            InitializeComponent();

            FormSuccess fs = new FormSuccess();
            fs.SetDescription("Bienvenu " + User.GetUsername());
            fs.Show();
        }

        private void btHome_Click(object sender, EventArgs e)
        {
            openChildForm(fhj);
        }

        private void btChercherCarte_Click(object sender, EventArgs e)
        {
            openChildForm(fcc);
        }

        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Hide();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnFormChild.Controls.Add(childForm);
            pnFormChild.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

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

        private void btClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
