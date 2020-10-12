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
    public partial class Form2 : Form
    {
        Form1 f1;
        Form3 f3;
        SpeechSynthesizer monPerroquet;
        public Form2()
        {
            InitializeComponent();
            f1 = new Form1();
            f3 = new Form3();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            monPerroquet = new SpeechSynthesizer();
            monPerroquet.SetOutputToDefaultAudioDevice();
            monPerroquet.Speak("Bonjour ! Je suis une tomate ! Ecris mon nom ...");
        }

        private void btValider_Click(object sender, EventArgs e)
        {
            int trouve = 0;
            int pasTrouve = 0;
            SoundPlayer gagne = new SoundPlayer("C:/Users/thleb/Documents/GitHub/CSharp_BTS-SIO/tomate/tomate/Resources/gagne.wav");
            SoundPlayer perdu = new SoundPlayer("C:/Users/thleb/Documents/GitHub/CSharp_BTS-SIO/tomate/tomate/Resources/perdu.wav");
            string tomate = tbTomate.Text;
            if (tomate.ToLower() == "tomate")
            {
                gagne.PlaySync();
                trouve++;
            }
            else
            {
                pasTrouve++;
                perdu.PlaySync();
            }
            f3.Show();
            this.Hide();
        }

        private void btRetour_Click(object sender, EventArgs e)
        {
            this.Hide();
            f1.Show();
        }
    }
}
