using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YGO_Designer.Classes;
using YGO_Designer.Classes.Carte;
using YGO_Designer.Classes.Carte.Attribut_Carte;
using YGO_Designer.Classes.Carte.TypeCarte;
using YGO_Designer.Classes.ORM;

namespace YGO_Designer
{
    public partial class FormTemplateAdmin : Form
    {
        private Form activeForm = null;

        private FormHome fh;
        private FormAjouterCartes fac;
        private FormChercherCarte fcc;
        public FormTemplateAdmin()
        {
            InitializeComponent();
        }

        private void btHome_Click(object sender, EventArgs e)
        {
            openChildForm(fh);
        }

        private void btAjouterCarte_Click(object sender, EventArgs e)
        {
            openChildForm(fac);
        }

        private void btChercherCarte_Click(object sender, EventArgs e)
        {
                openChildForm(fcc);
        }

        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Hide();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnFormChild.Controls.Add(childForm);
            pnFormChild.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void FormTemplate_Load(object sender, EventArgs e)
        {
            fh = new FormHome();
            fac = new FormAjouterCartes();
            fcc = new FormChercherCarte();
            openChildForm(fh);
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
