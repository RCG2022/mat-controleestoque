using MAT.ControleEstoque.Data.Core;
using MAT.ControleEstoque.Data.View;

namespace MAT.ControleEstoque.Data.Builder
{
    public interface ISystemUserBuilder
    {
        public Request FindByIdRequest(Guid id);

        public Request FindAllRequest(string Login);

        public Request LoginRequest(string login, string password);

        public Request InsertRequest(SystemUserView SystemUser);

        public Request UpdateRequest(SystemUserView SystemUser);

        public Request UpdatePasswordRequest(Guid id, string password);
    }
}

