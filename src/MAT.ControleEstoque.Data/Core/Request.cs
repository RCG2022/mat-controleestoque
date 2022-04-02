using Dapper;

namespace MAT.ControleEstoque.Data.Core
{
    public class Request
    {
        public string Sql { get; protected set; }

        public DynamicParameters DynamicParameters { get; protected set; }

        public Request(string sql, DynamicParameters dynamicParameters)
        {
            Sql = sql;
            DynamicParameters = dynamicParameters;
        }
    }
}
