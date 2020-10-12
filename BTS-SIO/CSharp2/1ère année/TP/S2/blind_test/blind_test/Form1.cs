using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace blind_test
{
    public partial class Form1 : Form
    {
        string chemin = Application.StartupPath+"../../../";
        string interprete;
        Chanson blindTest; 
        public Form1()
        {
            InitializeComponent();
        }

        private void btQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btValider_Click(object sender, EventArgs e)
        {
            if(tbInterprete.Text == blindTest.GetTitre() || tbInterprete.Text == blindTest.GetInterprete())
            {
                MessageBox.Show("Bravo !");
            }
            else
            {
                MessageBox.Show("Réessayez !");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Playlist playlist = new Playlist();
            Chanson c1 = new Chanson("Billie Jean", "Mickael Jackson", 240, chemin + "billie_jean.wav");
            Chanson c2 = new Chanson("Dance Monkey", "Tones and I", 240, chemin + "dance_monkey.wav");
            playlist.AjouterChanson(c1);
            playlist.AjouterChanson(c2);
            blindTest = playlist.ChansonAleatoire();
            interprete = blindTest.GetInterprete();
            blindTest.JouerChanson();
            MessageBox.Show(chemin);
        }
    }
}
