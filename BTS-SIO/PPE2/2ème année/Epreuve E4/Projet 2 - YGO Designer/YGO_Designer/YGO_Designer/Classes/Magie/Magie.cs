using System;
using System.Collections.Generic;
using System.Text;


namespace YGO_Designer.Classes.Carte
{
    /// <summary>
    /// Classe fille héritée de la classe Carte représentant une carte particulière d'attribut magie
    /// </summary>
    public class Magie : Carte
    {
        private string nomTypeMa;

        /// <summary>
        /// Constructeur hérité de la classe Carte 
        /// </summary>
        /// <param name="eff">La liste des effets</param>
        /// <param name="no">Le numéro</param>
        /// <param name="attr">L'objet Attribut</param>
        /// <param name="nom">Le nom</param>
        /// <param name="description">La description</param>
        /// <param name="nomTypeMa">Le nom du type de magie</param>
        public Magie(List<Effet> eff, int no, Attribut attr, string nom, string description, string nomTypeMa)
            : base(eff, no, attr, nom, description)
        {
            this.nomTypeMa = nomTypeMa;
        }

        /// <summary>
        /// Surcharge du constructeur Magie hérité de la classe Carte
        /// </summary>
        /// <param name="eff">La liste des effets</param>
        /// <param name="no">Le numéro</param>
        /// <param name="attr">L'objet Attribut</param>
        /// <param name="nom">Le nom</param>
        /// <param name="description">La description</param>
        /// <param name="nomTypeMa">Le nom du type de magie</param>
        /// <param name="nbExemplaireDansDeck">Le nombre d'exemplaire d'une carte au sein d'un deck </param>
        public Magie(List<Effet> eff, int no, Attribut attr, string nom, string description, string nomTypeMa, int nbExemplaireDansDeck)
            : base(eff,no,attr,nom,description, nbExemplaireDansDeck)
        {
            this.nomTypeMa = nomTypeMa;
        }

        /// <summary>
        /// Accesseur du nom du type de magie
        /// </summary>
        /// <returns>Le nom du type de magie</returns>
        public string GetNomType()
        {
            return this.nomTypeMa;
        }
    }
}
