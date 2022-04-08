using MAT.ControleEstoque.Data.Builder;
using MAT.ControleEstoque.Data.Configurations;
using MAT.ControleEstoque.Data.Core;
using MAT.ControleEstoque.Data.Repositories;
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

        [Fact]
        public void FindById()
        {
            // Arrange

            // Act

            // Assert
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
        public void Update()
        {
            // Arrange

            // Act

            // Assert
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
