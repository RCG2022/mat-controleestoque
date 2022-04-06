using MAT.ControleEstoque.Data.Core;
using System.Text;

namespace MAT.ControleEstoque.Data.Builder
{
    public partial class PersonBuilder
    {
        private readonly string _dbSchema;

        private const string PARAM_ID = "@Id";
        private const string PARAM_FULLNAME = "@FullName";
        private const string PARAM_EMAIL = "@Email";
        private const string PARAM_TELEPHONE = "@Telephone";
        private const string PARAM_ADDRESS = "@Address";

        public PersonBuilder(IDbService dbService)
        {
            _dbSchema = dbService.Schema;
        }

        protected string FindByIdSql()
        {
            var query = new StringBuilder();
            query.AppendLine($"SELECT Person.Id");
            query.AppendLine($"     , Person.FullName");
            query.AppendLine($"     , Person.Email");
            query.AppendLine($"     , Person.Telephone");
            query.AppendLine($"     , Person.Address");
            query.AppendLine($"  FROM {_dbSchema}.Person WITH(NOLOCK)");
            query.AppendLine($" WHERE Person.Id = {PARAM_ID}");

            return query.ToString();
        }

        protected string UpdateSql()
        {
            var query = new StringBuilder();
            query.AppendLine($"UPDATE Person");          
            query.AppendLine($"   SET Person.FullName = {PARAM_FULLNAME}" );
            query.AppendLine($"     , Person.Email = {PARAM_EMAIL}");
            query.AppendLine($"     , Person.Telephone = {PARAM_TELEPHONE}");
            query.AppendLine($"     , Person.Address = {PARAM_ADDRESS}");       
            query.AppendLine($" WHERE Person.Id = {PARAM_ID}");

            return query.ToString();
        }

        protected string FindAlldSql()
        {
            var query = new StringBuilder();
            query.AppendLine($"SELECT Person.Id");
            query.AppendLine($"     , Person.FullName");
            query.AppendLine($"     , Person.Email");
            query.AppendLine($"     , Person.Telephone");
            query.AppendLine($"     , Person.Address");
            query.AppendLine($"  FROM {_dbSchema}.Person WITH(NOLOCK)");
            query.AppendLine($" WHERE Person.FullName LIKE {PARAM_FULLNAME}");

            return query.ToString();
        }
    }
}
