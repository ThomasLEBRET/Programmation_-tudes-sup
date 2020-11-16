using System;
using System.Collections.Generic;
using System.Text;


namespace YGO_Designer.Classes.Carte
{
    public class Piege : Carte
    {
        private string nomTypePi;

        public Piege(List<Effet> eff, int no, Attribut attr, string nom, string description, string nomTypePi)
            : base(eff, no, attr, nom, description)
        {
            this.nomTypePi = nomTypePi;
        }

        public string GetNomTypePi()
        {
            return this.nomTypePi;
        }
    }
}
