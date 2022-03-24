using MAT.ControleEstoque.Business.Entities;
using MAT.ControleEstoque.Business.Interfaces;

namespace MAT.ControleEstoque.Data.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        public Person Find(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<Person> FindAll(string fullName)
        {
            throw new NotImplementedException();
        }

        public void Add(Person person)
        {
            throw new NotImplementedException();
        }

        public void Update(Person person)
        {
            throw new NotImplementedException();
        }
    }
}
