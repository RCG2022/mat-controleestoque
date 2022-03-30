using MAT.ControleEstoque.Business.ValueObjects.Person;
using System;
using Xunit;

namespace MAT.ControleEstoque.Test.Business.ValueObjects
{
    public class PhoneTest
    {

        private const string INVALID_LENGTH_MIN = "O telefone deve ter no mínimo 11 caracteres";
        private const string INVALID_LENGTH_MAX = "O telefone deve ter no maxímo 20 caracteres";
        private const string INVALID_PHONE = "O telefone é invalido";

        [Fact]

        public void ValidateSuccess()
        {
            // Arrange

            var phone = "(11)4488-5020";

            // Act

            var result = new Phone(phone);

            // Assert

            Assert.True(result.Value == phone);
        }

        [Fact]
        public void ValidateLengthMin()
        {
            // Arrange

            var phone = "4488-5020";

            // Act

            // Assert

            var message = Assert.Throws<ArgumentException>(() => new Phone(phone)).Message;

            Assert.True(message == INVALID_LENGTH_MIN);
        }

        [Fact]
        public void ValidateLengthMax()
        {
            // Arrange

            var phone = "123456789101112131415161718192021";

            // Act

            // Assert

            var message = Assert.Throws<ArgumentException>(() => new Phone(phone)).Message;

            Assert.True(message == INVALID_LENGTH_MAX);

         }

        [Fact]
        public void ValidatePhone()
        {
            // Arrange

            var phone = "11 4488-5020";

            // Act

            // Assert

            var message = Assert.Throws<ArgumentException>(() => new Phone(phone)).Message;

            Assert.True(message == INVALID_PHONE);

        }
    }
}
