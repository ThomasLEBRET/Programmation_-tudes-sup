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
    /// <summary>
    /// Formulaire d'accueil pour un administrateur
    /// </summary>
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Procédure privée asynchrone chargeant les données du diagramme statistique des cartes de la base de données
        /// </summary>
        private async void LoadDashboard()
        {
            //Récupère le nombre de cartes de la base
            int nbCartes = await ORMCarte.GetNbr();

            //Affiche le ratio de cartes
            chPropCartes.Series.Clear();
            chPropCartes.Series.Add("Monstre");
            chPropCartes.Series.Add("Magie");
            chPropCartes.Series.Add("Piege");

            lbNbCartes.Text = "Nombre de cartes : " + nbCartes;

            //Charge et affiche le ratio de monstre
            float nbMonstre = await ORMCarte.GetNbrMonstre();
            chPropCartes.Series["Monstre"].Points.Add(nbMonstre);
            chPropCartes.Series["Monstre"].Points[0].Color = Color.FromArgb(167, 103, 38);
            chPropCartes.Series["Monstre"].Points[0].Label = "" + nbMonstre + "%";
            chPropCartes.Series["Monstre"].Points[0].LegendText = "Monstre";

            //Charge et affiche le ratio de magie
            float nbMagie = await ORMCarte.GetNbrMagie();
            chPropCartes.Series["Magie"].Points.Add(nbMagie);
            chPropCartes.Series["Magie"].Points[0].Color = Color.FromArgb(64, 130, 109);
            chPropCartes.Series["Magie"].Points[0].Label = "" + nbMagie + "%";
            chPropCartes.Series["Magie"].Points[0].LegendText = "Magie ";

            //Charge et affiche le ratio de piège
            float nbPiege = await ORMCarte.GetNbrPiege();
            chPropCartes.Series["Piege"].Points.Add(nbPiege);
            chPropCartes.Series["Piege"].Points[0].Color = Color.FromArgb(204, 78, 92);
            chPropCartes.Series["Piege"].Points[0].Label = "" + nbPiege + "%";
            chPropCartes.Series["Piege"].Points[0].LegendText = "Piege";

        }

        /// <summary>
        /// Charge le diagramme statistique des cartes de la base de données
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormHome_VisibleChanged(object sender, EventArgs e)
        {
            //Charge le graphique
            LoadDashboard();
        }
    }
}
