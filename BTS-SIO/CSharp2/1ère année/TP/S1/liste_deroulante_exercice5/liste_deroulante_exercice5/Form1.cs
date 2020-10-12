using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace liste_deroulante_exercice5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cbChoix_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbChoix.SelectedIndex == 2)
            {
                cbChoix.SelectedItem = MessageBox.Show("Bravo !");
            }
            else
            {
                cbChoix.SelectedItem = MessageBox.Show("Essaye encore");
            }
        }
    }
}
