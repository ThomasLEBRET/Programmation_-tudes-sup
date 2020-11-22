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
        /// constructeur stock initialis� � 0
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
        /// renvoie la quantit� en stock
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
        /// retourne une string contenant les caract�ristiques du produit
        /// </summary>
        /// <returns></returns>
        public override String ToString()
        {
            // TO DO
            return this.id + ": " +  this.nom + " qte : " + this.quantiteStok + " prix : "+this.prix;
        }
    
        /// <summary>
        /// approvisonnement du produit avec la quantit�
        /// pass�e en param�tre
        /// si la quantit� en param�tre est <=0  Livrer ne fait rien
        /// </summary>
        /// <param name="quantite">doit �tre sup�rieur � 0</param>
        public void Livrer(int quantite)
        { 
            if (quantite > 0)
            {
                this.quantiteStok += quantite;
            }
        }

        /// <summary>
        /// Vends une quantit� de ce produit
        /// </summary>
        /// <param name="quantite">doit �tre > 0</param>
        /// <exception cref="ExceptionStockInsuffisant">Stock insuffisant </exception>
        public void Vendre(int quantite)
        { // TO DO
            // lance une exception ExxeptionStockInsuffisant avec un message d'erreur avec la quantit� en stock
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
                    throw new ExceptionStockInsuffisant("Stock insuffisant "+ this.quantiteStok + " unit�s");
                }
            }
            
        }
        /// <summary>
        /// d�termine si l'objet courant et l'objet pass� en param�tre sont �gaux
        /// sont �gaux si ils ont le m�me id
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
