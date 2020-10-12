using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace date_nuls
{
    class DatePourLesNuls
    {
        private int jour;
        private int mois;
        private int annee;

        public DatePourLesNuls()
        {

        }

        public DatePourLesNuls(int unJour, int unMois, int uneAnnee)
        {
            jour = unJour;
            mois = unMois;
            annee = uneAnnee;
        }

        public int GetJour()
        {
            return jour;
        }

        public int GetMois()
        {
            return mois;
        }

        public int GetAnnee()
        {
            return annee;
        }

        public void SetJour(int unJour)
        {
            jour = unJour;
        }

        public void SetMois(int unMois)
        {
            mois = unMois;
        }

        public void SetAnnee(int uneAnnee)
        {
            annee = uneAnnee;
        }

        public string FormatCourt()
        {
            string dateCourt = (jour + "/" + mois + "/" + annee).ToString();
            return dateCourt;
        }

        public string FormatLong()
        {
            string moisEnClair = "";
            switch(mois)
            {
                case 1:
                    moisEnClair = "Janvier";
                    break;
                case 2:
                    moisEnClair = "Février";
                    break;
                case 3:
                    moisEnClair = "Mars";
                    break;
                case 4:
                    moisEnClair = "Avril";
                    break;
                case 5:
                    moisEnClair = "Mai";
                    break;
                case 6:
                    moisEnClair = "Juin";
                    break;
                case 7:
                    moisEnClair = "Juillet";
                    break;
                case 8:
                    moisEnClair = "Août";
                    break;
                case 9:
                    moisEnClair = "Septembre";
                    break;
                case 10:
                    moisEnClair = "Octobre";
                    break;
                case 11:
                    moisEnClair = "Novembre";
                    break;
                case 12:
                    moisEnClair = "Décembre";
                    break;
            }
            string dateLongue = (jour + "/" + moisEnClair + "/" + annee).ToString();
            return dateLongue;
        }

        public bool CorrespondAAnneeBissextile()
        {
            return DateTime.IsLeapYear(annee);
        }
    }
}
