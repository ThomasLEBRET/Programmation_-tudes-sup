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

namespace projet_enfant
{
    public partial class Form3 : Form
    {
        Form1 f1;
        SpeechSynthesizer monPerroquet;
        public Form3()
        {
            InitializeComponent();
        }

        private void btValider_Click(object sender, EventArgs e)
        {
            SoundPlayer gagne = new SoundPlayer("C:/Users/thleb/Documents/GitHub/CSharp_BTS-SIO/tomate/tomate/Resources/gagne.wav");
            SoundPlayer perdu = new SoundPlayer("C:/Users/thleb/Documents/GitHub/CSharp_BTS-SIO/tomate/tomate/Resources/perdu.wav");
            string orange = tbOrange.Text;
            if (orange.ToLower() == "orange")
            {
                gagne.PlaySync();
            }
            else
            {
                perdu.PlaySync();
            }
            f1.Show();
            this.Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            monPerroquet = new SpeechSynthesizer();
            monPerroquet.SetOutputToDefaultAudioDevice();
            monPerroquet.Speak("Bonjour ! Je suis une orange ! Ecris mon nom ...");
            f1 = new Form1();
        }

        private void btRetour_Click(object sender, EventArgs e)
        {
            f1.Show();
            this.Hide();
        }
    }
}
