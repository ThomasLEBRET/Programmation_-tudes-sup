using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SacADos
{
    class Armoire
    {
        private List<Article> listeArticles;

        public Armoire()
        {
            listeArticles = new List<Article>();
        }

        public List<Article> GetListeArticles()
        {
            return this.listeArticles;
        }

        public void SetListeArticles(List<Article> listeArticles)
        {
            this.listeArticles = listeArticles;
        }

        public void AjouterArticle(Article a)
        {
            listeArticles.Add(a);
        }

        public void SupprimerArticle(Article a)
        {
            listeArticles.Remove(a);
        }

        public void ModifierArticle(int ind, Article a)
        {
            listeArticles[ind] = a;
            a.SetUtiliteSurPoids((float)Math.Round((double)a.GetUtilite() / a.GetPoids(), 5));
        }
    }
}
