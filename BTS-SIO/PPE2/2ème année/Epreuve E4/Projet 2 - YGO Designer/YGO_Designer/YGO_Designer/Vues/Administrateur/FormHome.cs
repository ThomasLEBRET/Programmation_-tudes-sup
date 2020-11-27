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
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        private async void LoadDashboard()
        {
            int nbCartes = await ORMCarte.GetNbr();
            float nbMonstre = await ORMCarte.GetNbrMonstre();
            float nbMagie = await ORMCarte.GetNbrMagie();
            float nbPiege = await ORMCarte.GetNbrPiege();

            chPropCartes.Series.Clear();
            chPropCartes.Series.Add("Carte");
            lbNbCartes.Text = "Nombre de cartes : " + nbCartes;

            chPropCartes.Series["Carte"].Points.Add(nbMonstre);
            chPropCartes.Series["Carte"].Points[0].Color = Color.FromArgb(167, 103, 38);
            chPropCartes.Series["Carte"].Points[0].AxisLabel = "" + nbMonstre + "%";
            chPropCartes.Series["Carte"].Points[0].LegendText = "Monstre";

            chPropCartes.Series["Carte"].Points.Add(nbMagie);
            chPropCartes.Series["Carte"].Points[1].Color = Color.FromArgb(64, 130, 109);
            chPropCartes.Series["Carte"].Points[1].AxisLabel = "" + nbMagie + "%";
            chPropCartes.Series["Carte"].Points[1].LegendText = "Magie ";

            chPropCartes.Series["Carte"].Points.Add(nbPiege);
            chPropCartes.Series["Carte"].Points[2].Color = Color.FromArgb(204, 78, 92);
            chPropCartes.Series["Carte"].Points[2].AxisLabel = "" + nbPiege + "%";
            chPropCartes.Series["Carte"].Points[2].LegendText = "Piege";
        }

        private void FormHome_VisibleChanged(object sender, EventArgs e)
        {
            LoadDashboard();
        }    
    }
}
