using MAT.ControleEstoque.Data.Core;
using System.Text;

namespace MAT.ControleEstoque.Data.Builder
{
    public partial class SystemUserBuilder
    {
        private readonly string _dbSchema;

        private const string PARAM_ID = "@Id";
        private const string PARAM_LOGIN = "@Login";
        private const string PARAM_PASSWORD = "@Password";
        private const string PARAM_ENABLED = "@Enabled";

        public SystemUserBuilder(IDbService dbService)
        {
            _dbSchema = dbService.Schema;
        }

        protected string FindByIdSql()
        {
            var query = new StringBuilder();
            query.AppendLine($"SELECT SystemUser.Id");
            query.AppendLine($"     , SystemUser.Login");
            query.AppendLine($"     , SystemUser.Password");
            query.AppendLine($"     , SystemUser.Enabled");
            query.AppendLine($"  FROM {_dbSchema}.SystemUser WITH(NOLOCK)");
            query.AppendLine($" WHERE SystemUser.Id = {PARAM_ID}");

            return query.ToString();
        }

        protected string FindAllSql()
        {
            var query = new StringBuilder();
            query.AppendLine($"SELECT SystemUser.Id");
            query.AppendLine($"     , SystemUser.Login");
            query.AppendLine($"     , SystemUser.Password");
            query.AppendLine($"     , SystemUser.Enabled");
            query.AppendLine($"  FROM {_dbSchema}.SystemUser WITH(NOLOCK)");
            query.AppendLine($" WHERE UPPER(SystemUser.Login) LIKE UPPER({PARAM_LOGIN})");

            return query.ToString();
        }
        protected string LoginSql()
        {
            var query = new StringBuilder();
            query.AppendLine($"SELECT SystemUser.Id");
            query.AppendLine($"     , SystemUser.Login");
            query.AppendLine($"     , SystemUser.Password");
            query.AppendLine($"     , SystemUser.Enabled");
            query.AppendLine($"  FROM {_dbSchema}.SystemUser WITH(NOLOCK)");
            query.AppendLine($" WHERE UPPER(SystemUser.Login) = UPPER({PARAM_LOGIN})");
            query.AppendLine($"   AND UPPER(SystemUser.Password) = UPPER({PARAM_PASSWORD})");
            return query.ToString();
        }

        protected string CheckLoginSql()
        {
            var query = new StringBuilder();
            query.AppendLine($"SELECT SystemUser.Id");
            query.AppendLine($"     , SystemUser.Login");
            query.AppendLine($"     , SystemUser.Password");
            query.AppendLine($"     , SystemUser.Enabled");
            query.AppendLine($"  FROM {_dbSchema}.SystemUser WITH(NOLOCK)");
            query.AppendLine($" WHERE UPPER(SystemUser.Login) = UPPER({PARAM_LOGIN})");
            return query.ToString();
        }


        protected string InsertSql()
        {
            var query = new StringBuilder();
            query.AppendLine($"INSERT SystemUser");
            query.AppendLine($"     ( SystemUser.Id");
            query.AppendLine($"	    , SystemUser.Login");
            query.AppendLine($"	    , SystemUser.Password");
            query.AppendLine($"	    , SystemUser.Enabled");
            query.AppendLine($"	    )");
            query.AppendLine($"     VALUES");
            query.AppendLine($"     ( {PARAM_ID}");
            query.AppendLine($"	    , {PARAM_LOGIN}");
            query.AppendLine($"	    , {PARAM_PASSWORD}");
            query.AppendLine($"	    , {PARAM_ENABLED}");
            query.AppendLine($"	    )");
            return query.ToString();
        }

        protected string UpdateSql()
        {
            var query = new StringBuilder();
            query.AppendLine($"UPDATE SystemUser");
            query.AppendLine($"   SET SystemUser.Login = {PARAM_LOGIN}");
            query.AppendLine($"     , SystemUser.Enabled = {PARAM_ENABLED}");
            query.AppendLine($" WHERE SystemUser.Id = {PARAM_ID}");

            return query.ToString();
        }

        protected string UpdatePasswordSql()
        {
            var query = new StringBuilder();
            query.AppendLine($"UPDATE SystemUser");
            query.AppendLine($"   SET SystemUser.Password = {PARAM_PASSWORD}");
            query.AppendLine($" WHERE SystemUser.Id = {PARAM_ID}");

            return query.ToString();
        }
    }
}
