using MAT.ControleEstoque.Business.Entities;
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
            var idPerson = Guid.NewGuid();
            var login = "rauny";
            var password = "123@qwe";
            var enabled = true;

            // Act
            var person = new User(
                id,
                idPerson,
                login,
                password,
                enabled
                );

            // Assert
            Assert.True(person.Id == id);
            Assert.True(person.IdPerson == idPerson);
            Assert.True(person.Login == login);
            Assert.True(person.Password == password);
            Assert.True(person.Enabled == enabled);
        }
    }
}
