using Dapper;
using MAT.ControleEstoque.Data.Core;
using MAT.ControleEstoque.Data.View;
using System.Data;

namespace MAT.ControleEstoque.Data.Builder
{
    public partial class ClientBuilder : IClientBuilder
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
            fullName = $"%{fullName}%";
            var sql = FindAlldSql();
            var parameters = new DynamicParameters();
            parameters.Add(PARAM_FULLNAME, fullName, DbType.String, ParameterDirection.Input);

            return new Request(sql, parameters);
        }

        public Request InsertRequest(ClientView client)
        {
            var sql = InsertSql();
            var parameters = new DynamicParameters();
            parameters.Add(PARAM_ID, client.Id, DbType.Guid, ParameterDirection.Input);
            parameters.Add(PARAM_FULLNAME, client.FullName, DbType.String, ParameterDirection.Input);
            parameters.Add(PARAM_EMAIL, client.Email, DbType.String, ParameterDirection.Input);
            parameters.Add(PARAM_TELEPHONE, client.Telephone, DbType.String, ParameterDirection.Input);
            parameters.Add(PARAM_ADDRESS, client.Address, DbType.String, ParameterDirection.Input);

            return new Request(sql, parameters);
        }

        public Request UpdateRequest(ClientView client)
        {
            var sql = UpdateSql();
            var parameters = new DynamicParameters();
            parameters.Add(PARAM_ID, client.Id , DbType.Guid, ParameterDirection.Input);
            parameters.Add(PARAM_FULLNAME, client.FullName, DbType.String, ParameterDirection.Input);
            parameters.Add(PARAM_EMAIL, client.Email, DbType.String, ParameterDirection.Input);
            parameters.Add(PARAM_TELEPHONE, client.Telephone, DbType.String, ParameterDirection.Input);
            parameters.Add(PARAM_ADDRESS, client.Address, DbType.String, ParameterDirection.Input);

            return new Request(sql, parameters);

        }
    }
}
