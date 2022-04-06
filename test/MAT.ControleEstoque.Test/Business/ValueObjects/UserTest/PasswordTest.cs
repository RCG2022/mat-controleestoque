using Deviot.Common;
using MAT.ControleEstoque.Business.ValueObjects.User;
using System;
using Xunit;

namespace MAT.ControleEstoque.Test.Business.ValueObjects.User
{
    public class PasswordTest
    {
        private const string INVALID_LENGTH_MIN = "A senha deve ter no mínimo 6 caracteres";
        private const string INVALID_LENGTH_MAX = "A senha deve ter no máximo 20 caracteres";
        private const string MUST_CONTAIN_ONE_LOWERCASE_LETTER = "A senha deve conter ao menos uma letra minúscula";
        private const string MUST_CONTAIN_ONE_UPPERCASE_LETTER = "A senha deve conter ao menos uma letra maiúscula";
        private const string MUST_CONTAIN_ONE_SPECIAL_CHARACTERS = "A senha deve conter ao menos um caractere especial";
        private const string INVALID_CHARACTERS = "A senha deve conter somente letras, números e os caracteres $*&@#";

        [Fact]
        public void ValidateSuccess()
        {
            //Arrange
            var password = "Rafael@123";

            //Act

            var result = new Password(password);

            //Assert
            Assert.True(result.Value == Utils.Encript(password));
        }

        [Fact]
        public void ValidateLengthMin()
        {
            //Arrange

            var password = "Ra@12";

            //Act
            //Assert
            var message = Assert.Throws<ArgumentException>(() => new Password(password)).Message;

            Assert.True(message == INVALID_LENGTH_MIN);
        }

        [Fact]
        public void ValidateLengthMax()
        {
            //Arrange

            var password = Utils.GenerateRandomString(21);

            //Act
            //Assert
            var message = Assert.Throws<ArgumentException>(() => new Password(password)).Message;

            Assert.True(message == INVALID_LENGTH_MAX);
        }

        [Fact]
        public void ValidateRegex1()
        {
            //Arrange

            var password = "RAFAEL123";

            //Act
            //Assert
            var message = Assert.Throws<ArgumentException>(() => new Password(password)).Message;

            Assert.True(message == MUST_CONTAIN_ONE_LOWERCASE_LETTER);
        }

        [Fact]
        public void ValidateRegex2()
        {
            //Arrange

            var password = "rafael123";

            //Act
            //Assert
            var message = Assert.Throws<ArgumentException>(() => new Password(password)).Message;

            Assert.True(message == MUST_CONTAIN_ONE_UPPERCASE_LETTER);
        }

        [Fact]
        public void ValidateRegex3()
        {
            //Arrange

            var password = "Rafael123";

            //Act
            //Assert
            var message = Assert.Throws<ArgumentException>(() => new Password(password)).Message;

            Assert.True(message == MUST_CONTAIN_ONE_SPECIAL_CHARACTERS);
        }

        [Fact]
        public void ValidateRegex4()
        {
            //Arrange

            var password = "Rafael@ l123";

            //Act
            //Assert
            var message = Assert.Throws<ArgumentException>(() => new Password(password)).Message;

            Assert.True(message == INVALID_CHARACTERS);
        }

    }
}
