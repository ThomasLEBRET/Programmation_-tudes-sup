using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace plat
{
    public partial class Form1 : Form
    {
        private List<Plat> listePlats;
        public Form1()
        {
            InitializeComponent();

            listePlats = new List<Plat>();
            listePlats.Add(new Plat("nom1", "Soupe", 20, 10, false, false));
            listePlats.Add(new Plat("nom10", "Soupe",10, 200, false, false));
            listePlats.Add(new Plat("nom4", "Dessert", 10, 34, false, false));
            listePlats.Add(new Plat("nom34", "Dessert", 3, 100, false, false));
            listePlats.Add(new Plat("nom3", "Plat", 10, 100, false, false));
            listePlats.Add(new Plat("nom13", "Salade", 30, 200, false, false));
            listePlats.Add(new Plat("nom32", "Salade", 10, 300, false, false));
            listePlats.Add(new Plat("nom2", "Salade", 20, 100, false, false));

            ActualiserListBox();
        }

        private void ActualiserListBox()
        {
            lbPlats.Items.Clear();
            lbPlats.Items.AddRange(listePlats.ToArray());
        }

        private void btTriDefaut_Click(object sender, EventArgs e)
        {
            listePlats.Sort();
            ActualiserListBox();
        }

        private void BtTriCatPrix_Click(object sender, EventArgs e)
        {
            listePlats.Sort(new CompareCategPrix());
            ActualiserListBox();
        }

        private void btTriCatCal_Click(object sender, EventArgs e)
        {
            listePlats.Sort(new CompareCategCalories());
            ActualiserListBox();
        }
    }
}
