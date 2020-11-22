using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace projProduitsHeritage {
    [Serializable]
    class JeuInformatique : Produit {
        private string SE;
        private string support;
        private int prixLicence;

        public JeuInformatique(string id, String name, float prix, int stockInitial, string SE, string support, int prixLicence) 
        {
           // TO DO
            
        }

        public string GetSE() {
            // TO DO
            return "";
        }

        public string GetSupport() {
            // TO DO
            return "";
        }

       
        /// <summary>
        /// renvoie le prix du logiciel en tenant compte de 5 licences par defaut
        /// </summary>
        /// <returns></returns>
        public override float GetPrix(){
            // TO DO
            return 0;
        }
        public  float GetPrix(int nbLicence) {
            // TO DO
            return 0;
        }
       
        public void SetPrixLicence(int nouvPrix) {
            // TO DO
        }
        public override string ToString() {
            // TO DO
            return "";
        }
      
    }
}
