using Dapper;
using MAT.ControleEstoque.Data.Core;
using MAT.ControleEstoque.Data.View;
using System.Data;

namespace MAT.ControleEstoque.Data.Builder
{
    public partial class SystemUserBuilder : ISystemUserBuilder
    {
        public Request FindByIdRequest(Guid id)
        {
            var sql = FindByIdSql();
            var parameters = new DynamicParameters();
            parameters.Add(PARAM_ID, id, DbType.Guid, ParameterDirection.Input);

            return new Request(sql, parameters);
        }

       
        public Request FindAllRequest(string login)
        {
            login = $"%{login}%";
            var sql = FindAllSql();
            var parameters = new DynamicParameters();
            parameters.Add(PARAM_LOGIN, login, DbType.String, ParameterDirection.Input);

            return new Request(sql, parameters);
        }

        public Request LoginRequest(string login, string password)
        {
            var sql = LoginSql();
            var parameters = new DynamicParameters();
            parameters.Add(PARAM_LOGIN, login, DbType.String, ParameterDirection.Input);
            parameters.Add(PARAM_PASSWORD, password, DbType.String, ParameterDirection.Input);

            return new Request(sql, parameters);
        }

        public Request InsertRequest(SystemUserView SystemUser)
        {
            var sql = InsertSql();
            var parameters = new DynamicParameters();
            parameters.Add(PARAM_ID, SystemUser.Id, DbType.Guid, ParameterDirection.Input);
            parameters.Add(PARAM_LOGIN, SystemUser.Login, DbType.String, ParameterDirection.Input);
            parameters.Add(PARAM_PASSWORD, SystemUser.Password, DbType.String, ParameterDirection.Input);
            parameters.Add(PARAM_ENABLED, SystemUser.Enabled, DbType.Boolean, ParameterDirection.Input);

            return new Request(sql, parameters);
        }

        public Request UpdateRequest(SystemUserView SystemUser)
        {
            var sql = UpdateSql();
            var parameters = new DynamicParameters();
            parameters.Add(PARAM_ID, SystemUser.Id, DbType.Guid, ParameterDirection.Input);
            parameters.Add(PARAM_LOGIN, SystemUser.Login, DbType.String, ParameterDirection.Input);
            parameters.Add(PARAM_ENABLED, SystemUser.Enabled, DbType.Boolean, ParameterDirection.Input);

            return new Request(sql, parameters);
        }

        public Request UpdatePasswordRequest(Guid id, string password)
        {
            var sql = UpdatePasswordSql();
            var parameters = new DynamicParameters();
            parameters.Add(PARAM_ID, id, DbType.Guid, ParameterDirection.Input);
            parameters.Add(PARAM_PASSWORD, password, DbType.String, ParameterDirection.Input);

            return new Request(sql, parameters);
        }


    }
}
