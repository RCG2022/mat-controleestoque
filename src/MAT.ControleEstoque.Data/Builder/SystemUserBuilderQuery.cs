using MAT.ControleEstoque.Data.Core;
using System.Text;

namespace MAT.ControleEstoque.Data.Builder
{
    public partial class SystemUserBuilder
    {
        private readonly string _dbSchema;

        private const string PARAM_ID = "@Id";
        private const string PARAM_ID_PERSON = "@IdPerson";
        private const string PARAM_LOGIN = "@Login";
        private const string PARAM_PASSWORD = "@Password";    

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
            query.AppendLine($"  FROM {_dbSchema}.SystemUser WITH(NOLOCK)");
            query.AppendLine($" WHERE SystemUser.Id = {PARAM_ID}");

            return query.ToString();
        }

        protected string FindByLoginSql()
        {
            var query = new StringBuilder();
            query.AppendLine($"SELECT SystemUser.Id");
            query.AppendLine($"     , SystemUser.Login");
            query.AppendLine($"     , SystemUser.Password");
            query.AppendLine($"  FROM {_dbSchema}.SystemUser WITH(NOLOCK)");
            query.AppendLine($" WHERE SystemUser.Login = {PARAM_LOGIN}");

            return query.ToString();
        }

        protected string UpdateSql()
        {
            var query = new StringBuilder();
            query.AppendLine($"UPDATE SystemUser");          
            query.AppendLine($"   SET SystemUser.Login = {PARAM_LOGIN}" );
            query.AppendLine($"     , SystemUser.Password = {PARAM_PASSWORD}");      
            query.AppendLine($" WHERE SystemUser.Id = {PARAM_ID}");

            return query.ToString();
        }         
    }
}
