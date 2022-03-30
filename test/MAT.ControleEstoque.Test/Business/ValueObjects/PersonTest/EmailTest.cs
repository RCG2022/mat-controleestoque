using Deviot.Common;
using MAT.ControleEstoque.Business.ValueObjects.Person;
using System;
using Xunit;

namespace MAT.ControleEstoque.Test.Business.ValueObjects
{
    public class EmailTest
    {

        private const string INVALID_LENGTH_MIN = "O e-mail deve ter no mínimo 7 caracteres";
        private const string INVALID_LENGTH_MAX = "O e-mail completo deve ter no maximo 50 caracteres";
        private const string INVALID_EMAIL = "O e-mail é invalido";



        [Fact] //test
        public void ValidateTrue()
        {
            // Arrange

            var email = "Rauny.stefano2211@gmail.com";

            // Act

            var result = new Email(email);

            // Assert

            Assert.True(result.Value == email);
        }

        [Fact]
        public void ValidateLenghtMin()
        {

            // Arrange

            var email = "ana";

            // Act

            // Assert

            var message = Assert.Throws<ArgumentException>(() => new Email(email)).Message;

            Assert.True(message == INVALID_LENGTH_MIN);
        }

        [Fact]
        public void ValidateLenghtMax()
        {

            // Arrange

            var email = Utils.GenerateRandomString(51);

            // Act

            // Assert

            var message = Assert.Throws<ArgumentException>(() => new Email(email)).Message;

            Assert.True(message == INVALID_LENGTH_MAX);


        }

        [Fact]
        public void ValidateRegex()
        {

            // Arrange

            var email = "Rauny.stefanogmail.com";

            // Act

            // Assert

            var message = Assert.Throws<ArgumentException>(() => new Email(email)).Message;

            Assert.True(message == INVALID_EMAIL);

        }
    }
}
