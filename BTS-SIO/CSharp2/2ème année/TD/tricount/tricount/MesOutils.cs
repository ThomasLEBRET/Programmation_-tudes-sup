using System;
using System.Drawing;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace tricount
{
    class MesOutils
    {
        public static ListBox ActualiserListBox(ListBox lb)
        {
            lb.Items.Clear();
            foreach (Depense d in DonneesPubliques.GetMonTricount().GetListeDepenses())
                lb.Items.Add(d.GetTitre() + " : " + d.GetMontant() + " par " + d.GetLePayeur());
            return lb;
        }

    }
}
