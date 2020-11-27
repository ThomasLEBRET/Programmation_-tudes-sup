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
                    FormSuccess fs = new FormSuccess();
                    fs.SetDescription("Bienvenu " + User.GetUsername());
                    fs.Show();
                    this.Close();
                }
                else
                {
                    FormDanger fd = new FormDanger();
                    fd.SetDescription("La connexion a échouée");
                    fd.ShowDialog();
                    return;
                }
            }
            else
            {
                FormAlert fa = new FormAlert();
                fa.SetDescription("Entrez un nom d'utilisateur et un mot de passe valide.");
                fa.ShowDialog();
                return;
            }
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
                            FormInfo fi = new FormInfo();
                            fi.SetDescription("Bienvenu au joueur " + User.GetUsername());
                            fi.ShowDialog();
                            break;
                        case "ADM":
                            this.Close();
                            FormTemplateAdmin ft = new FormTemplateAdmin();
                            ft.Show();
                            break;
                    }
                }
                else
                {
                    FormDanger fd = new FormDanger();
                    fd.SetDescription("La connexion a échouée");
                    fd.ShowDialog();
                    return;
                }
            }
            else
            {
                FormAlert fa = new FormAlert();
                fa.SetDescription("Entrez un nom d'utilisateur et un mot de passe existant.");
                fa.ShowDialog();
                return;
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
