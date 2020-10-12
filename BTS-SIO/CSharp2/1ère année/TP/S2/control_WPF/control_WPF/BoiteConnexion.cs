using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace control_WPF
{
    public partial class BoiteConnexion : UserControl
    {
        public BoiteConnexion()
        {
            InitializeComponent();
        }

        private void tbLogin_TextChanged(object sender, EventArgs e)
        {
                
        }

        private void ValiderFormulaire(object sender, EventArgs e)
        {
            string login = tbLogin.Text;
            string password = tbPassword.Text;
            if (login == "")
                MessageBox.Show("Le login est vide. \n Rentrez un login valide");
            else
                if (password.Length < 6)
                    MessageBox.Show("Le mot de passe fait moins de 6 caractères ou est vide. \n Rentrez un mot de passe valide");
                else
                    MessageBox.Show("Bienvenu " + login + ". Votre mot de passe a été enregistré !");
        }

        private void AnnulerFormulaire(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BoiteConnexion_Load(object sender, EventArgs e)
        {
            clicSurBtValid = new ClicSurBtEventHandler(ValiderFormulaire);
            clicSurBtAnnul = new ClicSurBtEventHandler(AnnulerFormulaire);
        }

        private void btValider_Click(object sender, EventArgs e)
        {
            if (clicSurBtValid != null)
                clicSurBtValid(this, e);
        }

        private void btAnnuler_Click(object sender, EventArgs e)
        {
            if (clicSurBtAnnul != null)
                clicSurBtAnnul(this, e);
        }
    }
}
