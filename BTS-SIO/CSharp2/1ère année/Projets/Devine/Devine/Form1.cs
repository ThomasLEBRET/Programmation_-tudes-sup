﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Speech;
using System.Speech.Synthesis;

namespace Devine
{
    public partial class Form1 : Form
    {
        string monMot;
        string reponse;
        Devine partie;
        int compteur = 0;
        SpeechSynthesizer parole = new SpeechSynthesizer();

        public Form1()
        {
            InitializeComponent();
        }

        private void btQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            partie = new Devine();
            monMot = partie.PiocheNouveauMot();
            lbMot.Text = partie.AfficheMotUtilisateur();
            partie.AffichageImage(pb1, monMot);
            parole.Speak("Quel est la première lettre du mot : " + monMot);
        }

        private void btValider_Click(object sender, EventArgs e)
        {
            reponse = tbReponse.Text.ToUpper();
            tbReponse.Text = "";
            if (partie.Reponse(reponse))
            {
                MessageBox.Show("Bravo !");
                compteur++;
                var nouvellePartie = MessageBox.Show("Voulez-vous recommencer une autre partie ?", "Nouvelle partie",
                                MessageBoxButtons.YesNo);
                if (nouvellePartie == DialogResult.No)
                    Application.Exit();
                else
                {
                    monMot = partie.PiocheNouveauMot();
                    lbMot.Text = partie.AfficheMotUtilisateur();
                    partie.AffichageImage(pb1, monMot);
                    parole.Speak("Quel est la première lettre du mot : " + monMot);
                }
            }
            else
            {
                MessageBox.Show("Mauvaise réponse, réessaye encore.");
            }
        }
        
   
    }


        
            
 }

