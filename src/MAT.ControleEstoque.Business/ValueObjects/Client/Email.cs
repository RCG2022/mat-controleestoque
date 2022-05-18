using System.Text.RegularExpressions;

namespace MAT.ControleEstoque.Business.ValueObjects.Client
{
    public class Email
    {
        private const string INVALID_LENGTH_MAX = "O e-mail completo deve ter no maximo 50 caracteres";
        private const string INVALID_EMAIL      = "O e-mail é invalido";

        public string Value { get; private set; }

        public Email (string value)
        {
       
            if (value.Length > 50)
                throw new ArgumentException(INVALID_LENGTH_MAX);

            if (ValidateEmailRauny(value) == false) 
            {
                throw new ArgumentException(INVALID_EMAIL);
            }

            Value = value.ToLower();
            
        }

        private static bool ValidateEmailRauny(string email)
        {
            if (string.IsNullOrEmpty(email))
                return false;

            return Regex.IsMatch(email, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");  
        }
    }
}
