using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.Serialization; //Sérialisation
using System.Runtime.Serialization.Formatters.Binary; //Sérialisation

namespace playlist
{
    [Serializable()]
    class Chanson : ISerializable
    {
        private string titre;
        private string interprete;
        private int duree;

        /* Interface */

        //Constructeurs
        public Chanson()
        {

        }

        public Chanson(string unTitre, string unInterprète, int uneDuree)
        {
            titre = unTitre;
            interprete = unInterprète;
            duree = uneDuree;
        }

        //Accesseurs
        public string GetTitre()
        {
            return titre;
        }

        public string GetInterprete()
        {
            return interprete;
        }

        public int GetDuree()
        {
            return duree;
        }

        //Mutateurs
        public void SetTitre(string unTitre)
        {
            titre = unTitre;
        }

        public void SetInterprete(string unInterprete)
        {
            interprete = unInterprete;
        }

        public void SetDuree(int uneDuree)
        {
            duree = uneDuree;
        }

        /*Fonction de sérialisation*/
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Titre", titre);
            info.AddValue("Interprète", interprete);
            info.AddValue("Durée", duree);
        }

        // Récupérer objet serialisé
        public Chanson(SerializationInfo info, StreamingContext ctxt)
        {
            titre = (string)info.GetValue("Titre", typeof(string));
            interprete = (string)info.GetValue("Interprète", typeof(string));
            duree = (int)info.GetValue("Durée", typeof(int));
        }
    }
}
