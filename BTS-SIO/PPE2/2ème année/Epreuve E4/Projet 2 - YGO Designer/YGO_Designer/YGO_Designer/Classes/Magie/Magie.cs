using System;
using System.Collections.Generic;
using System.Text;


namespace YGO_Designer.Classes.Carte
{
    public class Magie : Carte
    {
        private string nomTypeMa;

        public Magie(List<Effet> eff, int no, Attribut attr, string nom, string description, string nomTypeMa)
            : base(eff, no, attr, nom, description)
        {
            this.nomTypeMa = nomTypeMa;
        }

        public Magie(List<Effet> eff, int no, Attribut attr, string nom, string description, string nomTypeMa, int nbExemplaireDansDeck)
            : base(eff,no,attr,nom,description, nbExemplaireDansDeck)
        {
            this.nomTypeMa = nomTypeMa;
        }

        public string GetNomTypeMa()
        {
            return this.nomTypeMa;
        }
    }
}
