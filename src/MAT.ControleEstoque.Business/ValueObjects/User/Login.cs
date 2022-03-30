namespace MAT.ControleEstoque.Business.ValueObjects.User
{
    public class Login
    {

        private const string INVALID_LENGTH_MIN = "O login deve ter no minimo 3 caracter";
        private const string INVALID_LENGTH_MAX = "O login deve ter no máximo 20 caracter";

        public String Value { get; private set; }

        public Login(string value)
        {
            if(value.Length < 3 )
                throw new ArgumentException(INVALID_LENGTH_MIN);

            if(value.Length > 20)
                throw new ArgumentException(INVALID_LENGTH_MAX);

            Value = value;
        }
        
    }
}
