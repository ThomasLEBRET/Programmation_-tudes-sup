using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace inscription_serialisation
{
    public partial class Info : Form
    {
        public Info()
        {
            InitializeComponent();
        }

        private void pbQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu menu = new Menu();
            menu.Show();
        }

        private void Info_Load(object sender, EventArgs e)
        {
            lbMemory.MaximumSize = new Size(300, 200);
            lbMemory.AutoSize = true;
            lbDevine.MaximumSize = new Size(300, 200);
            lbDevine.AutoSize = true;
        }
    }
}
