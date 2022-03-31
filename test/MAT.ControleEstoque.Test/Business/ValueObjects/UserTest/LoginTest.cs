using MAT.ControleEstoque.Business.ValueObjects.User;
using System;
using Xunit;

namespace MAT.ControleEstoque.Test.Business.ValueObjects.User
{
    public class LoginTest
    {
        private const string INVALID_LENGTH_MIN = "O login deve ter no minimo 3 caracter";
        private const string INVALID_LENGTH_MAX = "O login deve ter no máximo 20 caracter";
       

        [Fact]
        public void ValidateSuccess()
        {
            //Arrange

            var login = "RafaelDEV";

            //Act

            var result = new Login(login);

            //Assert

            Assert.True(result.Value == login);
        }

        [Fact]
        public void ValidateLengthMin()
        {
            //Arrange

            var login = "EU";

            //Act
            //Assert
            var message = Assert.Throws<ArgumentException>(() => new Login(login)).Message;

            Assert.True(message == INVALID_LENGTH_MIN);

        }

        [Fact]
        public void ValidateLengthMax()
        {
            //Arrange

            var login = "RAFAEL_VAI_SER_DEV_EM_NOME_DE_JESUS";

            //Act
            //Assert
            var message = Assert.Throws<ArgumentException>(() => new Login(login)).Message;

            Assert.True(message == INVALID_LENGTH_MAX);
        }


    }
}
        
