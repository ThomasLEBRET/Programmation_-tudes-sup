using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace inscription_serialisation
{
    class Devine
    {
        private List<string> dictionnaire;
        private string mot;

        //Suppression de la sélection d'un mot aléatoire
        public  Devine()
        {
            //Refactorisation du code
            dictionnaire = new List<string> { "arbre", "carte", "dé", "montagne", "lion", "jardin","téléphone", "zèbre", "fenêtre" };
        }

        //Nouvelle méthode choix mot aléatoire (c'était avant dans le constructeur)
        public string PiocheNouveauMot()
        {
            Random hasard = new Random();
            int pioche = hasard.Next(dictionnaire.Count());
            mot = dictionnaire[pioche];
            return mot;
        }


        public string GetMot()
        {
            return mot;
        }

        //Ajout mutateur mot
        public void SetMot(string unMot)
        {
            mot = unMot;
        }

        //Ajout accesseur dictionnaire
        public List<string> GetDictionnaire()
        {
            return dictionnaire;
        }

        //Ajout mutateur dictionnaire
        public void SetDictionnaire(List<string> unDictionnaire)
        {
            dictionnaire = unDictionnaire;
        }

        public string AfficheMotUtilisateur()
        {
            string monMot = mot.Substring(1);
            monMot = "_" + monMot;
            return monMot;
        }

        public bool Reponse(string maReponse)
        {
            if (maReponse.Substring(0, 1).ToUpper() == mot.Substring(0, 1).ToUpper())
                return true;
            return false;
        }

        public void AffichageImage(PictureBox pb, string mot)
        {
          switch(mot)
          {
              case "arbre":
                  pb.Image = (Image)Properties.Resources.arbre;
                  break;
              
              case "dé":
                  pb.Image = (Image)Properties.Resources.dé;
                  break;
              
              case "téléphone":
                  pb.Image = (Image)Properties.Resources.téléphone;
                  break;
              
              case "jardin":
                  pb.Image = (Image)Properties.Resources.jardin;
                  break;
              
              case "carte":
                  pb.Image = (Image)Properties.Resources.carte;
                  break;
              
              case "zèbre":
                  pb.Image = (Image)Properties.Resources.zèbre;
                  break;

              case "montagne":
                  pb.Image = (Image)Properties.Resources.montagne;
                  break;

              case "fenêtre":
                  pb.Image = (Image)Properties.Resources.fenêtre;
                  break;

              case "lion":
                  pb.Image = (Image)Properties.Resources.lion;
                  break;
          }
        }
    }
}
