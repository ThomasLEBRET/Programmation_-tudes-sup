using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace testTri
{
    class Enfant : IComparable
    {
        private string pseudo;
        private string motDePasse;
        private int score;

        public Enfant()
        {
        }

        public Enfant(string unPseudo, string unMotDePasse, int unScore)
        {
            pseudo = unPseudo;
            motDePasse = unMotDePasse;
            score = unScore;
        }

        public string GetPseudo()
        {
            return pseudo;
        }

        public string GetMotDePasse()
        {
            return motDePasse;
        }

        public int GetScore()
        {
            return score;
        }

        public void SetPseudo(string unPseudo)
        {
            pseudo = unPseudo;
        }

        public void SetMotDePasse(string unMotDePasse)
        {
            motDePasse = unMotDePasse;
        }

        public void SetScore(int unScore)
        {
            score = unScore;
        }

        public int CompareTo(object obj)
        {
            Enfant e = (Enfant)obj;
            int resComp = score.CompareTo(e.score);
            return resComp;
        }
    }
}
