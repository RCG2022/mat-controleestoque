using System.Text.RegularExpressions;

namespace MAT.ControleEstoque.Business.ValueObjects.Person
{

    public class Phone
    {
        private const string INVALID_LENGTH_MIN = "O telefone deve ter no mínimo 11 caracteres";
        private const string INVALID_LENGTH_MAX = "O telefone deve ter no maxímo 20 caracteres";
        private const string INVALID_PHONE = "O telefone é invalido";

        public string Value { get; private set; }

        public Phone(string value)
        {
            if(value.Length < 11)
                throw new ArgumentException(INVALID_LENGTH_MIN);
            
            if(value.Length > 20)
                throw new ArgumentException(INVALID_LENGTH_MAX);

            if(ValidatePhone(value) == false)
                throw new ArgumentException(INVALID_PHONE);

            Value = value;
        }

        private static bool ValidatePhone(string phone)
        {
            if (string.IsNullOrEmpty(phone))
                return false;

            return Regex.IsMatch(phone, @"^\s*[(](\d{2}|\d{0})[)][-. ]?(\d{5}|\d{4})[-. ]?(\d{4})[-. ]?\s*$");
        }
    }
}
