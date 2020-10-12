using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace blind_test
{
    class Playlist
    {
        private Chanson chanson;
        private List<Chanson> playlist;

        /* Interface */

        //Constructeur
        public Playlist()
        {
            playlist = new List<Chanson>();
        }

        //Accesseurs
        public Chanson GetChanson()
        {
            return chanson;
        }

        //Mutateurs
        public void SetChanson(Chanson uneChanson)
        {
            chanson = uneChanson;
        }

        //Méthodes spécifiques de cette classe
        public void AjouterChanson(Chanson uneChanson)
        {
            playlist.Add(uneChanson);
        }

        public void NombreChansons(Label nbrChansons)
        {
            nbrChansons.Text = playlist.Count.ToString();
        }

        public void SupprimerChanson(int unNumChanson)
        {
            playlist.RemoveAt(unNumChanson - 1);
        }

        public Chanson ChansonAleatoire()
        {
            Random alea = new Random();
            int maChanson = alea.Next(playlist.Count());
            return playlist[maChanson];
        }
    }
}
