using MAT.ControleEstoque.Business.Entities;

namespace MAT.ControleEstoque.Business.Interfaces
{
    public interface IUserRepository
    {
        public User FindById(Guid id); // rauny

        public IEnumerable<User> FindAll(string login); // gu

        public User Login(string login, string password); // rafael

        public void Insert(User user); // gu

        public void Update(User user); // rauny

        public void UpdatePassword(Guid id, string password); // rafael
    }
}
