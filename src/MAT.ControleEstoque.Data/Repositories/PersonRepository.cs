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

        public async Task<List<Person>> FindAll(string fullName)
        {
            var request = _personBuilder.FindAllRequest(fullName);
            var personViewList = await _dbService.ExecuteQueryRequestAsync<PersonView>(request);

            var personList = new List<Person>();

            foreach(var personView in personViewList)
            {
                var person = new Person(
                personView.Id,
                personView.FullName,
                personView.Email,
                personView.Telephone,
                personView.Address
                );

                personList.Add(person);
            }

            return personList;
        }

        public async Task Update (Person person)
        {
            var personview = new PersonView();
            personview.Id = person.Id;
            personview.FullName = person.FullName.Value;
            personview.Email = person.Email.Value;
            personview.Telephone = person.Phone.Value;
            personview.Address = person.Address.Value;

            var request = _personBuilder.UpdateRequest(personview);

            await _dbService.ExecuteCommandRequestAsync(request);
            
        }
    }
}
