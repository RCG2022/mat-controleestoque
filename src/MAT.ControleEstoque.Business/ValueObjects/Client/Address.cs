using System.Text.RegularExpressions;

namespace MAT.ControleEstoque.Business.ValueObjects.Client
{
    public class Address
    {
        private const string INVALID_LENGTH_MAX = "O seu endereço completo deve ter no maximo 500 caracteres";
        private const string INVALID_LENGTH_MIN = "O seu endereço completo deve ter no minimo 5 caracteres";
        private const string INVALID_ADDRESS = "O seu endereço não está com o numero";

        public string Value { get; private set; }

        public Address(string value)
        {
            if (value.Length > 500)
                throw new ArgumentException(INVALID_LENGTH_MAX);
           
            if (value.Length < 5)
                throw new ArgumentException(INVALID_LENGTH_MIN);
            
            if (ValidateAddress(value) == false)     
                throw new ArgumentException(INVALID_ADDRESS); 

            Value = value;
        }

        private static bool ValidateAddress(string address)
        {
            if (string.IsNullOrEmpty(address))
                return false;

            return Regex.IsMatch(address, @"[0-9]");

        }


    }
}
