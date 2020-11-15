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
                            MessageBox.Show("Bienvenu au joueur " + User.GetUsername());
                            break;
                        case "ADM":
                            this.Close();
                            FormTemplate ft = new FormTemplate();
                            ft.Show();
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("La connexion a échouée.");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Entrez un nom d'utilisateur et un mot de passe valide.");
                return;
            }
        }

        private void btSingin_Click(object sender, EventArgs e)
        {
            if (ControlData() && !ORMUser.ExistUser(tbUserName.Text))
            {
                string user = tbUserName.Text;
                string password = tbPassword.Text;
                if (ORMUser.Inscription(user, password) && ORMUser.Connexion(user, password))
                {
                    switch(User.GetTypeuser())
                    {
                        case "JOU":
                            MessageBox.Show("Bienvenu au joueur " + User.GetUsername());
                            break;
                        case "ADM":
                            this.Close();
                            FormTemplate ft = new FormTemplate();
                            ft.Show();
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("La connexion a échouée.");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Entrez un nom d'utilisateur et un mot de passe existant.");
                return;
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
