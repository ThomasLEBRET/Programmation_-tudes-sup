using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;

namespace jeu_memory
{
    /*
     * Auteur : Thomas LEBRET
     * Class utilisée pour le jeu de mémoire dans l'application "Jeux pour enfants"
     */
    class Memory
    {
        /* Variables privées */
        private List<PictureBox> mesImages;

        /* Constructeur par défaut */
        public Memory()
        {
            mesImages = new List<PictureBox>(); //On instancie nos variables privées
        }

        /*
         * Auteur : Thomas LEBRET
         * @param : un Windows Form
         * @return : void 
         * Ajoute toutes les pictureBox de notre fenêtre dans notre liste typée
         */
        private void AddAllPictures(Form maFenetre)
        {
            foreach (Control c in maFenetre.Controls)
            {
                if (c is PictureBox)
                    mesImages.Add((PictureBox)c);
            }
        }

        /*
         * Auteur : Thomas LEBRET
         * @param : un Windows Form
         * @return : void
         * Démarre une partie du jeu de mémoire
         */
        public void StartGame(Form1 maFenetre)
        {
            AddAllPictures(maFenetre); //Ajout des pictureBox dans notre liste typée
            PictureBox pb;
            int tmp; // Tag temporaire
            Random aleatoire = new Random();
            foreach (Control c in maFenetre.Controls)
            {
                if (c is PictureBox)
                {
                    c.Enabled = true;
                    int val = aleatoire.Next(mesImages.Count);
                    //Mélange aléatoire des Tag dans notre liste typée
                    tmp = Convert.ToInt16(mesImages[0].Tag);
                    mesImages[0].Tag = mesImages[val].Tag;
                    mesImages[val].Tag = tmp;
                }
            }
            //On met les images par défaut dans les pictureBox et on ajoute un style sur le curseur
            foreach (Control c in maFenetre.Controls)
            {
                if (c is PictureBox)
                {
                    pb = mesImages[0];
                    pb.Cursor = Cursors.Hand;
                    pb.Image = (Image)Properties.Resources.mystere;
                    mesImages.RemoveAt(0);
                }
            }
        }

        /*
         * Auteur : Thomas LEBRET
         * @param : une pictureBox, un Tag représenté par un entier <int>
         * Affiche une image en fonction d'un numéro de Tag
         */
        public void DecouvreImage(PictureBox maPictureBox, int unTag)
        {
            if (Convert.ToInt16(maPictureBox.Tag) == unTag)
            {
                switch (unTag)
                {
                    case 1:
                        maPictureBox.Image = (Image)Properties.Resources.melon;
                        break;
                    case 2:
                        maPictureBox.Image = (Image)Properties.Resources.orange;
                        break;
                    case 3:
                        maPictureBox.Image = (Image)Properties.Resources.pasteque;
                        break;
                    case 4:
                        maPictureBox.Image = (Image)Properties.Resources.radis;
                        break;
                    case 5:
                        maPictureBox.Image = (Image)Properties.Resources.salade;
                        break;
                }
            }
        }

        /*
         * Auteur : Thomas LEBRET
         * @param : deux pictureBox
         * @return : void
         * Compare les Tag des 2 pictureBox et les cachent si leur numéro de Tag n'est pas équivalent
         */
        public void ReposeImages(PictureBox pictUne, PictureBox pictDeux)
        {
            if (Convert.ToInt16(pictUne.Tag) != Convert.ToInt16(pictDeux.Tag))
            {
                pictUne.Enabled = true;
                pictDeux.Enabled = true;
                Thread.Sleep(1000);
                pictUne.Image = (Image)Properties.Resources.mystere;
                pictDeux.Image = (Image)Properties.Resources.mystere;
            }
        }

        /*
         * Auteur : Thomas LEBRET
         * @param : un Windows Form
         * @return : un booléen (true ou false)
         * renvoi true si toutes les pictureBox sont désactivées, sinon renvoi false. Détermine si le jeu est terminé.
         */
        public bool VerifieFinJeu(Form1 maFenetre)
        {
            foreach(Control c in maFenetre.Controls)
            {
                if (c is PictureBox)
                {
                    if (c.Enabled == true)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        //EndFile
    }
}
