using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Timers;

namespace inscription_serialisation
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            lbPseudo.Text = DonneesPubliques.monEnfant.GetPseudo();
            lbScore.Text = DonneesPubliques.monEnfant.GetScore().ToString();
        }

        private void pbQuitter_Click(object sender, EventArgs e)
        {
            var quitter = MessageBox.Show("Voulez-vous vous déconnecter ?", "Déconnexion",
                                MessageBoxButtons.YesNo);
            if (quitter == DialogResult.Yes)
            {
                this.Close();
                Connexion connexion = new Connexion();
                connexion.Show();
            }
        }

        private void Menu_Activated(object sender, EventArgs e)
        {
            lbScore.Text = DonneesPubliques.monEnfant.GetScore().ToString();
        }

        private void pbClassement_Click(object sender, EventArgs e)
        {
            Classement c = new Classement();
            c.Show();
            this.Close();
        }

        private void pbMemory_Click(object sender, EventArgs e)
        {
            JeuMemory memory = new JeuMemory();
            memory.Show();
            this.Close();
        }

        private void pbDevine_Click(object sender, EventArgs e)
        {
            JeuDevine devine = new JeuDevine();
            devine.Show();
            this.Close();
        }

        private void pbInfo_Click(object sender, EventArgs e)
        {
            Info info = new Info();
            info.Show();
            this.Close();
        }
    }
}
