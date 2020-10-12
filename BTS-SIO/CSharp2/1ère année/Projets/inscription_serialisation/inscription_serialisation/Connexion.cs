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
    public partial class Connexion : Form
    {
        public Connexion()
        {
            InitializeComponent();
        }

        private void btConnexion_Click(object sender, EventArgs e)
        {
            if (tbLogin.Text != "" && tbMotDePasse.Text != "")
            {
                string pseudo = tbLogin.Text;
                string motDePasse = tbMotDePasse.Text;
                if (GroupeEnfants.EstEnfantExistant(pseudo, motDePasse))
                {
                    if (GroupeEnfants.EstEnfantExistant(pseudo, motDePasse))
                    {
                        DonneesPubliques.monEnfant = GroupeEnfants.GetGroupeEnfant().Find(
                        delegate(Enfant en)
                        {
                            return en.GetPseudo() == pseudo;
                        });
                        Menu menu = new Menu();
                        menu.Show();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Votre pseudo et/ou mot de passe est incorrect. Je n'arrive pas à vous trouver dans la liste des inscris ;( ");
                }
            }
            else
            {
                MessageBox.Show("Veuillez rentrer un pseudo et/ou un mot de passe.");
            }
            MesOutils.EffacerZonesDeTexte(this);
        }

        private void Connexion_Load(object sender, EventArgs e)
        {
            GroupeEnfants.DeserialiseListe();
        }

        private void btInscription_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inscription inscription = new Inscription();
            inscription.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
