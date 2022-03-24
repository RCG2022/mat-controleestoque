using MAT.ControleEstoque.Business.Entities;
using MAT.ControleEstoque.Business.Interfaces;

namespace MAT.ControleEstoque.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        public User Find(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<User> FindAll(string login)
        {
            throw new NotImplementedException();
        }

        public void Add(User user)
        {
            throw new NotImplementedException();
        }

        public void Update(User user)
        {
            throw new NotImplementedException();
        }
    }
}
