using Deviot.Common;
using System;
using Xunit;

namespace MAT.ControleEstoque.Business.ValueObjects.Product
{
    public class NameTest
    {
        private const string INVALID_LENGTH_MIN = "O nome do produto deve ter no mínimo 2 caracteres";
        private const string INVALID_LENGTH_MAX = "O nome do produto deve ter no máximo 50 caracteres";

        [Fact]//test

        public void ValidateTrue()
        {
            // Arrange

            var name = "Teclado Gamer ";

            // Act

            var result = new Name(name);

            // Assert

            Assert.True(result.Value == name);

        }

        [Fact] 

        public void ValidateLenghtMin()
        {
            var name = "M";

            var message = Assert.Throws<ArgumentException>(() => new Name(name)).Message;

            Assert.True(message == INVALID_LENGTH_MIN);
        }

        [Fact]
         public void ValidateLenghtMax()
        {
            var name = Utils.GenerateRandomString(51);

            var message = Assert.Throws<ArgumentException>(() => new Name(name)).Message;

            Assert.True(message == INVALID_LENGTH_MAX);
        }


    }

}
