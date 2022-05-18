namespace MAT.ControleEstoque.Business.ValueObjects.Product
{
    public class Indentifier
    {
        private const string INVALID_LENGTH_MAX = "O identificador do produto deve ter no máximo 300 caracteres";

        public string Value { get; set; }

        public Indentifier(string value)
        {
            if (value.Length > 300)
                throw new ArgumentException(INVALID_LENGTH_MAX);

            Value = value;
        }
    }

}
