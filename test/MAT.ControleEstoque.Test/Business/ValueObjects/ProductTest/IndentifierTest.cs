using Deviot.Common;
using System;
using Xunit;

namespace MAT.ControleEstoque.Business.ValueObjects.Product
{
    public class IndentifierTest
    {
        private const string INVALID_LENGTH_MAX = "O identificador do produto deve ter no máximo 300 caracteres";

       
        [Fact]
        public void ValidateTrue()
        {
            // Arrange

            var indentifier = "445575";

            // Act

            var result = new Indentifier(indentifier);

            // Assert

            Assert.True(result.Value == indentifier);

        }

        [Fact]

        public void ValidateLenghtMax()
        {
            var indentifier = Utils.GenerateRandomString(301);

            var message = Assert.Throws<ArgumentException>(() => new Indentifier(indentifier)).Message;

            Assert.True(message == INVALID_LENGTH_MAX);
        }
    }
}
