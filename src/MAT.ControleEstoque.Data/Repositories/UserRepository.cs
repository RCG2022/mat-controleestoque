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

        public IEnumerable<User> FindAll(string login)
        {
            throw new NotImplementedException();
        }

        public User Login(string login, string password)
        {
            throw new NotImplementedException();
        }

        public void Insert(User user)
        {
            throw new NotImplementedException();
        }

        public void Update(User user)
        {
            throw new NotImplementedException();
        }

        public void UpdatePassword(Guid id, string password, string newPassword)
        {
            throw new NotImplementedException();
        }
    }
}
