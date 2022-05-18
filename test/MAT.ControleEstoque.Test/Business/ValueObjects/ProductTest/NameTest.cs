namespace MAT.ControleEstoque.Business.ValueObjects.Product
{
    internal class Name
    {
        private const string INVALID_LENGTH_MIN = "O nome do produto deve ter no mínimo 3 caracteres";
        private const string INVALID_LENGTH_MAX = "O nome do produto deve ter no máximo 50 caracteres";

        public string Value { get; private set; }

        public Name(string value)
        {
            if (value.Length < 3)
                throw new ArgumentException(INVALID_LENGTH_MIN);

            if (value.Length > 50)
                throw new ArgumentException(INVALID_LENGTH_MAX);

            Value = value;
        }
    }

}
