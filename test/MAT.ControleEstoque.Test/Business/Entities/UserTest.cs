using Deviot.Common;
using MAT.ControleEstoque.Business.Entities;
using MAT.ControleEstoque.Business.ValueObjects.User;
using System;
using Xunit;

namespace MAT.ControleEstoque.Test.Business.Entities
{
    public class UserTest
    {
        [Fact]
        public void ValidateEntity()
        {
            // Arrange
            var id = Guid.NewGuid();
            var login = "rauny";
            var password = "Rafael@123";
            var enabled = true;

            // Act
            var client = new User(
                id,
                new Login(login),
                new Password(password),
                enabled
                );

            // Assert
            Assert.True(client.Id == id);
            Assert.True(client.Login.Value == login);
            Assert.True(client.Password.Value == Utils.Encript(password));
            Assert.True(client.Enabled == enabled);
        }
    }
}
