using MAT.ControleEstoque.Data.Core;
using System.Text;

namespace MAT.ControleEstoque.Data.Builder
{
    public partial class PersonBuilder
    {
        private readonly string _dbSchema;

        private const string PARAM_ID = "@Id";

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
    }
}
