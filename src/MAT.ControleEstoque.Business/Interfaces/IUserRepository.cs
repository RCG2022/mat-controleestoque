using MAT.ControleEstoque.Business.Entities;
using MAT.ControleEstoque.Business.ValueObjects.User;

namespace MAT.ControleEstoque.Business.Interfaces
{
    public interface IUserRepository
    {
        public User FindById(Guid id); 

        public IEnumerable<User> FindAll(string login);

        public User Login(Login login, Password password);

        public bool CheckLogin(Login login);

        public void Insert(User user);

        public void Update(User user); 

        public void UpdatePassword(Guid id, Password password); 
    }
}
