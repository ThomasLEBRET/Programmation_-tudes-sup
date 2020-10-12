using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace imprimanteTP4_revision_winForm
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void lbConstruction_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (lbConstruction.ForeColor == System.Drawing.Color.Black)
            {
                lbConstruction.ForeColor = System.Drawing.Color.White;
            }
            else
            {
                lbConstruction.ForeColor = System.Drawing.Color.Black;
            }
        }
    }
}
