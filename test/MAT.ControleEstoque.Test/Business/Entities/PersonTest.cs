using MAT.ControleEstoque.Business.Entities;
using System;
using Xunit;

namespace MAT.ControleEstoque.Test.Business.Entities
{
    public class PersonTest
    {
        [Fact]
        public void ValidateEntity()
        {
            // Arrange
            var id = Guid.NewGuid();
            var fullName = "Rauny Stefano Marques";
            var email = "rauny@gmail.com";
            var phone = "11 95600 5006";
            var address = "Rua Domingos de Braga, 200";

            // Act
            var person = new Person(
                id,
                fullName,
                email,
                phone,
                address
                );

            // Assert
            Assert.True(person.Id == id);
            Assert.True(person.FullName == fullName);
            Assert.True(person.Email == email);
            Assert.True(person.Phone == phone);
            Assert.True(person.Address == address);
        }
    }
}
