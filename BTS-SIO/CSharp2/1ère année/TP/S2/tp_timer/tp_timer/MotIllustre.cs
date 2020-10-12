using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace tp_timer
{
    [Serializable]
    class MotIllustre
    {
        private string mot;
        private Image imageMot;

        public MotIllustre(string unMot, Image uneImageMot)
        {
            imageMot = uneImageMot;
            mot = unMot;
        }

        public string GetMot()
        {
            return mot;
        }

        public Image GetImageMot()
        {
            return imageMot;
        }

        public void SetMot(string unMot)
        {
            mot = unMot;
        }

        public void SetImageMot(Image uneImageMot)
        {
            imageMot = uneImageMot;
        }
    }
}
