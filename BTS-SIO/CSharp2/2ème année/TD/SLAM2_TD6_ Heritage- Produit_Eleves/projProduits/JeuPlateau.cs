using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace projProduitsHeritage {
    [Serializable]
    class JeuPlateau : Produit {
        private int nbJoueur;
        private int duree;
        private int ageMin;

         public JeuPlateau(string id, String name, float prix, int stockInitial, int nbJoueur, int duree, int ageMin) 
        { // TO DO
            
        }
         public int GetNbJoueur() {
             // TO DO
             return 0;
         }
         public int GetDuree() {
             // TO DO
             return 0;
         }
         public int GetAgeMin() {
             //TO DO
             return 0;
         }
        public override string ToString() {
            //TO DO
            return "";
        }
    }
}
