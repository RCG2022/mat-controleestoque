using MAT.ControleEstoque.Business.Entities;
using MAT.ControleEstoque.Business.Interfaces;

namespace MAT.ControleEstoque.Business.Services
{
    public class AppService : IAppService
    {
        private User _loggerUser;

        public AppService()
        {

        }

        public User GetLoggedUser()
        {
            return _loggerUser;
        }

        public void SetLoggedUser(User user)
        {
            _loggerUser = user;
        }
    }
}
