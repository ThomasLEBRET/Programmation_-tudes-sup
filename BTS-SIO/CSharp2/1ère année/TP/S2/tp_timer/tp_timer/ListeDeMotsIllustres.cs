using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace tp_timer
{
    [Serializable]
    class ListeDeMotsIllustres 
    {
        private static List<MotIllustre> listeDeMotIllustre = new List<MotIllustre>();

        public static List<MotIllustre> GetListeDeMotIllustre()
        {
            return listeDeMotIllustre;
        }

        public static void SetListeMotIllustre(List<MotIllustre> uneListeDeMotIllustre)
        {
            listeDeMotIllustre = uneListeDeMotIllustre;
        }

        public static void ViderListe()
        {
            listeDeMotIllustre.Clear();
        }

        public static void AjouterElement(MotIllustre monElement)
        {
            listeDeMotIllustre.Add(monElement);
        }

        public static MotIllustre ObtenirElementParRang(int rang)
        {
            return listeDeMotIllustre[rang];
        }

        public static void ChargerTheme(string monTheme)
        {
            if (File.Exists(monTheme))
                MesOutils.DeserialiseListe(monTheme);
            else
            {
                switch (monTheme)
                {
                    case "mesAnimaux":
                        ListeDeMotsIllustres.CreerThemeAnimaux();
                        break;
                    case "monTheme":
                        ListeDeMotsIllustres.CreerMonTheme();
                        break;
                    default:
                        ListeDeMotsIllustres.CreerMonTheme();
                        break;
                }
            }
           MesOutils.DeserialiseListe(monTheme);
        }

        public static void CreerThemeAnimaux()
        {
            listeDeMotIllustre.Add(new MotIllustre("rino", (Image)Properties.Resources.rino));
            listeDeMotIllustre.Add(new MotIllustre("lion", (Image)Properties.Resources.lion));
            listeDeMotIllustre.Add(new MotIllustre("ecureuil", (Image)Properties.Resources.ecureil));
            MesOutils.SerialiseListe("mesAnimaux");
        }

        public static void CreerMonTheme()
        {
            listeDeMotIllustre.Add(new MotIllustre("chateau", (Image)Properties.Resources.chateau));
            listeDeMotIllustre.Add(new MotIllustre("nain", (Image)Properties.Resources.nainNomProf));
            listeDeMotIllustre.Add(new MotIllustre("M&M's", (Image)Properties.Resources.mms));
            listeDeMotIllustre.Add(new MotIllustre("piano", (Image)Properties.Resources.piano));
            MesOutils.SerialiseListe("monTheme");
        }
    }
}
