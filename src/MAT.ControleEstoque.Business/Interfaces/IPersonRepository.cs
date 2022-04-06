using MAT.ControleEstoque.Business.Entities;

namespace MAT.ControleEstoque.Business.Interfaces
{
    public interface IPersonRepository
    {
        public Task<Person> FindById(Guid id);

        public Task<List<Person>> FindAll(string fullName);

        public Task Add(Person person);

        public Task Update(Person person);
    }
}
