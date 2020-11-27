using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YGO_Designer.Classes
{
    /// <summary>
    /// Classe static définissant un thème de couleur pour une carte
    /// </summary>
    public static class Theme
    {
        /// <summary>
        /// Ajoute le set de couleurs au formulaire
        /// </summary>
        /// <param name="f">Le formulaire AjouterCartes</param>
        /// <param name="backgroundF">la couleur de fond</param>
        /// <param name="backgroundC">La couleur des contrôles</param>
        public static void Add(FormAjouterCartes f, Color backgroundF, Color backgroundC)
        {
            f.BackColor = backgroundF;
            foreach(Control c in f.Controls)
            {
                if (c is TextBox || c is RichTextBox || c is CheckedListBox || c is ComboBox)
                    c.BackColor = backgroundC;
            }
        }

        /// <summary>
        /// Ajoute le set de couleurs au TabControl de la carte
        /// </summary>
        /// <param name="tc">Le TabControl</param>
        /// <param name="backgroundF">La couleur de fond</param>
        /// <param name="backgroundC">La couleur des contrôles</param>
        public static void AddTabControl(TabControl tc, Color backgroundF, Color backgroundC)
        {
            tc.SelectedTab.BackColor = backgroundF;
            foreach (Control c in tc.SelectedTab.Controls)
            {
                if(c is Button)
                    c.BackColor = Color.FromArgb(222, 184, 135);
                if (c is TextBox || c is RichTextBox || c is CheckedListBox || c is TabControl || c is ComboBox)
                    c.BackColor = backgroundC;
            }
        }
    }
}
