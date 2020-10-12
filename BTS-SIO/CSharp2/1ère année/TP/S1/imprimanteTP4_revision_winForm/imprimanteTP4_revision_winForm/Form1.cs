using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace imprimanteTP4_revision_winForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            foreach (string nomImp in PrinterSettings.InstalledPrinters)
            {
                comboBox1.Items.Add(nomImp);
            } 
        }

        private void btAnnuler_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            /*Récupère les infos de l'imprimante choisie, le nombre de copies et l'étendue à imprimer*/
            string etendue = rbTout.Text;
            if(rbPageCours.Checked == true)
            {
                etendue = rbPageCours.Text;
            }
            else
                if (rbSelection.Checked == true)
                {
                    etendue = rbSelection.Text;
                }
            else
                if (rbPage.Checked == true)
                {
                    etendue = tbPages.Text;
                }
            MessageBox.Show("Vous avez choisi l'imprimante : " + comboBox1.SelectedItem +"\n"+
                            "Vous avez choisi de réaliser : " + numericUpDown1.Value  +" copie(s)\n"+
                            "Vous avez choisi une étendue d'impression : "+etendue);
        }

        private void btOption_Click(object sender, EventArgs e)
        {
            /*Afficher une fenêtre "fenêtre en construction" qui clignote*/
            AfficherForm2();
        }

        private void btRechercheImpr_Click(object sender, EventArgs e)
        {
            /*Afficher une fenêtre "fenêtre en construction" qui clignote*/
            AfficherForm2();
        }

        private void lbActif_Click(object sender, EventArgs e)
        {
            /*A modifier si imprimante active*/
        }

        private void lbLieu_Click(object sender, EventArgs e)
        {
            /*A modifier en fonction du lieu de l'imprimante*/
        }

        private void lbType_Click(object sender, EventArgs e)
        {
            /*A modifier en fonction du type de l'imprimante*/
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cbPagesParFeuille_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbEchelle_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbDocument_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbPages_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbPages_TextChanged(object sender, EventArgs e)
        {

        }

        private void rbPageCours_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPageCours.Checked == true && rbSelection.Enabled == false)
            {
                rbSelection.Enabled = true;
            }
            else
                if (rbSelection.Enabled == true && rbSelection.Checked == false)
                {
                    rbSelection.Enabled = false;
                }
        }

        private void rbTout_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbPage_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbSelection_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btProp_Click(object sender, EventArgs e)
        {
            AfficherForm2();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*Liste des imprimantes avec foreach*/
            
        }
        void AfficherForm2()
        {
            /*Afficher une fenêtre "fenêtre en construction" qui clignote*/
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void cbCopiesAssemblee_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCopiesAssemblee.Checked == true)
            {
                pictureBox1.Image = Image.FromFile(@"C:\Users\thleb\Downloads\cp2.PNG");
            }
            else
            {
                pictureBox1.Image = Image.FromFile(@"C:\Users\thleb\Downloads\cp1.PNG");
            }
        }
    }
}
