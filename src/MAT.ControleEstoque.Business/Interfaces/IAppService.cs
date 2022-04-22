using MAT.ControleEstoque.Business.Entities;

namespace MAT.ControleEstoque.Business.Interfaces
{
    public interface IAppService
    {
        public User GetLoggedUser();

        public void SetLoggedUser(User user);
    }
}
