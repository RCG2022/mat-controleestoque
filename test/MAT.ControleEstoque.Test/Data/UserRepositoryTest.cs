using MAT.ControleEstoque.Business.Entities;
using MAT.ControleEstoque.Business.ValueObjects.User;
using MAT.ControleEstoque.Data.Builder;
using MAT.ControleEstoque.Data.Configurations;
using MAT.ControleEstoque.Data.Core;
using MAT.ControleEstoque.Data.Repositories;
using System;
using Xunit;

namespace MAT.ControleEstoque.Test.Data
{
    public class UserRepositoryTest
    {
        private readonly UserRepository _userRepository;

        public UserRepositoryTest()
        {
            var dbConfig = new DbConfig
            {
                ConnectionString = "Server=localhost;Database=Mat_ControleEstoque;User Id=sa;Password=paula@123",
                Schema = "dbo"
            };

            var dbService = new DbService(dbConfig);
            var userBuilder = new SystemUserBuilder(dbService);

            _userRepository = new UserRepository(dbService, userBuilder);
        }

        private User CreateUser()
        {
            return new User(
                new Guid("122f77e6-6549-417a-80a3-82c9056c34cc"),
                new Login("RAUNYSMZZ"),
                new Password("Paula@123"),
                true
                );
        }

        [Fact]
        public void FindById() 
        {
            // Arrange

            var user = CreateUser();

            // Act

            var result = _userRepository.FindById(user.Id);

            // Assert

            Assert.True(result.Id == user.Id);
            Assert.True(result.Login.Value == user.Login.Value);
            Assert.True(result.Enabled == user.Enabled);

        }

        [Fact]
        public void FindAll()
        {
            // Arrange

            // Act

            // Assert
        }

        [Fact]
        public void Login()
        {
            // Arrange

            // Act

            // Assert
        }

        [Fact]
        public void InsertSql()
        {
            // Arrange

            // Act

            // Assert
        }

        [Fact]
        public void Update() //Rauny
        {
            // Arrange

            var id = new Guid("a31c3728-b172-49c4-a971-4886fb3355cc");
            var user = new User(
                id,
                new Login("GUUU"),
                true 
                );

            // Act

            _userRepository.Update(user);

            var result = _userRepository.FindById(id);

            // Assert

            Assert.True(result.Id == user.Id);
            Assert.True(result.Login.Value == user.Login.Value);
            Assert.True(result.Enabled == user.Enabled);
        }

        [Fact]
        public void UpdatePasword()
        {
            // Arrange

            // Act

            // Assert
        }
    }
}
