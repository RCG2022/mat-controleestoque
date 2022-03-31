using Deviot.Common;
using MAT.ControleEstoque.Business.ValueObjects.User;
using System;
using Xunit;

namespace MAT.ControleEstoque.Test.Business.ValueObjects.User
{
    public class PasswordTest
    {
        private const string INVALID_LENGTH_MIN = "O Password deve ter no mínimo 8 caracteres";
        private const string INVALID_LENGTH_MAX = "O Password deve ter no máximo 200 caracteres";
        private const string INVALID_PASSWORD = "O Password deve ter no mínimo 1 caracter especial," +
            " uma letra Maiúscula, uma letra minúscula e 1 número";

        [Fact]
        public void ValidateSuccess()
        {
            //Arrange
            var password = "Raf@123/";

            //Act

            var result = new Password(password);

            //Assert
            Assert.True(result.Value == password);
        }

        [Fact]
        public void ValidateLengthMin()
        {
            //Arrange

            var password = "Raf@12";

            //Act
            //Assert
            var message = Assert.Throws<ArgumentException>(() => new Password(password)).Message;

            Assert.True(message == INVALID_LENGTH_MIN);
        }

        [Fact]
        public void ValidateLengthMax()
        {
            //Arrange

            var password = Utils.GenerateRandomString(201);

            //Act
            //Assert
            var message = Assert.Throws<ArgumentException>(() => new Password(password)).Message;

            Assert.True(message == INVALID_LENGTH_MAX);
        }

        [Fact]
        public void ValidateRegex()
        {
            //Arrange

            var password = "Rafael123";

            //Act
            //Assert
            var message = Assert.Throws<ArgumentException>(() => new Password(password)).Message;

            Assert.True(message == INVALID_PASSWORD);
        }

    }
}
