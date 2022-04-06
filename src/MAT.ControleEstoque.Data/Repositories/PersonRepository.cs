using MAT.ControleEstoque.Business.Entities;
using MAT.ControleEstoque.Business.Interfaces;
using MAT.ControleEstoque.Data.Builder;
using MAT.ControleEstoque.Data.Core;
using MAT.ControleEstoque.Data.View;

namespace MAT.ControleEstoque.Data.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        protected readonly IDbService _dbService;
        private readonly IPersonBuilder _personBuilder;

        public PersonRepository(IDbService dbService, IPersonBuilder personBuilder)
        {
            _dbService = dbService;
            _personBuilder = personBuilder;
        }

        public async Task<Person> FindById(Guid id)
        {
            var request = _personBuilder.FindByIdRequest(id);
            var personView = await _dbService.ExecuteQueryFirstOrDefaultAsync<PersonView>(request);

            if (personView is null)
                return null;

            var person = new Person(
                personView.Id,
                personView.FullName,
                personView.Email,
                personView.Telephone,
                personView.Address
                );

            return person;
        }

        
        
        public async Task Add(Person person)
        {
            var personView = new PersonView();
            personView.Id = person.Id;
            personView.FullName = person.FullName.Value;
            personView.Email = person.Email.Value;
            personView.Telephone = person.Phone.Value;
            personView.Address = person.Address.Value;

            var request = _personBuilder.InsertRequest(personView);

            await _dbService.ExecuteCommandRequestAsync(request);
        }

        public Task<List<Person>> FindAll(string fullName)
        {
            throw new NotImplementedException();
        }

        public Task Update(Person person)
        {
            throw new NotImplementedException();
        }
    }
}
