using MAT.ControleEstoque.Business.Entities;
using MAT.ControleEstoque.Business.Interfaces;
using MAT.ControleEstoque.Business.ValueObjects.User;
using MAT.ControleEstoque.Data.Builder;
using MAT.ControleEstoque.Data.Core;
using MAT.ControleEstoque.Data.View;

namespace MAT.ControleEstoque.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        protected readonly IDbService _dbService;
        private readonly ISystemUserBuilder _userBuilder;

        public UserRepository(IDbService dbService, ISystemUserBuilder userBuilder)
        {
            _dbService = dbService;
            _userBuilder = userBuilder;
        }

        public User FindById(Guid id)
        {
            var request = _userBuilder.FindByIdRequest(id);
            var userView = _dbService.ExecuteQueryFirstOrDefault<SystemUserView>(request);

            if (userView is null)
                return null;

            var user = new User(
                userView.Id,
                new Login(userView.Login),
                new Password(userView.Password),
                userView.Enabled
                );

            return user;
        }

        public IEnumerable<User> FindAll(string login)
        {
            var request = _userBuilder.FindAllRequest(login);
            var userViewList = _dbService.ExecuteQueryRequest<SystemUserView>(request);

            var userList = new List<User>();
            foreach (var userView in userViewList)
            {
                var user = new User(
                 userView.Id,
                 new Login(userView.Login),
                 new Password(userView.Password),
                 userView.Enabled
                 );

                userList.Add(user);
            }

            return userList;
        }

        public User Login(string login, string password)
        {
            var request = _userBuilder.LoginRequest(login, password);
            var userView = _dbService.ExecuteQueryFirstOrDefault<SystemUserView>(request);

            if (userView is null)
                return null;

            var user = new User(
                userView.Id,
                new Login(userView.Login),
                new Password(userView.Password),
                userView.Enabled
                );

            return user;
        }

        public void Insert(User user)
        {
            var userView = new SystemUserView();
            userView.Id = user.Id;
            userView.Login = user.Login.Value;
            userView.Password = user.Password.Value;
            userView.Enabled = user.Enabled;

            var request = _userBuilder.InsertRequest(userView);
            _dbService.ExecuteCommandRequest(request);
        }

        public void Update(User user)
        {
            var userView = new SystemUserView();
            userView.Id = user.Id;
            userView.Login = user.Login.Value;
            userView.Password = user.Password.Value;
            userView.Enabled = user.Enabled;

            var request = _userBuilder.UpdateRequest(userView);
            _dbService.ExecuteCommandRequest(request);
        }

        public void UpdatePassword(Guid id, string password)
        {
            var request = _userBuilder.UpdatePasswordRequest(id, password);
            _dbService.ExecuteCommandRequest(request);
        }
    }
}
