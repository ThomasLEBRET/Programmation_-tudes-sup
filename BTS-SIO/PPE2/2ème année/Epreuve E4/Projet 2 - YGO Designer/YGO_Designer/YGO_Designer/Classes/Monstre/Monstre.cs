using System;
using System.Collections.Generic;
using System.Text;

namespace YGO_Designer.Classes.Carte
{
    /// <summary>
    /// La classe fille hérité de la classe Carte
    /// </summary>
    public class Monstre : Carte
    {
        private string typeMo;
        private string attrMo;
        private int nbrEtoiles;
        private int atk;
        private int def;
        private string sousType;

        /// <summary>
        /// Constructeur par défaut de la classe
        /// </summary>
        /// <param name="typeMo">Le type</param>
        /// <param name="attrMo">L'attribut</param>
        /// <param name="nivMo">Le niveua</param>
        /// <param name="atk">L'attaque de base</param>
        /// <param name="def">La défense de base</param>
        /// <param name="sousType">Le ou les sous-type(s)</param>
        /// <param name="eff">La liste des effets</param>
        /// <param name="no">Le numéro</param>
        /// <param name="attr">L'attribut</param>
        /// <param name="nom">Le nom</param>
        /// <param name="description">La description</param>
        public Monstre(string typeMo, string attrMo, int nivMo, int atk, int def, string typesCarteMonstre, List<Effet> eff, int no, Attribut attr, string nom, string description)
            : base(eff, no, attr, nom, description, -1)
        {
            this.typeMo = typeMo;
            this.attrMo = attrMo;
            this.nbrEtoiles = nivMo;
            this.atk = atk;
            this.def = def;
            this.sousType = typesCarteMonstre;
        }

        /// <summary>
        /// Surcharge du constructeur de la classe prenant en compte le nombre d'exemplaire du monstre dans un deck
        /// </summary>
        /// <param name="typeMo">Le type</param>
        /// <param name="attrMo">L'attribut</param>
        /// <param name="nivMo">Le niveua</param>
        /// <param name="atk">L'attaque de base</param>
        /// <param name="def">La défense de base</param>
        /// <param name="sousType">Le ou les sous-type(s)</param>
        /// <param name="eff">La liste des effets</param>
        /// <param name="no">Le numéro</param>
        /// <param name="attr">L'attribut</param>
        /// <param name="nom">Le nom</param>
        /// <param name="description">La description</param>
        /// <param name="nbExemplaireDansDeck">Le nombre d'exemplaire du monstre dans un deck</param>
        public Monstre(string typeMo, string attrMo, int nivMo, int atk, int def, string typesCarteMonstre, List<Effet> eff, int no, Attribut attr, string nom, string description, int nbExemplaireDansDeck)
            : base(eff, no, attr, nom, description, nbExemplaireDansDeck)
        {
            this.typeMo = typeMo;
            this.attrMo = attrMo;
            this.nbrEtoiles = nivMo;
            this.atk = atk;
            this.def = def;
            this.sousType = typesCarteMonstre;
        }

        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetTypeM().Equals(obj.GetType()))
                return false;
            else
            {
                Monstre m = (Monstre)obj;
                return this.GetNo() == m.GetNo();
            }
        }

        public override int GetHashCode()
        {
            return this.GetNo();
        }

        /// <summary>
        /// Accesseur du type du monstre
        /// </summary>
        /// <returns>Le type du monstre</returns>
        public string GetTypeM()
        {
            return this.typeMo;
        }

        /// <summary>
        /// Accesseur de l'attribut du monstre (son élément)
        /// </summary>
        /// <returns>L'attribut élémentaire du monstre</returns>
        public string GetAttribut()
        {
            return this.attrMo;
        }

        /// <summary>
        /// Accesseur du niveau du monstre
        /// </summary>
        /// <returns>Le niveau du monstre</returns>
        public int GetNiveau()
        {
            return this.nbrEtoiles;
        }

        /// <summary>
        /// Accesseur de l'attaque de base du monstre
        /// </summary>
        /// <returns>L'attaque de base du monstre</returns>
        public int GetAtk()
        {
            return this.atk;
        }

        /// <summary>
        /// Accesseur de la défense de base du monstre
        /// </summary>
        /// <returns>La défense de base du monstre</returns>
        public int GetDef()
        {
            return this.def;
        }

        /// <summary>
        /// Accesseur du/des sous-type(s)
        /// </summary>
        /// <returns>Le(s) sous-type(s)</returns>
        public string GetSousTypes()
        {
            return this.sousType;
        }
    }
}
