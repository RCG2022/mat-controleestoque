using MAT.ControleEstoque.Data.Core;
using MAT.ControleEstoque.Data.View;

namespace MAT.ControleEstoque.Data.Builder
{
    public interface IPersonBuilder
    {
        public Request FindByIdRequest(Guid id);

        public Request FindAllRequest(string fullName);

        public Request InsertRequest(PersonView person);

        public Request UpdateRequest(PersonView person);
    }
}

