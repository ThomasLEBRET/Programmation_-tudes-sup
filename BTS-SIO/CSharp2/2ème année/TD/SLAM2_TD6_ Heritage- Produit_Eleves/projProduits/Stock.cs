
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace projProduitsHeritage {
    /// <summary>
    /// G�re le stock dans une entreprise
    /// Le stock is constitu� de 0, 1 ou plusieurs produits.
    /// </summary>
    [Serializable]
    public class Stock {
        // A list of the products.
        private List<Produit> stockCourant;

        /// <summary>
        /// initialise le stock - pas de produits au d�part
        /// </summary>
        public Stock() {
            stockCourant = new List<Produit>();
        }

        /// <summary>
        /// initialise le stock � partir du contenu
        /// du fichier en param�tre
        /// </summary>
        public Stock(string fichier) { // FOURNI
            this.DeSerialiser(fichier);
        }
        /// <summary>
        ///  Cherche un produit avec l'identidiant id pass� en param�tre.
        ///  renvoie le produit, ou null si id ne correspond pas
        ///  a un produit existsant
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Produit GetProduit(string id) {
            Produit p;
            int pos;

            p = new Produit(id);
            pos = stockCourant.IndexOf(p);
            if (pos >= 0)
            {
                return stockCourant[pos];
            }
            return null;
        }

        /// <summary>
        /// Ajoute un produit au stock
        ///
        /// </summary>
        /// <param name="item">objet produit � ajouter</param>
        /// <returns></returns>
        public bool AjouterProduit(Produit item) {
            bool existe;
            existe = stockCourant.Contains(item);
            // Si le produit n'existe pas d�j�
            if (!existe)
            {
                stockCourant.Add(item);
            }
            return !existe;

        }
        // se servir m�thode AjouterProduit pr�c�dente
        /// <summary>
        /// Ajoute un produit au stock
        /// caract�ristiques du produit pass�s en param�tre
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="prix"></param>
        /// <param name="stockInitial"></param>
        /// <returns>true si l'ajout a �t� effectu�, false, si le produit existe d�ja</returns>
        public bool AjouterProduit(string id, String name, float prix, int stockInitial) {
            // se servir de la m�hode ajouer pr�c�dente
            Produit p;
            p = new Produit(id, name, prix, stockInitial);
            return this.AjouterProduit(p);
        }
        /// <summary>
        /// renvoie la liste de tous les produits
        /// </summary>
        /// <returns></returns>
        public List<Produit> GetProduits() {
            return stockCourant;
        }

        /// <summary>
        /// renvoie la liste des produits dont le prix  
        /// est inf�rieur ou �gal au prix pass� en param�tre
        /// </summary>
        /// <param name="prix"></param>
        /// <returns></returns>
        public List<Produit> GetProduits(float prix) {
            List<Produit> listePrix;
            listePrix = new List<Produit>();

            foreach (Produit p in stockCourant)
            {
                if (p.GetPrix() <= prix)
                {
                    listePrix.Add(p);
                }
            }
            return listePrix;
        }

        /// <summary>
        /// renvoie la liste des produits dont la designation 
        /// contient la ch�ine  pass�e en param�tre
        /// </summary>
        /// <param name="prix"></param>
        /// <returns></returns>
        public List<Produit> GetProduits(string nom) {
            List<Produit> listeDesi;
            listeDesi = new List<Produit>();

            foreach (Produit p in stockCourant)
            {
                if (p.GetDesignation().ToUpper().Contains(nom.ToUpper()))
                {
                    listeDesi.Add(p);
                }
            }
            return listeDesi;
        }

        /// <summary>
        /// renvoie la liste des produits dont le stock  
        ///est sup�rieur ou �gal au stock pass� en param�tre
        /// </summary>
        /// <param name="prix"></param>
        /// <returns></returns>
        public List<Produit> GetProduits(int qteStock) {
            List<Produit> listeStock;
            listeStock = new List<Produit>();

            foreach (Produit p in stockCourant)
            {
                if (p.GetStock() >= qteStock)
                {
                    listeStock.Add(p);
                }
            }
            return listeStock;
        }


        /// <summary>
        /// Livraison  d'un produit.
        /// Augmente la quantit� en stock du produit du
        /// montant pass� en param�tre 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="amount"></param>
        /// <returns>true si le produit id existe et a donc �t� livr� false sinon</returns>
        public bool Livrer(string id, int amount) {
            // TO DO
            // tester si le produit id existe
            //appeler Livrer de la classe Produit
            Produit p;
            p = this.GetProduit(id);
            if (p != null)
            {
                p.Livrer(amount);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Vente  d'un produit.
        /// Diminue la quantit� en stock du produit du
        /// montant pass� en param�tre 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="amount"></param>
        /// <returns>true si la vente a pu se faire false  si le produit n'existe pas</returns>
        /// <exception cref="ExceptionStockInsuffisan"> stock insuffisant quantit� en stock</exception>
        public bool Vendre(string id, int amount) {
            // tester si le produit id existe
            // appeler Vendre de la clase produit - qui g�n�re une exception (Exeception StockInsuffisant)
            // s'il n'y a pas assez de stock - transmettre cette exception:
            //  catch (ExceptionStockInsuffisant si){
            //   throw si;
            // 

            Produit p;
            p = this.GetProduit(id);
            if (p != null)
            {
                try
                {
                    p.Vendre(amount);
                    return true;
                }
                catch (ExceptionStockInsuffisant si)
                {
                    throw si;
                }

            }
            else
            {
                return false;
            }

        }
        
        


        /// <summary>
        /// localise un produit avec l'id donn� et retourne le stock
        /// du produit correspondant. Si l'id n'est pas trouv� retourne -1
        /// </summary>
        /// <param name="id">l'id du produit</param>
        /// <returns>la quantit� en stock du produit</returns>
        public int GetStockProduit(string id) {
            // se  servir de la m�thode pr�c�dente GetProduit(id)
            Produit p;
          

            p = this.GetProduit(id);
           
            if (p != null)
            {
                return p.GetStock();
            }
            return -1;
        }

        public void Serialiser(string fichier) { // FOURNIE
            Stream streamE;

            streamE = File.Open(@fichier, FileMode.Create);
            BinaryFormatter bformatter = new BinaryFormatter();
            bformatter.Serialize(streamE, stockCourant);
            streamE.Close();
        }


        public void DeSerialiser(string fichier) { //FOURNIE
            Stream streamL;
            BinaryFormatter bformatter;

            streamL = File.Open(@fichier, FileMode.Open);
            bformatter = new BinaryFormatter();

            stockCourant = (List<Produit>)bformatter.Deserialize(streamL);

            streamL.Close();
        }

        /// <summary>
        /// retourne le nombre de produits dans le stock
        /// y compris ceux avec un stock �gal � 0
        /// </summary>
        /// <returns></returns>
        public int GetNbProduits() {

            return stockCourant.Count;
        }

        /// <summary>
        /// vidage de la liste
        /// </summary>
        public void Raz() {
            stockCourant.Clear();
            
        }
    }
}
