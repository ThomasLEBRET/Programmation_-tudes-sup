using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using YGO_Designer.Classes;

namespace YGO_Designer.Vues.Joueur
{
    public partial class FormSuccess : Form
    {
        public FormSuccess()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - 400, Screen.PrimaryScreen.WorkingArea.Height - 150);
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

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
            lbDesc.Text = Notification.GetDescription();
        }
    }
}
