using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace inscription_serialisation
{
    public partial class Inscription : Form
    {
        public Inscription()
        {
            InitializeComponent();
        }

        private void btInscription_Click(object sender, EventArgs e)
        {
            if (tbLogin.Text != "" && tbMotDePasse.Text != "")
            {
                string pseudo = tbLogin.Text;
                string motDePasse = tbMotDePasse.Text;
                int score = 0;
                if (GroupeEnfants.EstPseudoExistant(pseudo))
                {
                    MessageBox.Show("Votre pseudo est déjà pris, veuillez rentrer un autre pseudo");
                }
                else
                {
                    Enfant enf = DonneesPubliques.monEnfant;
                    enf = new Enfant(pseudo, motDePasse, score);
                    GroupeEnfants.AjouterEnfant(enf);
                    GroupeEnfants.SerialiseListe();
                    Connexion connexion = new Connexion();
                    connexion.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Veuillez rentrer un pseudo et/ou un mot de passe.");
            }
            MesOutils.EffacerZonesDeTexte(this);
        }

        private void btPasserAConnexion_Click(object sender, EventArgs e)
        {
            Connexion connexion = new Connexion();
            connexion.Show();
            this.Hide();
        }

        private void Inscription_Load(object sender, EventArgs e)
        {
            if (File.Exists("groupeEnfant.txt"))
            {
                GroupeEnfants.DeserialiseListe();
            }
            else
            {
                GroupeEnfants.SerialiseListe();
            }
            MesOutils.EffacerZonesDeTexte(this);
        }

        private void pbQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
