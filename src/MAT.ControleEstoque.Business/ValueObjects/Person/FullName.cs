namespace MAT.ControleEstoque.Business.ValueObjects.Person
{
    public class FullName
    {
       
        
        private const string INVALID_LENGTH_MIN = "O nome completo deve ter no mínimo 5 caracteres";
        private const string INVALID_LENGTH_MAX = "O nome completo deve ter no máximo 50 caracteres";

        public string Value { get; private set; }

        public FullName(string value)
        {
            if (value.Length < 5)
                throw new ArgumentException(INVALID_LENGTH_MIN);

            if (value.Length > 50)
                throw new ArgumentException(INVALID_LENGTH_MAX);

            Value = value;
        }
    }
}
