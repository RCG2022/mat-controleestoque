using MAT.ControleEstoque.Business.Entities;
using MAT.ControleEstoque.Business.ValueObjects.Client;
using System;
using Xunit;

namespace MAT.ControleEstoque.Test.Business.Entities
{
    public class ClientTest
    {
        [Fact]
        public void ValidateEntity()
        {
            // Arrange
            var id = Guid.NewGuid();
            var fullName = "Rauny Stefano Marques";
            var email = "rauny@gmail.com";
            var phone = "(11)4488-5020";
            var address = "Rua Domingos de Braga, 200";

            // Act
            var client = new Client(
                id,
                fullName,
                email,
                phone,
                address
                );

            // Assert
            Assert.True(client.Id == id);
            Assert.True(client.FullName.Value == fullName);
            Assert.True(client.Email.Value == email);
            Assert.True(client.Phone.Value == phone);
            Assert.True(client.Address.Value == address);
        }
    }
}
