using Deviot.Common;
using MAT.ControleEstoque.Business.ValueObjects.Client;
using System;
using Xunit;

namespace MAT.ControleEstoque.Test.Business.ValueObjects
{
    public class AddressTest
    {

        private const string INVALID_LENGTH_MAX = "O seu endereço completo deve ter no maximo 500 caracteres";
        private const string INVALID_LENGTH_MIN = "O seu endereço completo deve ter no minimo 5 caracteres";
        private const string INVALID_ADDRESS = "O seu endereço não está com o numero";



        [Fact] //test
        public void ValidateSucefull()
        {
            // Arrange
            
            var address = "Rua domingos de braga, 200";

            // Act
            
            var result = new Address(address);

            // Assert

            Assert.True(result.Value == address); 
        }

        [Fact]
        public void ValidateLenghtMin()
        {

            // Arrange

            var address = "ana";

            // Act

            // Assert

           var message = Assert.Throws<ArgumentException>(() => new Address(address)).Message;

           Assert.True(message == INVALID_LENGTH_MIN);
        }

        [Fact]
        public void ValidateLenghtMax()
        {

            // Arrange

            var address = Utils.GenerateRandomString(501);

            // Act

            // Assert

            var message = Assert.Throws<ArgumentException>(() => new Address(address)).Message;

            Assert.True(message == INVALID_LENGTH_MAX);

            
        }

        [Fact]
        public void ValidateRegex()
        {

            // Arrange

            var address = "Rua domingos de braga";

            // Act

            // Assert

            var message = Assert.Throws<ArgumentException>(() => new Address(address)).Message;

            Assert.True(message == INVALID_ADDRESS);


        }




    }
}
