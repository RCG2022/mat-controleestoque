using MAT.ControleEstoque.Data.Core;
using MAT.ControleEstoque.Data.View;

namespace MAT.ControleEstoque.Data.Builder
{
    public interface ISystemUserBuilder
    {
        public Request FindByIdRequest(Guid id);

        public Request FindByLoginRequest(string Login);

        public Request UpdateRequest(PersonView person);
    }
}

