using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YGO_Designer.Vues.Joueur
{
    public partial class FormSuccess : Form
    {
        private string description;
        public FormSuccess()
        {
            InitializeComponent();

            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - 400, Screen.PrimaryScreen.WorkingArea.Height - 150);
        }

        public void SetDescription(string description)
        {
            this.description = description;
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timClose_Tick(object sender, EventArgs e)
        {
            if (this.Opacity == 0)
                this.Close();
            this.Opacity -= 0.10;
        }

        private void timBeforeClose_Tick(object sender, EventArgs e)
        {
            timBeforeClose.Enabled = false;
            timClose.Enabled = true;
        }

        private void FormSuccess_Load(object sender, EventArgs e)
        {
            lbDesc.Text = description;
        }
    }
}
