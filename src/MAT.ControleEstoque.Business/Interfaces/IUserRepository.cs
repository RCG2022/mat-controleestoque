using MAT.ControleEstoque.Business.Entities;

namespace MAT.ControleEstoque.Business.Interfaces
{
    public interface IUserRepository
    {
        public User Find(Guid id);

        public IEnumerable<User> FindAll(string login);

        public User Login(string login, string password);

        public void Insert(User user);

        public void Update(User user);

        public void UpdatePassword(Guid id, string password, string newPassword);
    }
}
