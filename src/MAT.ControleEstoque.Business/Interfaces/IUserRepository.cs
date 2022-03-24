using MAT.ControleEstoque.Business.Entities;

namespace MAT.ControleEstoque.Business.Interfaces
{
    public interface IUserRepository
    {
        public User Find(Guid id);

        public List<User> FindAll(string login);

        public void Add(User user);

        public void Update(User user);
    }
}
