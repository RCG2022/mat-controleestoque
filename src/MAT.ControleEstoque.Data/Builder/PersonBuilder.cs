using Dapper;
using MAT.ControleEstoque.Data.Core;
using MAT.ControleEstoque.Data.View;
using System.Data;

namespace MAT.ControleEstoque.Data.Builder
{
    public partial class PersonBuilder : IPersonBuilder
    {
        public Request FindByIdRequest(Guid id)
        {
            var sql = FindByIdSql();
            var parameters = new DynamicParameters();
            parameters.Add(PARAM_ID, id, DbType.Guid, ParameterDirection.Input);

            return new Request(sql, parameters);
        }

        public Request FindAllRequest(string fullName)
        {
            throw new NotImplementedException();
        }

        public Request InsertRequest(PersonView person)
        {
            throw new NotImplementedException();
        }

        public Request UpdateRequest(PersonView person)
        {
            throw new NotImplementedException();
        }
    }
}
