namespace YGO_Designer.Classes.Carte
{
    public class Attribut
    {
        private string cdAttrCarte;
        private string nomAttrCarte;

        public Attribut(string cdAttrCarte, string nomAttrCarte)
        {
            this.cdAttrCarte = cdAttrCarte;
            this.nomAttrCarte = nomAttrCarte;
        }

        public override string ToString()
        {
            return this.nomAttrCarte;
        }

        public string GetCdAttrCarte()
        {
            return this.cdAttrCarte;
        }

        public string GetNomAttrCarte()
        {
            return this.nomAttrCarte;
        }
    }
}