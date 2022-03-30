using System.Text.RegularExpressions;

namespace MAT.ControleEstoque.Business.ValueObjects.User
{
    public class Password
    {
        private const string INVALID_LENGTH_MIN = "O Password deve ter no mínimo 8 caracteres";
        private const string INVALID_LENGTH_MAX = "O Password deve ter no máximo 200 caracteres";
        private const string INVALID_PASSWORD = "O Password deve ter no mínimo 1 caracter especial," +
            " uma letra Maiúscula, uma letra minúscula e 1 número";
        

        public string Value { get; private set; }

        public Password(string valeu) {

            if (valeu.Length < 8)
                throw new ArgumentException(INVALID_LENGTH_MIN);

            if (valeu.Length > 200)
                throw new ArgumentException(INVALID_LENGTH_MAX);

            if (ValidatePassword(valeu) == false)
                throw new ArgumentException(INVALID_PASSWORD);
            
            Value = valeu;

        }

        private static bool ValidatePassword(string password)
        {
            if (string.IsNullOrEmpty(password))
                return false;

            return Regex.IsMatch(password, @"^(?=.*[!@#$%¨&*()_+])(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[a-zA-Z]).{8,}$");
        }

    }
}
