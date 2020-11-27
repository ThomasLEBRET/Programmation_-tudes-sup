using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YGO_Designer.Classes.Deck
{
    /// <summary>
    /// Classe représentant une liste de cartes appartenant à un joueur appelé Deck 
    /// </summary>
    public class Deck
    {
        private int numDeck;
        private string user;
        private string nom;
        private List<Carte.Carte> listCartes;

        //Les constantes servent à déterminer le nombre minimum de carte et le nombre maximum de carte que peut comporter un Deck
        private const int nbrCarteMinClassic = 40;
        private const int nbrCarteMaxClassic = 60;

        /// <summary>
        /// Constructeur par défaut 
        /// </summary>
        /// <param name="numDeck">Le numéro du deck</param>
        /// <param name="user">Le nom d'utilisateur du joueur</param>
        /// <param name="nom">Le nom du deck</param>
        public Deck(int numDeck, string user, string nom)
        {
            this.numDeck = numDeck;
            this.user = user;
            this.nom = nom;
            this.listCartes = new List<Carte.Carte>();
        }

        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
                return false;
            else
            {
                Deck d = (Deck)obj;
                return numDeck == d.numDeck;
            }
        }

        public override int GetHashCode()
        {
            return this.numDeck;
        }

        /// <summary>
        /// Accesseur du numéro du deck
        /// </summary>
        /// <returns>Le numéro du deck</returns>
        public int GetNo()
        {
            return this.numDeck;
        }

        /// <summary>
        /// Accesseur du joueur
        /// </summary>
        /// <returns>Le username du joueur</returns>
        public string GetUsername()
        {
            return this.user;
        }

        /// <summary>
        /// Accesseur du nom du deck
        /// </summary>
        /// <returns>Le nom du deck</returns>
        public string GetNom()
        {
            return this.nom;
        }

        /// <summary>
        /// Accesseur de la liste de cartes du deck
        /// </summary>
        /// <returns>Une liste typée Carte associée au deck</returns>
        public List<Carte.Carte> GetCartes()
        {
            return this.listCartes;
        }

        /// <summary>
        /// Mutateur de la liste de cartes du deck
        /// </summary>
        /// <param name="listCartes">Une nouvelle liste typée Carte</param>
        public void SetCartes(List<Carte.Carte> listCartes)
        {
            this.listCartes = listCartes;
        }

        /// <summary>
        /// Vérifie si le nombre de cartes d'un deck est compris entre les 2 constantes de la classe
        /// </summary>
        /// <returns>Un booléen : true si le deck est valide, false sinon</returns>
        public bool IsDeckValid()
        {
            bool estValide = false;
            if (listCartes.Count >= nbrCarteMinClassic && listCartes.Count <= nbrCarteMaxClassic)
                estValide = true;
            return estValide;
        }

        /// <summary>
        /// Méthode privée calculant le nombre de cartes d'un deck
        /// </summary>
        /// <returns>Le nombre total de cartes associées à leur nomre d'exemplaire</returns>
        private int NbCartesFromDeck()
        {
            int nbExemplaireTotal = 0;
            foreach (Carte.Carte c in listCartes)
                nbExemplaireTotal += c.GetNbExemplaireFromDeck();
            return nbExemplaireTotal;
        }

        /// <summary>
        /// Redéfinition de la méthode ToStrign
        /// </summary>
        /// <returns>Le nom et le nombre de cartes du deck</returns>
        public override string ToString()
        {
            return this.nom + " " + NbCartesFromDeck() + " cartes";
        }
    }
}
