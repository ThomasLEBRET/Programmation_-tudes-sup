using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.Speech.Synthesis;

namespace tomate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SpeechSynthesizer monPerroquet = new SpeechSynthesizer();
            monPerroquet.SetOutputToDefaultAudioDevice();
            monPerroquet.Speak("Bonjour ! Je suis une tomate ! Ecris mon nom ...");
        }

        private void pbTomate_Click(object sender, EventArgs e)
        {

        }

        private void btQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tbTomate_TextChanged(object sender, EventArgs e)
        {

        }

        private void btValdier_Click(object sender, EventArgs e)
        {
            SoundPlayer gagne = new SoundPlayer("C:/Users/thleb/Documents/GitHub/CSharp_BTS-SIO/tomate/tomate/Resources/gagne.wav");
            SoundPlayer perdu = new SoundPlayer("C:/Users/thleb/Documents/GitHub/CSharp_BTS-SIO/tomate/tomate/Resources/perdu.wav");
            string tomate = tbTomate.Text;
            if (tomate.ToLower() == "tomate")
            {
                gagne.PlaySync();
            }
            else
            {
                perdu.PlaySync();
            }
        }
    }
}