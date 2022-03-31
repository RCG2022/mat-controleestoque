using MAT.ControleEstoque.Business.Entities;
using MAT.ControleEstoque.Business.ValueObjects.Person;
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
            var phone = "(11)4488-5020";
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
            Assert.True(person.FullName.Value == fullName);
            Assert.True(person.Email.Value == email);
            Assert.True(person.Phone.Value == phone);
            Assert.True(person.Address.Value == address);
        }
    }
}
