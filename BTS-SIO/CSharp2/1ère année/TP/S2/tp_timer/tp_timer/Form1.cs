using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace tp_timer
{
    public partial class Form1 : Form
    {
        string monTheme;
        Random generateur = new Random();
        int numImageAf; // numéro de l'image qui est actuellement affichée 
        int numMotCh;  // numéro du mot affiché,il faut trouver l'image correspondante
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            numImageAf++;
            if (numImageAf == NombreImagesListe())
                numImageAf = 0;
            pictureBox1.Image = ListeDeMotsIllustres.ObtenirElementParRang(numImageAf).GetImageMot();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            if (numImageAf == numMotCh)
                MessageBox.Show("Bravo !!!!");
            else
            {
                MessageBox.Show("Non ! Essaye encore !");
                timer1.Start();
            }
        }

        private void InitialiserPartie()
        {
            ListeDeMotsIllustres.ChargerTheme(monTheme);
            numImageAf = generateur.Next(0, NombreImagesListe());
            lbMot.Text = GenererMot();
            timer1.Start();
        }

        private string GenererMot()
        {
            numMotCh = generateur.Next(0, NombreImagesListe());
            string mot = ListeDeMotsIllustres.ObtenirElementParRang(numMotCh).GetMot().ToUpper();
            return mot;
        }

        private void pbmonTheme_Click(object sender, EventArgs e)
        {
            monTheme = pbmonTheme.Name.Substring(2);
            InitialiserPartie();
            pbmonTheme.Visible = false;
            pbmesAnimaux.Visible = false;
            pictureBox1.Visible = true;
            timer1.Enabled = true;
            label1.Visible = true;
            lbMot.Visible = true;
            label2.Visible = false;
        }

        private void pbmesAnimaux_Click(object sender, EventArgs e)
        {
            monTheme = pbmesAnimaux.Name.Substring(2);
            InitialiserPartie();
            pbmonTheme.Visible = false;
            pbmesAnimaux.Visible = false;
            pictureBox1.Visible = true;
            timer1.Enabled = true;
            label1.Visible = true;
            lbMot.Visible = true;
            label2.Visible = false;
        }
           
        private int NombreImagesListe()
        {
            return ListeDeMotsIllustres.GetListeDeMotIllustre().Count;
        }
    }
}