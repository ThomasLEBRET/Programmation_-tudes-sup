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
        string nomFruit = "tomate";
        int fruit = 1;
        int bonneRep = 0;
        int mauvaiseRep = 0;
        string path = Application.StartupPath;
        SpeechSynthesizer monPerroquet = new SpeechSynthesizer();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
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

        private void btValdier_Click(object sender, EventArgs e)
        {
            monPerroquet.SetOutputToDefaultAudioDevice();
            fruit++;
            SoundPlayer gagne = new SoundPlayer("C:/Users/thleb/Documents/GitHub/CSharp_BTS-SIO/tomate/tomate/Resources/gagne.wav");
            SoundPlayer perdu = new SoundPlayer("C:/Users/thleb/Documents/GitHub/CSharp_BTS-SIO/tomate/tomate/Resources/perdu.wav");
            if (tbFruit.Text.ToLower() == nomFruit)
            {
                gagne.PlaySync();
                bonneRep++;
            }
            else
            {
                perdu.PlaySync();
                mauvaiseRep++;
            }
            switch (fruit)
            {
                case 2:
                    pbFruit.Image = Image.FromFile(@"C:/Users/thleb/Documents/GitHub/CSharp_BTS-SIO/tomate_test/tomate/Resources/aubergine.jpg");
                    nomFruit = "aubergine";
                    monPerroquet.Speak("Bonjour ! Je suis une aubergine ! Ecris mon nom ...");
                    break;
                case 3:
                    pbFruit.Image = Image.FromFile(@"C:/Users/thleb/Documents/GitHub/CSharp_BTS-SIO/tomate_test/tomate/Resources/banane.jpg");
                    nomFruit = "banane";
                    monPerroquet.Speak("Bonjour ! Je suis une banane ! Ecris mon nom ...");
                    break;
                case 4:
                    pbFruit.Image = Image.FromFile(@"C:/Users/thleb/Documents/GitHub/CSharp_BTS-SIO/tomate_test/tomate/Resources/concombre.jpg");
                    nomFruit = "concombre";
                    monPerroquet.Speak("Bonjour ! Je suis un concombre ! Ecris mon nom ...");
                    break;
                case 5:
                    pbFruit.Image = Image.FromFile(@"C:/Users/thleb/Documents/GitHub/CSharp_BTS-SIO/tomate_test/tomate/Resources/orange.jpg");
                    nomFruit = "orange";
                    monPerroquet.Speak("Bonjour ! Je suis une orange ! Ecris mon nom ...");
                    break;
                case 6:
                    pbFruit.Image = Image.FromFile(@"C:/Users/thleb/Documents/GitHub/CSharp_BTS-SIO/tomate_test/tomate/Resources/peche.jpg");
                    nomFruit = "pêche";
                    monPerroquet.Speak("Bonjour ! Je suis une pêche ! Ecris mon nom ...");
                    break;
                case 7:
                    pbFruit.Image = Image.FromFile(@"C:/Users/thleb/Documents/GitHub/CSharp_BTS-SIO/tomate_test/tomate/Resources/pomme.png");
                    nomFruit = "pomme";
                    monPerroquet.Speak("Bonjour ! Je suis une pomme ! Ecris mon nom ...");
                    break;
                case 8:
                    pbFruit.Image = Image.FromFile(@"C:/Users/thleb/Documents/GitHub/CSharp_BTS-SIO/tomate_test/tomate/Resources/radis.png");
                    nomFruit = "radis";
                    monPerroquet.Speak("Bonjour ! Je suis un radis ! Ecris mon nom ...");
                    break;
                case 9:
                    pbFruit.Image = Image.FromFile(@"C:/Users/thleb/Documents/GitHub/CSharp_BTS-SIO/tomate_test/tomate/Resources/salade.jpg");
                    nomFruit = "salade";
                    monPerroquet.Speak("Bonjour ! Je suis une salade ! Ecris mon nom ...");
                    break;
                case 10:
                    pbFruit.Image = Image.FromFile(@"C:/Users/thleb/Documents/GitHub/CSharp_BTS-SIO/tomate_test/tomate/Resources/ananas.jpg");
                    nomFruit = "ananas";
                    monPerroquet.Speak("Bonjour ! Je suis un ananas ! Ecris mon nom ...");
                    break;
                default:
                    monPerroquet.Speak("Au revoir, nous avons bien joué aujourd'hui, tous les 2");
                    Application.Exit();
                    break;
            }
        }

        private void tbFruit_TextChanged(object sender, EventArgs e)
        {

        }
    }
}