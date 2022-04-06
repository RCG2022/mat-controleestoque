using MAT.ControleEstoque.Business.Entities;
using MAT.ControleEstoque.Data.Builder;
using MAT.ControleEstoque.Data.Configurations;
using MAT.ControleEstoque.Data.Core;
using MAT.ControleEstoque.Data.Repositories;
using System;
using System.Threading.Tasks;
using Xunit;

namespace MAT.ControleEstoque.Test.Data
{
    public class PersonRepositoryTest
    {
        private readonly PersonRepository _personRepository;

        public PersonRepositoryTest()
        {
            var dbConfig = new DbConfig
            {
                ConnectionString = "Server=localhost;Database=Mat_ControleEstoque;User Id=sa;Password=paula@123",
                Schema = "dbo"
            };

            var dbService = new DbService(dbConfig);
            var personBuilder = new PersonBuilder(dbService);

            _personRepository = new PersonRepository(dbService, personBuilder);
        }

        [Fact]
        public async Task FindByIdAsync()
        {
            // Arrange
            var id = new Guid("0a24e0b6-f5cc-4902-9820-50af6871f225");
            var person = new Person(
                id, 
                "Rauny Stefano Marques",
                "rauny.stefano2211@gmail.com",
                "(11)4488-5020",
                "Rua Domingos de Braga, 200"
                );

            // Act
            var result = await _personRepository.FindById(id);

            // Assert
            Assert.True(result.Id == person.Id);
            Assert.True(result.FullName.Value == person.FullName.Value);
            Assert.True(result.Email.Value == person.Email.Value);
            Assert.True(result.Phone.Value == person.Phone.Value);
            Assert.True(result.Address.Value == person.Address.Value);
        }

        [Fact]
        public async Task Update()
        {
            // Arrange

            var id = new Guid("6982f837-2147-4a46-83d4-7b9bd2daae1");
            var person = new Person(
                id,
                "Julia Miranda Candido",
                "juliacandidomiranda11@gmail.com",
                "(11)97777-7777",
                "Rua imperatriz Leopoldina 1013"
                );

            // Act

            await _personRepository.Update(person);

            var result = await _personRepository.FindById(id);

            // Assert
            Assert.True(result.Id == person.Id);
            Assert.True(result.FullName.Value == person.FullName.Value);
            Assert.True(result.Email.Value == person.Email.Value);
            Assert.True(result.Phone.Value == person.Phone.Value);
            Assert.True(result.Address.Value == person.Address.Value);


        }
    }
}
