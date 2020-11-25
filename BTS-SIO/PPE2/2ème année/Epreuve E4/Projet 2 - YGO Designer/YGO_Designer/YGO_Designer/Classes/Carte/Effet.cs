namespace YGO_Designer.Classes.Carte
{
    public class Effet
    {
        private string cdEffet;
        private string nomEffet;

        public Effet(string cdEffet, string nomEffet)
        {
            this.cdEffet = cdEffet;
            this.nomEffet = nomEffet;
        }

        public override string ToString()
        {
            return nomEffet;
        }

        public string GetCodeEffet()
        {
            return this.cdEffet;
        }

        public string GetNomEffet()
        {
            return this.nomEffet;
        }
    }
}
