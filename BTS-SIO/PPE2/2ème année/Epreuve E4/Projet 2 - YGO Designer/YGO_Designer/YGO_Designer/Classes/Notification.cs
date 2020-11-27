using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YGO_Designer.Vues.Joueur;

namespace YGO_Designer.Classes
{
    public static class Notification
    {
        private static string description;
        
        private static FormAlert fa;
        private static FormInfo fi;
        private static FormSuccess fs;
        private static FormDanger fd;

        public static void ShowFormAlert(string otherDescription)
        {
            description = otherDescription;
            fa = new FormAlert();
            fa.Show();
        }

        public static void ShowFormInfo(string otherDescription)
        {
            description = otherDescription;
            fi = new FormInfo();
            fi.Show();
        }

        public static void ShowFormDanger(string otherDescription)
        {
            description = otherDescription;
            fd = new FormDanger();
            fd.Show();
        }

        public static void ShowFormSuccess(string otherDescription)
        {
            description = otherDescription;
            fs = new FormSuccess();
            fs.Show();
        }

        public static string GetDescription()
        {
            return description;
        }

        public static void SetDescription(string otherDescription)
        {
            description = otherDescription;
        }
    }
}
