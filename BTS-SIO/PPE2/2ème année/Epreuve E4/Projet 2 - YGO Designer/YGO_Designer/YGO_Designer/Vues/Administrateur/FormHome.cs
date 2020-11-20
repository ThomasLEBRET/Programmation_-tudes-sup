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

        private void FormHome_VisibleChanged(object sender, EventArgs e)
        {
            chPropCartes.Series.Clear();
            chPropCartes.Series.Add("Carte");
            lbNbCartes.Text =  "Nombre de cartes : " + ORMCarte.GetNbCartes();

            chPropCartes.Series["Carte"].Points.Add(ORMCarte.GetNbCartesMonstre());
            chPropCartes.Series["Carte"].Points[0].Color = Color.FromArgb(167, 103, 38);
            chPropCartes.Series["Carte"].Points[0].AxisLabel = "" + ORMCarte.GetNbCartesMonstre() + "%";
            chPropCartes.Series["Carte"].Points[0].LegendText = "Monstre";

            chPropCartes.Series["Carte"].Points.Add(ORMCarte.GetNbCartesMagie());
            chPropCartes.Series["Carte"].Points[1].Color = Color.FromArgb(64, 130, 109);
            chPropCartes.Series["Carte"].Points[1].AxisLabel = "" + ORMCarte.GetNbCartesMagie() + "%";
            chPropCartes.Series["Carte"].Points[1].LegendText = "Magie ";

            chPropCartes.Series["Carte"].Points.Add(ORMCarte.GetNbCartesPiege());
            chPropCartes.Series["Carte"].Points[2].Color = Color.FromArgb(204, 78, 92);
            chPropCartes.Series["Carte"].Points[2].AxisLabel = "" + ORMCarte.GetNbCartesPiege() + "%";
            chPropCartes.Series["Carte"].Points[2].LegendText = "Piege";
        }    
    }
}
