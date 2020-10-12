using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SacADos
{
    class SacADos
    {
        private List<Article> articlesEmportes;
        private int poidsMax;
        private int poidsActuel;

        public SacADos(int poidsMax)
        {
            this.poidsMax = poidsMax;
            this.poidsActuel = 0;
            articlesEmportes = new List<Article>();
        }

        public int GetPoidsMax()
        {
            return this.poidsMax;
        }

        public int GetPoidsActuel()
        {
            return this.poidsActuel;
        }

        public List<Article> GetArticlesEmportes()
        {
            return this.articlesEmportes;
        }

        public void SetPoidsMax(int poidsMax)
        {
            this.poidsMax = poidsMax;
        }

        public void SetPoidsActuel(int poidsActuel)
        {
            this.poidsActuel = poidsActuel;
        }

        public void SetArticlesEmportes(List<Article> articlesEmportes)
        {
            this.articlesEmportes = articlesEmportes;
        }

        public void AjouterArticle(Article a)
        {
            articlesEmportes.Add(a);
        }

        public void SupprimerArticle(Article a)
        {
            articlesEmportes.Remove(a);
        }
    }
}
