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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();

            ORMDatabase.Connexion();
        }

        private bool ControlData()
        {
            if (tbUserName.Text != "" && tbPassword.Text != "")
                return true;
            return false;
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            if(ControlData())
            {
                string user = tbUserName.Text;
                string password = tbPassword.Text;
                if(ORMUser.Connexion(user, password))
                {
                    switch (User.GetTypeuser())
                    {
                        case "JOU":
                            Form fj = new FormTemplateJoueur();
                            fj.Show();
                            break;
                        case "ADM":
                            this.Close();
                            Form ft = new FormTemplateAdmin();
                            ft.Show();
                            break;
                    }
                    Notification.ShowFormSuccess("Bienvenu " + User.GetUsername());
                    this.Close();
                }
                else
                    Notification.ShowFormDanger("Nom d'utilisateur et/ou mot de passe incorrect");
            }
            else
                Notification.ShowFormAlert("Entrez un nom d'utilisateur et un mot de passe valide");
        }

        private void btSingin_Click(object sender, EventArgs e)
        {
            if (ControlData() && !ORMUser.Exist(tbUserName.Text))
            {
                string user = tbUserName.Text;
                string password = tbPassword.Text;
                if (ORMUser.Inscription(user, password) && ORMUser.Connexion(user, password))
                {
                    switch(User.GetTypeuser())
                    {
                        case "JOU":
                            Notification.ShowFormInfo("Bienvenu au joueur " + User.GetUsername());
                            break;
                    }
                }
                else
                    Notification.ShowFormDanger("La connection a échouée");
            }
            else
                Notification.ShowFormAlert("Entrez un nom d'utilisateur et un mot de passe valide");
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
