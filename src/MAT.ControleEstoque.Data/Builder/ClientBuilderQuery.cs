using MAT.ControleEstoque.Data.Core;
using System.Text;

namespace MAT.ControleEstoque.Data.Builder
{
    public partial class ClientBuilder
    {
        private readonly string _dbSchema;

        private const string PARAM_ID = "@Id";
        private const string PARAM_FULLNAME = "@FullName";
        private const string PARAM_EMAIL = "@Email";
        private const string PARAM_TELEPHONE = "@Telephone";
        private const string PARAM_ADDRESS = "@Address";

        public ClientBuilder(IDbService dbService)
        {
            _dbSchema = dbService.Schema;
        }

        protected string FindByIdSql()
        {
            var query = new StringBuilder();
            query.AppendLine($"SELECT Client.Id");
            query.AppendLine($"     , Client.FullName");
            query.AppendLine($"     , Client.Email");
            query.AppendLine($"     , Client.Telephone");
            query.AppendLine($"     , Client.Address");
            query.AppendLine($"  FROM {_dbSchema}.Client WITH(NOLOCK)");
            query.AppendLine($" WHERE Client.Id = {PARAM_ID}");

            return query.ToString();
        }

        protected string FindAlldSql()
        {
            var query = new StringBuilder();
            query.AppendLine($"SELECT Client.Id");
            query.AppendLine($"     , Client.FullName");
            query.AppendLine($"     , Client.Email");
            query.AppendLine($"     , Client.Telephone");
            query.AppendLine($"     , Client.Address");
            query.AppendLine($"  FROM {_dbSchema}.Client WITH(NOLOCK)");
            query.AppendLine($" WHERE UPPER(Client.FullName) LIKE UPPER({PARAM_FULLNAME})");

            return query.ToString();
        }

        protected string UpdateSql()
        {
            var query = new StringBuilder();
            query.AppendLine($"UPDATE Client");          
            query.AppendLine($"   SET Client.FullName = {PARAM_FULLNAME}" );
            query.AppendLine($"     , Client.Email = {PARAM_EMAIL}");
            query.AppendLine($"     , Client.Telephone = {PARAM_TELEPHONE}");
            query.AppendLine($"     , Client.Address = {PARAM_ADDRESS}");       
            query.AppendLine($" WHERE Client.Id = {PARAM_ID}");

            return query.ToString();
        }

        protected string InsertSql()
        {
            var query = new StringBuilder();
            query.AppendLine($"INSERT Client");
            query.AppendLine($"     ( Client.Id");
            query.AppendLine($"	    , Client.FullName");
            query.AppendLine($"	    , Client.Email");
            query.AppendLine($"	    , Client.Telephone");
            query.AppendLine($"	    , Client.Address");
            query.AppendLine($"	    )");
            query.AppendLine($"     VALUES");
            query.AppendLine($"     ( {PARAM_ID}");
            query.AppendLine($"	    , {PARAM_FULLNAME}");
            query.AppendLine($"	    , {PARAM_EMAIL}");
            query.AppendLine($"	    , {PARAM_TELEPHONE}");
            query.AppendLine($"	    , {PARAM_ADDRESS}");
            query.AppendLine($"	    )");

            return query.ToString();
        }


    }
}
