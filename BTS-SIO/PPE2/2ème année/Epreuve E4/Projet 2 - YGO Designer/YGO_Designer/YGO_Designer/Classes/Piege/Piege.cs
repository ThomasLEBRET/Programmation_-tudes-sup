using System;
using System.Collections.Generic;
using System.Text;


namespace YGO_Designer.Classes.Carte
{
    /// <summary>
    /// Classe fille hérité de la classe Carte représentant une carte piège
    /// </summary>
    public class Piege : Carte
    {
        private string nomTypePi;

        /// <summary>
        /// Constructeur par défaut de la classe hérité du constructeur par défaut de la classe Carte
        /// </summary>
        /// <param name="eff">L'effet</param>
        /// <param name="no">Le numéro</param>
        /// <param name="attr">L'attribut</param>
        /// <param name="nom">Le nom</param>
        /// <param name="description">La description</param>
        /// <param name="nomTypePi">Le nom du type de la carte</param>
        public Piege(List<Effet> eff, int no, Attribut attr, string nom, string description, string nomTypePi)
            : base(eff, no, attr, nom, description)
        {
            this.nomTypePi = nomTypePi;
        }

        /// <summary>
        /// Surcharge du constructeur par défaut prenant en compte le nombre d'exemplaire de la carte dans un deck
        /// </summary>
        /// <param name="eff">L'effet</param>
        /// <param name="no">Le numéro</param>
        /// <param name="attr">L'attribut</param>
        /// <param name="nom">Le nom</param>
        /// <param name="description">La description</param>
        /// /// <param name="nomTypePi">Le nom du type de la carte</param>
        /// <param name="nbExemplaireDansDeck">Le nombre d'exemplaire de la carte au seind d'un deck</param>
        public Piege(List<Effet> eff, int no, Attribut attr, string nom, string description, string nomTypePi, int nbExemplaireDansDeck)
            : base(eff, no, attr, nom, description, nbExemplaireDansDeck)
        {
            this.nomTypePi = nomTypePi;
        }

        /// <summary>
        /// Accesseur du nom du type de la carte
        /// </summary>
        /// <returns></returns>
        public string GetNomTypePi()
        {
            return this.nomTypePi;
        }
    }
}
