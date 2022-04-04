﻿using Deviot.Common;
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
            var password = "Rafael@123";
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
            Assert.True(person.Login.Value == login);
            Assert.True(person.Password.Value == Utils.Encript(password));
            Assert.True(person.Enabled == enabled);
        }
    }
}
