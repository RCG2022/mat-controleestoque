using Deviot.Common;
using MAT.ControleEstoque.Business.Entities;
using MAT.ControleEstoque.Data.Builder;
using MAT.ControleEstoque.Data.Configurations;
using MAT.ControleEstoque.Data.Core;
using MAT.ControleEstoque.Data.Repositories;
using System;
using System.Linq;
using Xunit;

namespace MAT.ControleEstoque.Test.Data
{
    public class ClientRepositoryTest
    {
        private readonly ClientRepository _clientRepository;

        public ClientRepositoryTest()
        {
            var dbConfig = new DbConfig
            {
                ConnectionString = "Server=localhost;Database=Mat_ControleEstoque;User Id=sa;Password=paula@123",
                Schema = "dbo"
            };

            var dbService = new DbService(dbConfig);
            var clientBuilder = new ClientBuilder(dbService);

            _clientRepository = new ClientRepository(dbService, clientBuilder);
        }

        private Client CreateClient()
        {
            var id = new Guid("0a24e0b6-f5cc-4902-9820-50af6871f225");
            return new Client(
                id,
                "Rauny Stefano Marques",
                "rauny.stefano2211@gmail.com",
                "(11)4488-5020",
                "Rua Domingos de Braga, 200"
                );
        }

        [Fact]
        public void FindById()
        {
            // Arrange
            var client = CreateClient();

            // Act
            var result = _clientRepository.FindById(client.Id);

            // Assert
            Assert.True(result.Id == client.Id);
            Assert.True(result.FullName.Value == client.FullName.Value);
            Assert.True(result.Email.Value == client.Email.Value);
            Assert.True(result.Phone.Value == client.Phone.Value);
            Assert.True(result.Address.Value == client.Address.Value);
        }

        [Fact]
        public void Update()
        {
            // Arrange

            var id = new Guid("6982f837-2147-4a46-83d4-7b9bd2daae1c");
            var client = new Client(
                id,
                "Julia Miranda Candido",
                "juliacandidomiranda11@gmail.com",
                "(11)97777-7777",
                "Rua Imperatriz Leopoldina 1013"
                );

            // Act

            _clientRepository.Update(client);

            var result = _clientRepository.FindById(id);

            // Assert
            Assert.True(result.Id == client.Id);
            Assert.True(result.FullName.Value == client.FullName.Value);
            Assert.True(result.Email.Value == client.Email.Value);
            Assert.True(result.Phone.Value == client.Phone.Value);
            Assert.True(result.Address.Value == client.Address.Value);
        }

        [Fact]
        public void FindAll()
        {
            // Arrange
            var client = CreateClient();

            // Act
            var result = _clientRepository.FindAll("rauny");

            // Assert
            Assert.True(result.Any());
            Assert.True(result[0].Id == client.Id);
            Assert.True(result[0].FullName.Value == client.FullName.Value);
            Assert.True(result[0].Email.Value == client.Email.Value);
            Assert.True(result[0].Phone.Value == client.Phone.Value);
            Assert.True(result[0].Address.Value == client.Address.Value);
        }

        [Fact]
        public void InsertSql()
        {
            // Arrange
            var id = Guid.NewGuid();
            var name = Utils.GenerateRandomString(10);
            var client = new Client(
                id,
                name,
                $"{name}@gmail.com",
                "(11)4488-5020",
                "Rua Domingos de Braga, 200"
                );

            // Act
            _clientRepository.Insert(client);
            var result = _clientRepository.FindById(id);

            // Assert
            Assert.True(result.Id == client.Id);
            Assert.True(result.FullName.Value == client.FullName.Value);
            Assert.True(result.Email.Value == client.Email.Value);
            Assert.True(result.Phone.Value == client.Phone.Value);
            Assert.True(result.Address.Value == client.Address.Value);
        }
    }
}
