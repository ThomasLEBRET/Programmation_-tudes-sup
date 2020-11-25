using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YGO_Designer.Classes.Deck
{
    public class Deck
    {
        private int numDeck;
        private string user;
        private string nom;
        private List<Carte.Carte> listCartes;
        private const int nbrCarteMinClassic = 40;
        private const int nbrCarteMaxClassic = 60;

        public Deck(int numDeck, string user, string nom)
        {
            this.numDeck = numDeck;
            this.user = user;
            this.nom = nom;
            this.listCartes = new List<Carte.Carte>();
        }

        public int GetNoDeck()
        {
            return this.numDeck;
        }

        public string GetUser()
        {
            return this.user;
        }

        public string GetNom()
        {
            return this.nom;
        }

        public List<Carte.Carte> GetCartes()
        {
            return this.listCartes;
        }

        public void SetCartes(List<Carte.Carte> listCartes)
        {
            this.listCartes = listCartes;
        }

        public bool EstDeckValide()
        {
            bool estValide = false;
            if (listCartes.Count >= nbrCarteMinClassic && listCartes.Count <= nbrCarteMaxClassic)
                estValide = true;
            return estValide;
        }

        public override string ToString()
        {
            return this.nom;
        }
    }
}
