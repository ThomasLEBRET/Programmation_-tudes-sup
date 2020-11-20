using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YGO_Designer.Classes
{
    public static class Theme
    {
        public static void AjouterCarte(FormAjouterCartes f, Color backgroundF, Color backgroundC)
        {
            f.BackColor = backgroundF;
            foreach(Control c in f.Controls)
            {
                if (c is TextBox || c is RichTextBox || c is CheckedListBox || c is ComboBox)
                    c.BackColor = backgroundC;
            }
        }

        public static void AjouterCarteTabControl(TabControl tc, Color backgroundF, Color backgroundC)
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
