namespace YGO_Designer
{
    public class TypeMonstre
    {
        private string cdTypeMo;
        private string nomTypeMo;

        public TypeMonstre(string cdTypeMo, string nomTypeMo)
        {
            this.cdTypeMo = cdTypeMo;
            this.nomTypeMo = nomTypeMo;
        }

        public override string ToString()
        {
            return nomTypeMo;
        }
    }
}