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
            :base(id,name,prix,stockInitial)
        {
           // TO DO
            this.SE = SE;
            this.support = support;
            this.prixLicence = prixLicence;
        }

        public string GetSE() {
            // TO DO
            return this.SE;
        }

        public string GetSupport() {
            // TO DO
            return this.support;
        }

       
        /// <summary>
        /// renvoie le prix du logiciel en tenant compte de 5 licences par defaut
        /// </summary>
        /// <returns></returns>
        public override float GetPrix(){
            // TO DO
            return base.GetPrix()*5;
        }
        public  float GetPrix(int nbLicence) {
            // TO DO
            return this.GetPrix()*nbLicence;
        }
       
        public void SetPrixLicence(int nouvPrix) {
            // TO DO
            this.prixLicence = nouvPrix;
        }
        public override string ToString() {
            // TO DO
            return base.ToString() + " SE : " + this.SE + " Support : " + this.support + " Prix Licence : " + this.prixLicence;
        }
      
    }
}
