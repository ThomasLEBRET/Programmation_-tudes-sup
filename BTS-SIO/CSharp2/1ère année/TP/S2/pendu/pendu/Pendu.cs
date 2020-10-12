using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace pendu
{
    class Pendu
    {
        private List<string> dictionnaire;
        private List<char> motUtilisateur;
        private string mot;
        private int nbrLettres;

        public Pendu()
        {
            dictionnaire = new List<string>();
            dictionnaire.Add("chat");
            dictionnaire.Add("chien");
            dictionnaire.Add("serpent");
            dictionnaire.Add("girafe");
            dictionnaire.Add("blaireau");
            dictionnaire.Add("ornithorynx");
            dictionnaire.Add("taupe");
            dictionnaire.Add("taureau");
            dictionnaire.Add("vache");
            dictionnaire.Add("poisson");
            dictionnaire.Add("lapin");
            Random alea = new Random();
            int choixMot = alea.Next(dictionnaire.Count());
            mot = dictionnaire[choixMot];
            motUtilisateur = new List<char>();
            for (int i = 0; i < mot.Length; i++)
            {
                motUtilisateur.Add('_');
            }
            nbrLettres = 0;
        }

        public int GetNbrLettres()
        {
            return nbrLettres;
        }

        public bool PlaceLettre(char uneLettre)
        {
            nbrLettres = 0;
            if (mot.Contains(uneLettre))
            {
                for (int i = 0; i < mot.Length; i++)
                {
                    if (uneLettre == mot[i])
                    {
                        motUtilisateur[i] = uneLettre;
                        nbrLettres++;
                    }
                }
                return true;
            }
            else
                return false;
        }

        public bool IsMotValide()
        {
            for (int i = 0; i < mot.Length; i++ )
            {
                if(motUtilisateur[i] != mot[i])
                    return false;
            }
            return true;
        }

        public override string ToString()
        {
            string unMot = "";
            for (int i = 0; i < motUtilisateur.Count(); i++)
            {
                unMot = unMot + motUtilisateur[i] + " ";
            }
            return unMot;
        }
    }
}
