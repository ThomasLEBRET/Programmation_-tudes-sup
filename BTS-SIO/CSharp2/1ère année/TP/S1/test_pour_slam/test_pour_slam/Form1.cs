using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace test_pour_slam
{
    public partial class Form1 : Form
    {
        int pts;
        public Form1()
        {
            InitializeComponent();
            pts = 0;
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btScore_Click(object sender, EventArgs e)
        {
            if (cbChoix.SelectedIndex == 2)
            {
                pts++;
            }
            if (rb1.Checked == true)
            {
                pts++;
            }
            int ptsCb = 0;
            if (cbFor.Checked == true)
            {
                ptsCb++;
            }
            if (cbWhile.Checked == true)
            {
                ptsCb++;
            }
            if (cbIf.Checked == true)
            {
                ptsCb--;
            }
            if (cbSwitch.Checked == true)
            {
                ptsCb--;
            }
            if (ptsCb < 0)
            {
                ptsCb = 0;
            }
            pts += ptsCb;
            MessageBox.Show("Vous avez obtenu : " + pts + "/5", "Votre score");
            pts = 0;
            btCmd.Enabled = true;
            btWF.Enabled = true;
            cbFor.Checked = false;
            cbIf.Checked = false;
            cbWhile.Checked = false;
            cbSwitch.Checked = false;
            rb1.Checked = false;
            rb2.Checked = false;
            rb3.Checked = false;
            rb4.Checked = false;
            cbChoix.Text = "Choisir entre les 5 réponses";
        }

        private void btCmd_Click(object sender, EventArgs e)
        {
            btCmd.Enabled = false;
            btWF.Enabled = false;
            pts++;
        }

        private void btWF_Click(object sender, EventArgs e)
        {
            btCmd.Enabled = false;
            btWF.Enabled = false;
        }
    }
}
