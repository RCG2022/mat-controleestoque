using MAT.ControleEstoque.Business.Entities;

namespace MAT.ControleEstoque.Business.Interfaces
{
    public interface IPersonRepository
    {
        public Person Find(Guid id);

        public List<Person> FindAll(string fullName);

        public void Add(Person person);

        public void Update(Person person);
    }
}
