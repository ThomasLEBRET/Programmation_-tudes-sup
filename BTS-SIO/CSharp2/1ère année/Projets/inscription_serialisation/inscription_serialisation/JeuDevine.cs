using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Speech.AudioFormat;

namespace inscription_serialisation
{
    public partial class JeuDevine : Form
    {
        string monMot;
        string reponse;
        Devine partie;
        SpeechSynthesizer parole = new SpeechSynthesizer();  
 

        public JeuDevine()
        {
            InitializeComponent();
        }

        private void JeuDevine_Load(object sender, EventArgs e)
        {
            partie = new Devine();
            parole.SetOutputToDefaultAudioDevice();
            monMot = partie.PiocheNouveauMot();
            lbMot.Text = partie.AfficheMotUtilisateur();
            partie.AffichageImage(pbImage, monMot);
            parole.Speak("Quel est la première lettre du mot : " + monMot);
        }

        private void pbQuitter_Click(object sender, EventArgs e)
        {
            Quitter();
        }

        private void btValider_Click(object sender, EventArgs e)
        {
            reponse = tbReponse.Text.ToUpper();
            MesOutils.EffacerZonesDeTexte(this);
            if (partie.Reponse(reponse))
            {
                MessageBox.Show("Bravo !");
                DonneesPubliques.monEnfant.SetScore(DonneesPubliques.monEnfant.GetScore() + 1);
                GroupeEnfants.SerialiseListe();
                var nouvellePartie = MessageBox.Show("Voulez-vous recommencer une autre partie ?", "Nouvelle partie",
                                MessageBoxButtons.YesNo);
                if (nouvellePartie == DialogResult.No)
                {
                    Quitter();
                }
                else
                {
                    monMot = partie.PiocheNouveauMot();
                    lbMot.Text = partie.AfficheMotUtilisateur();
                    partie.AffichageImage(pbImage, monMot);
                    parole.Speak("Quel est la première lettre du mot : " + monMot);
                }
            }
            else
            {
                MessageBox.Show("Mauvaise réponse, réessaye encore.");
                parole.Speak("Quel est la première lettre du mot : " + monMot);
            }
        }

        private void Quitter()
        {
            this.Close();
            Menu menu = new Menu();
            menu.Show();
        }
    }
}
