namespace YGO_Designer
{
    /// <summary>
    /// Classe objet précisant de quel attribut est l'objet Carte
    /// </summary>
    public class Attribut
    {
        private string cdAttrCarte;
        private string nomAttrCarte;
        /// <summary>
        /// Surcharge du constructeur de la classe Attribut affectant aux attributs privés de l'objet les paramètres du constructeur 
        /// </summary>
        /// <param name="cdAttrCarte">Code d'attribut de la carte</param>
        /// <param name="nomAttrCarte">Nom d'attribut de la carte</param>
        public Attribut(string cdAttrCarte, string nomAttrCarte)
        {
            this.cdAttrCarte = cdAttrCarte;
            this.nomAttrCarte = nomAttrCarte;
        }
        /// <summary>
        /// Constructeur de la classe Attribut initialisant les paramètres par défaut 
        /// </summary>
        public Attribut()
        {
            this.cdAttrCarte = "";
            this.nomAttrCarte = "";
        }
        /// <summary>
        /// Redéfinition de la méthode ToString 
        /// </summary>
        /// <returns>Le nom de l'attribut de la carte</returns>
        public override string ToString()
        {
            return this.nomAttrCarte;
        }
        /// <summary>
        /// Accesseur du code d'attribut
        /// </summary>
        /// <returns>Un code d'attribut de type string</returns>
        public string GetCdAttrCarte()
        {
            return this.cdAttrCarte;
        }
        /// <summary>
        /// Accesseur du nom de attribut 
        /// </summary>
        /// <returns>Un nom d'attribut de type string</returns>
        public string GetNomAttrCarte()
        {
            return this.nomAttrCarte;
        }
    }
}