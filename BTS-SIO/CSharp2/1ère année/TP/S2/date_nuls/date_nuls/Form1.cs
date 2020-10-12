using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace date_nuls
{
    public partial class Form1 : Form
    {
        DatePourLesNuls date1, date2;
        public Form1()
        {
            InitializeComponent();
        }

        private void nudJour_ValueChanged(object sender, EventArgs e)
        {

        }

        private void nudMois_ValueChanged(object sender, EventArgs e)
        {

        }

        private void nudAnnee_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btFormatCourt_Click(object sender, EventArgs e)
        {
            int jour = Convert.ToInt16(nudJour.Text);
            int mois = Convert.ToInt16(nudMois.Text);
            int annee = Convert.ToInt16(nudAnnee.Text);
            date1.SetJour(jour);
            date1.SetMois(mois);
            date1.SetAnnee(annee);
            MessageBox.Show(date1.FormatCourt());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            date1 = new DatePourLesNuls();
        }

        private void btQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btFormatLong_Click(object sender, EventArgs e)
        {
            int jour = Convert.ToInt16(nudJour.Text);
            int mois = Convert.ToInt16(nudMois.Text);
            int annee = Convert.ToInt16(nudAnnee.Text);
            date2 = new DatePourLesNuls(jour, mois, annee);
            MessageBox.Show(date2.FormatLong());
        }

        private void btEstBissextile_Click(object sender, EventArgs e)
        {
            int jour = Convert.ToInt16(nudJour.Text);
            int mois = Convert.ToInt16(nudMois.Text);
            int annee = Convert.ToInt16(nudAnnee.Text);
            date1.SetJour(jour);
            date1.SetMois(mois);
            date1.SetAnnee(annee);
            if (date1.CorrespondAAnneeBissextile())
                MessageBox.Show("L'année est bissextile");
            else
                MessageBox.Show("L'année n'est pas bissextile");
        }
    }
}
