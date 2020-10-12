using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.Serialization; //Serialisation
using System.Runtime.Serialization.Formatters.Binary; //Serialisation

namespace playlist
{
    [Serializable()]
    class Playlist : ISerializable
    {
        private Chanson chanson;
        private List<Chanson> playlist;

        /* Interface */

        // Récupérer objet serialisé
        public Playlist(SerializationInfo info, StreamingContext ctxt)
        {
            chanson = (Chanson)info.GetValue("Chanson", typeof(Chanson));
            playlist = (List<Chanson>)info.GetValue("Playlist", typeof(List<Chanson>));
        }

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

        public void VerifierPlaylist(ListBox listePlayliste)
        {
            listePlayliste.Items.Clear();
            string duree = "";
            int heure = 0;
            int minute = 0;
            int seconde = 0;
            foreach (Chanson c in playlist)
            {
                MesOutils.ConvertiSecondes(c.GetDuree(), out heure, out minute, out seconde);
                duree = heure.ToString() + "h" + minute.ToString() + "min" + seconde.ToString() + "sec";
                listePlayliste.Items.Add(c.GetTitre() + " - " + c.GetInterprete() + " - " + duree);
            }
        }

        public void NombreChansons(Label nbrChansons)
        {
            nbrChansons.Text = playlist.Count.ToString();
        }

        public void DureeTotalPlayListe(Label tmpTotal)
        {
            int total = 0;
            int heure = 0;
            int minute = 0;
            int seconde = 0;
            foreach (Chanson c in playlist)
                total += c.GetDuree();
            MesOutils.ConvertiSecondes(total, out heure, out minute, out seconde);
            string dureeTotale = heure.ToString() + "h" + minute.ToString() + "min" + seconde.ToString() + "sec";
            tmpTotal.Text = dureeTotale;
        }

        public void SupprimerChanson(int unNumChanson)
        {
            playlist.RemoveAt(unNumChanson - 1);
        }

        /*Fonction de sérialisation*/
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Chanson", chanson);
            info.AddValue("Playlist", playlist);
        }
    }
}
