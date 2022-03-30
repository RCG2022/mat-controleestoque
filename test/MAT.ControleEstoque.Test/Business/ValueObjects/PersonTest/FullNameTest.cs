using Deviot.Common;
using MAT.ControleEstoque.Business.ValueObjects.Person;
using System;
using Xunit;

namespace MAT.ControleEstoque.Test.Business.ValueObjects
{
    public class FullNameTest
    {

        private const string INVALID_LENGTH_MIN = "O nome completo deve ter no mínimo 5 caracteres";
        private const string INVALID_LENGTH_MAX = "O nome completo deve ter no máximo 50 caracteres";



        [Fact] //test
        public void ValidateTrue()
        {
            // Arrange
            
            var fullname = "Rafael";

            // Act
            
            var result = new FullName(fullname);

            // Assert

            Assert.True(result.Value == fullname); 
        }

        [Fact]
        public void ValidateLenghtMin()
        {

            // Arrange

            var fullname = "ana";

            // Act

            // Assert

           var message = Assert.Throws<ArgumentException>(() => new FullName(fullname)).Message;

           Assert.True(message == INVALID_LENGTH_MIN);
        }

        [Fact]
        public void ValidateLenghtMax()
        {

            // Arrange

            var fullname = Utils.GenerateRandomString(51);

            // Act

            // Assert

            var message = Assert.Throws<ArgumentException>(() => new FullName(fullname)).Message;

            Assert.True(message == INVALID_LENGTH_MAX);

            
        }



        
    }
}
