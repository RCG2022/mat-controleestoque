using Deviot.Common;
using System.Text.RegularExpressions;

namespace MAT.ControleEstoque.Business.ValueObjects.User
{
    public class Password
    {
        public String Value { get; private set; }

        private const string INVALID_LENGTH_MIN = "A senha deve ter no mínimo 6 caracteres";
        private const string INVALID_LENGTH_MAX = "A senha deve ter no máximo 20 caracteres";
        private const string MUST_CONTAIN_ONE_LOWERCASE_LETTER = "A senha deve conter ao menos uma letra minúscula";
        private const string MUST_CONTAIN_ONE_UPPERCASE_LETTER = "A senha deve conter ao menos uma letra maiúscula";
        private const string MUST_CONTAIN_ONE_SPECIAL_CHARACTERS = "A senha deve conter ao menos um caractere especial";
        private const string INVALID_CHARACTERS = "A senha deve conter somente letras, números e os caracteres $*&@#";

        public Password(string value)
        {
            if (value.Length < 6)
                throw new ArgumentException(INVALID_LENGTH_MIN);

            if (value.Length > 20)
                throw new ArgumentException(INVALID_LENGTH_MAX);

            if (!validateLowercase(value))
                throw new ArgumentException(MUST_CONTAIN_ONE_LOWERCASE_LETTER);

            if (!validateUppercase(value))
                throw new ArgumentException(MUST_CONTAIN_ONE_UPPERCASE_LETTER);

            if (!validateSpecialCharacters(value))
                throw new ArgumentException(MUST_CONTAIN_ONE_SPECIAL_CHARACTERS);

            if (!validateCharacters(value))
                throw new ArgumentException(INVALID_CHARACTERS);

            Value = Utils.Encript(value);
        }

        private static bool validateLowercase(string value)
        {
            return value.Length > Regex.Replace(value, "[a-z]", string.Empty).Length;
        }

        private static bool validateUppercase(string value)
        {
            return value.Length > Regex.Replace(value, "[A-Z]", string.Empty).Length;
        }

        private static bool validateSpecialCharacters(string value)
        {
            return value.Length > Regex.Replace(value, "[$*&@#]", string.Empty).Length;
        }

        private static bool validateCharacters(string value)
        {
            return Regex.IsMatch(value, @"^[a-zA-Z0-9$*&@#]*$");
        }
    }
}