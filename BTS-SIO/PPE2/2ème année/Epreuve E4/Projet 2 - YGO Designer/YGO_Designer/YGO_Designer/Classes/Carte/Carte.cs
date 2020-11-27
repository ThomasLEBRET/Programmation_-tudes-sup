using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace YGO_Designer.Classes.Carte
{
    /// <summary>
    /// Classe mère permettant de créer un objet Carte 
    /// </summary>
    public class Carte
    {
        private int no; //PK
        private Attribut attr; 
        private string nom;
        private string description;
        private List<Effet> eff;
        private int nbExemplaireDansDeck;

        /// <summary>
        /// Constructeur par défaut de la classe mère
        /// </summary>
        public Carte()
        {
            this.eff = new List<Effet>();
            this.no = 00000000;
            this.attr = new Attribut();
            this.nom = "Unknow";
            this.description = "Void";
            this.nbExemplaireDansDeck = -1;
        }

        /// <summary>
        /// Surcharge du constructeur de la classe mère affectant aux paramètres privés les paramètres 
        /// passés par l'en-tête de la surcharge
        /// </summary>
        /// <param name="eff">L'effet</param>
        /// <param name="no">Le numéro</param>
        /// <param name="attr">L'attribut</param>
        /// <param name="nom">Le nom</param>
        /// <param name="description">La description</param>
        public Carte(List<Effet> eff, int no, Attribut attr, string nom, string description)
        {
            this.eff = new List<Effet>();
            this.eff = eff;
            this.no = no;
            this.attr = attr;
            this.nom = nom;
            this.description = description;
            this.nbExemplaireDansDeck = -1;
        }

        /// <summary>
        /// Surcharge du constructeur de la classe mère réutiliant les paramètres de la précédente surcharge du constructeur
        /// et ajoute l'affectation du paramètre concernant le nombre d'exemplaire d'une carte dans un deck pour un utilisateur
        /// de type Joueur
        /// </summary>
        /// <param name="eff"></param>
        /// <param name="no"></param>
        /// <param name="attr"></param>
        /// <param name="nom"></param>
        /// <param name="description"></param>
        /// <param name="nbExemplaireDansDeck"></param>
        public Carte(List<Effet> eff, int no, Attribut attr, string nom, string description, int nbExemplaireDansDeck)
            :this(eff,no,attr,nom,description)
        {
            this.nbExemplaireDansDeck = nbExemplaireDansDeck;
        }

        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
                return false;
            else
            {
                Carte c = (Carte)obj;
                return no == c.no;
            }
        }

        public override int GetHashCode()
        {
            return this.no;
        }

        /// <summary>
        /// Redéfinition de la méthode ToString affichant le numéro, l'attribut et le nom de la carte si le nombre d'exemplaire 
        /// vaut -1, soit la valeur par défaut de la première surcharge du constructeur ou renvoi le nombre d'exemplaire d'une carte
        /// dans un deck sinon
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string maCarte = "";
            if (nbExemplaireDansDeck <= 0)
                maCarte = this.no + " : " + this.attr + " " + this.nom;
            else
                maCarte = this.no + " : " + this.attr + " " + this.nom + " x" + this.GetNbExemplaireFromDeck();
            return maCarte;
        }

        /// <summary>
        /// Accesseur de la liste d'effets associés à une carte (un effet = une action octroyée au joueur par une carte)
        /// </summary>
        /// <returns>Une liste d'effets</returns>
        public List<Effet> GetListEffets()
        {
            return this.eff;
        }

        /// <summary>
        /// Accesseur du numéro de la carte
        /// </summary>
        /// <returns>Le numéro de la carte</returns>
        public int GetNo()
        {
            return this.no;
        }

        /// <summary>
        /// Accesseur de l'attribut de la carte
        /// </summary>
        /// <returns>Un objet de type Attribut</returns>
        public Attribut GetAttr()
        {
            return this.attr;
        }

        /// <summary>
        /// Accesseur de le nom de la carte
        /// </summary>
        /// <returns>Le nom de la carte</returns>
        public string GetNom()
        {
            return this.nom;
        }

        /// <summary>
        /// Accesseur de la description de la carte
        /// </summary>
        /// <returns>La description de la carte</returns>
        public string GetDescription()
        {
            return this.description;
        }
        /// <summary>
        /// Accesseur du nombre d'exemplaire d'une carte au sein d'un objet Deck
        /// </summary>
        /// <returns>Le nombre d'exemplaires d'une carte</returns>
        public int GetNbExemplaireFromDeck()
        {
            return this.nbExemplaireDansDeck;
        }

    }
}
