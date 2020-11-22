using System;
using System.Collections.Generic;
using System.Text;

namespace projProduitsHeritage
{
    /**
     *  produit vendu par l'entreprise
     */
    [Serializable]
    public class Produit
    {
        private string id;
        private string nom;
        private int quantiteStok;
        private float prix;
        
        
        
        public Produit(string id, String name, float prix, int stockInitial)
        { 
            this.id = id;
            this.nom = name;
            this.prix = prix;
            this.quantiteStok = stockInitial;
        }
        
        /// <summary>
        /// constructeur stock initialisé à 0
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="prix"></param>
        public Produit(string id, String name, float prix): this(id,name,prix,0)
        { 
                
        }
        
        public Produit(string id) : this(id, "", 0, 0) // appel 1er constructeur 
        { 
        }
        public Produit()   { // A SUPPRIMER
        } 

        /// <summary>
        /// retourne l'id du produit
        /// </summary>
        /// <returns>int id </returns>
        public string GetID()
        {
            return this.id;
        }

        /// <summary>
        /// 
        /// </retourn le nom du produit<summary>
        /// <returns></returns>
        public String GetDesignation()
        {
            return this.nom;
        }

        /// <summary>
        /// renvoie la quantité en stock
        /// </summary>
        /// <returns></returns>
        public int GetStock()
        {
            return this.quantiteStok;
        }
        /// <summary>
        /// retourne le prix du produit
        /// </summary>
        /// <returns></returns>
        public virtual float GetPrix()
        {
            return this.prix;
        }
       

        /// <summary>
        /// retourne une string contenant les caractéristiques du produit
        /// </summary>
        /// <returns></returns>
        public override String ToString()
        {
            // TO DO
            return this.id + ": " +  this.nom + " qte : " + this.quantiteStok + " prix : "+this.prix;
        }
    
        /// <summary>
        /// approvisonnement du produit avec la quantité
        /// passée en paramètre
        /// si la quantité en paramètre est <=0  Livrer ne fait rien
        /// </summary>
        /// <param name="quantite">doit être supérieur à 0</param>
        public void Livrer(int quantite)
        { 
            if (quantite > 0)
            {
                this.quantiteStok += quantite;
            }
        }

        /// <summary>
        /// Vends une quantité de ce produit
        /// </summary>
        /// <param name="quantite">doit être > 0</param>
        /// <exception cref="ExceptionStockInsuffisant">Stock insuffisant </exception>
        public void Vendre(int quantite)
        { // TO DO
            // lance une exception ExxeptionStockInsuffisant avec un message d'erreur avec la quantité en stock
            // quand le stock est insuffisant pour honorer la vente :
            // throw new ExceptionStockInsuffisant(message erreur)
            if (quantite > 0 && this.quantiteStok >= quantite)
            {
                this.quantiteStok -= quantite;
            }
            else
            {
                if (this.quantiteStok < quantite)
                {
                    throw new ExceptionStockInsuffisant("Stock insuffisant "+ this.quantiteStok + " unités");
                }
            }
            
        }
        /// <summary>
        /// détermine si l'objet courant et l'objet passé en paramètre sont égaux
        /// sont égaux si ils ont le même id
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
           
            Produit p2;

            if (obj != null && obj is Produit)
            {
                p2 = (Produit)obj;
                if (this.id.ToUpper() == p2.id.ToUpper())
                {
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// modifie le prix du produit
        /// </summary>
        /// <param name="p"></param>
        public void SetPrix(float p) {
            this.prix = p;
        }

        /// <summary>
        /// modifie le nom du produit
        /// </summary>
        /// <param name="nouvDesi"></param>
        public void SetDesignation(string nouvDesi) {
            this.nom = nouvDesi;
        }
    }
}
