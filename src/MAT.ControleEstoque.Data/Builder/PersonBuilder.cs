﻿using Dapper;
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
            fullName = $"%{fullName}%";
            var sql = FindAlldSql();
            var parameters = new DynamicParameters();
            parameters.Add(PARAM_FULLNAME, fullName, DbType.String, ParameterDirection.Input);

            return new Request(sql, parameters);
        }

        public Request InsertRequest(PersonView person)
        {
            var sql = InsertSql();
            var parameters = new DynamicParameters();
            parameters.Add(PARAM_ID, person.Id, DbType.Guid, ParameterDirection.Input);
            parameters.Add(PARAM_FULLNAME, person.FullName, DbType.String, ParameterDirection.Input);
            parameters.Add(PARAM_EMAIL, person.Email, DbType.String, ParameterDirection.Input);
            parameters.Add(PARAM_TELEPHONE, person.Telephone, DbType.String, ParameterDirection.Input);
            parameters.Add(PARAM_ADDRESS, person.Address, DbType.String, ParameterDirection.Input);

            return new Request(sql, parameters);
        }

        public Request UpdateRequest(PersonView person)
        {
            var sql = UpdateSql();
            var parameters = new DynamicParameters();
            parameters.Add(PARAM_ID, person.Id , DbType.Guid, ParameterDirection.Input);
            parameters.Add(PARAM_FULLNAME, person.FullName, DbType.String, ParameterDirection.Input);
            parameters.Add(PARAM_EMAIL, person.Email, DbType.String, ParameterDirection.Input);
            parameters.Add(PARAM_TELEPHONE, person.Telephone, DbType.String, ParameterDirection.Input);
            parameters.Add(PARAM_ADDRESS, person.Address, DbType.String, ParameterDirection.Input);

            return new Request(sql, parameters);

        }
    }
}
