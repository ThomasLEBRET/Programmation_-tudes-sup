using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Media;

namespace blind_test
{
    class Chanson
    {
        private string titre;
        private string interprete;
        private int duree;
        private SoundPlayer musique = new SoundPlayer();
        /* Interface */

        //Constructeurs
        public Chanson()
        {

        }

        public Chanson(string unTitre, string unInterprète, int uneDuree, string location)
        {
            titre = unTitre;
            interprete = unInterprète;
            duree = uneDuree;
            musique.SoundLocation = location;
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

        public SoundPlayer GetMusique()
        {
            return musique;
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

        public void JouerChanson()
        {
            musique.Play();
        }
    }
}
