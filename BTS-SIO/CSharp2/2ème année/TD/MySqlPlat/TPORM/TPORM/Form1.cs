using System;
using System.Windows.Forms;

namespace TPORM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btConnexion_Click(object sender, EventArgs e)
        {
            if (ORMPlats.Connexion())
                MessageBox.Show("La connexion a bien été opérée !");
            else
                MessageBox.Show("La connexion a échouée !");
        }

        private void btDeconnexion_Click(object sender, EventArgs e)
        {
            if (ORMPlats.Deconnexion())
                MessageBox.Show("Vous êtes bien déconnecté");
            else
                MessageBox.Show("La déconnexion a échouée");
        }
    }
}
