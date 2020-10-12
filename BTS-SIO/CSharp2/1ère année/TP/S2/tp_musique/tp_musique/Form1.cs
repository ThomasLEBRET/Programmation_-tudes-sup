using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace tp_musique
{
    public partial class Form1 : Form
    {
        private SoundPlayer sp;
        public Form1()
        {
            InitializeComponent();
        }

        private void btQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btGuitare_Click(object sender, EventArgs e)
        {
            sp = new SoundPlayer(Properties.Resources.sonGuitare);
            sp.Play();
        }
    }
}
