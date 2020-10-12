using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace inscription_serialisation
{
    public partial class JeuMemory : Form
    {
        Memory jeuMemoire;
        int tempsDepart = 120; //2 minutes
        PictureBox premEssai; //pictureBox au premier clic
        PictureBox secEssai; //pictureBox au second clic
        int coupleEssai = 0; //Détermine le nombre de clic sur une pictureBox activée
        int nbrPoints = 0; //Nombre de points gagnés par le joueur (+1 point par pair trouvée)

        public JeuMemory()
        {
            InitializeComponent();
            jeuMemoire = new Memory(); //Nouvelle instance de la class Memory
        }

        private void btPause_Click(object sender, EventArgs e)
        {
            timer.Stop();
            btPause.Visible = false;
            btStart.Visible = true;
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            timer.Start();
            btPause.Visible = true;
            btStart.Visible = false;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            tempsDepart--; //Décrémente le temps de départ à chaque Tick
            lbTime.Text = MesOutils.ConvertiSecondes(tempsDepart);
            //Partie perdue si le timer a exécuté 120 Tick 
            if (tempsDepart <= 0)
            {
                DonneesPubliques.monEnfant.SetScore(DonneesPubliques.monEnfant.GetScore() + nbrPoints);
                GroupeEnfants.SerialiseListe();
                timer.Stop();
                MessageBox.Show("Vous avez perdu !");
                //Demande une nouvelle partie au joueur
                var nouvellePartie = MessageBox.Show("Veux-tu faire une nouvelle partie en gardant ton score actuel ?", "Nouvelle partie",
                                 MessageBoxButtons.YesNo);
                if (nouvellePartie == DialogResult.No)
                    Application.Exit();
                jeuMemoire.StartGame(this);
                tempsDepart = 120;
                premEssai = null;
                secEssai = null;
                coupleEssai = 0;
                timer.Start();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            p.Enabled = false; //Désactive la pictureBox au clic 
            coupleEssai++; //Ajoute 1 au nombre de clic sur une pictureBox active
            jeuMemoire.DecouvreImage(p, Convert.ToInt16(p.Tag)); //Affiche l'image cliquée
            //Si on a cliqué sur 2 pictureBox 
            if (coupleEssai == 2)
            {
                secEssai = p;
                //Si les 2 Tag des 2 pictureBox sont différents, on repose les images sur le plateau de jeu
                if (Convert.ToInt16(premEssai.Tag) != Convert.ToInt16(secEssai.Tag))
                    jeuMemoire.ReposeImages(premEssai, secEssai);
                //Sinon on a trouvé une paire d'images
                else
                {
                    nbrPoints++; //Ajout d'un point
                    lbPoints.Text = nbrPoints.ToString(); //Affiche le score
                    coupleEssai = 0;  //Remet le nombre de clic à 0
                    //Vérifie si on a trouvé toutes les paires d'images
                    if (jeuMemoire.VerifieFinJeu(this))
                    {
                        DonneesPubliques.monEnfant.SetScore(DonneesPubliques.monEnfant.GetScore() + nbrPoints);
                        GroupeEnfants.SerialiseListe();
                        //On stop le timer et on demandeau joueur si il souhaite faire une nouvelle partie
                        timer.Stop();
                        MessageBox.Show("Bravo, tu as tout trouvé. Tu es vraiment fort !\n Ton score a été sauvegardé sur ton compte.");
                        var nouvellePartie = MessageBox.Show("Veux-tu faire une nouvelle partie ?", "Nouvelle partie",
                                 MessageBoxButtons.YesNo);
                        if (nouvellePartie == DialogResult.No)
                        {
                            this.Close();
                            Menu menu = new Menu();
                            menu.Show();
                        }
                        jeuMemoire.StartGame(this);
                        tempsDepart = 120;
                        premEssai = null;
                        secEssai = null;
                        coupleEssai = 0;
                        nbrPoints = 0;
                        lbPoints.Text = nbrPoints.ToString();
                        timer.Start();
                        btStart.Visible = false;
                    }
                }
                //S'il reste des paires à trouver, on remet nos pictureBox (variables globales) à null
                //et le nombre de clic à 0
                coupleEssai = 0;
                premEssai = null;
                secEssai = null;
            }
            //Si il n'y a eu qu'un clic, on garde en mémoire la première pictureBox
            else
                premEssai = p;
        }

        private void pbCommencer_Click(object sender, EventArgs e)
        {
            jeuMemoire.StartGame(this);
            timer.Start();
            pbCommencer.Visible = false;
            btPause.Visible = true;
        }

        private void pbQuitter_Click(object sender, EventArgs e)
        {
            timer.Stop();
            var quitter = MessageBox.Show("Souhaites-tu quitter le jeu ? Ton score actuel ne sera pas sauvegardé", "Nouvelle partie",
                                MessageBoxButtons.YesNo);
            if (quitter == DialogResult.Yes)
            {
                this.Close();
                Menu menu = new Menu();
                menu.Show();
            }
            else
                timer.Start();
        }


    }
}
