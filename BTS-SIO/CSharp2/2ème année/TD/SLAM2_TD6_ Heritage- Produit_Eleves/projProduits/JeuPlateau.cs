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
             :base(id,name,prix,stockInitial)
        { // TO DO
            this.nbJoueur = nbJoueur;
            this.duree = duree;
            this.ageMin = ageMin;
        }
         public int GetNbJoueur() {
             // TO DO
             return this.nbJoueur;
         }
         public int GetDuree() {
             // TO DO
             return this.duree;
         }
         public int GetAgeMin() {
             //TO DO
             return this.ageMin;
         }
        public override string ToString() {
            //TO DO
            return base.ToString() + " Nb Joueur: " + this.nbJoueur + " Durée : " + this.duree + " Age Min: " + this.ageMin;
        }
    }
}
