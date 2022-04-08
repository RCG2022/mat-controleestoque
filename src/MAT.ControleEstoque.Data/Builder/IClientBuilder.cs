using MAT.ControleEstoque.Data.Core;
using MAT.ControleEstoque.Data.View;

namespace MAT.ControleEstoque.Data.Builder
{
    public interface IClientBuilder
    {
        public Request FindByIdRequest(Guid id);

        public Request FindAllRequest(string fullName);

        public Request InsertRequest(ClientView client);

        public Request UpdateRequest(ClientView client);
    }
}

