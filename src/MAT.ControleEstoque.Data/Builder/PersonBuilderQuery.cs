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

        protected string InsertSql()
        {
            var query = new StringBuilder();
            query.AppendLine($"INSERT Person");
            query.AppendLine($"     ( Person.Id");
            query.AppendLine($"	    , Person.FullName");
            query.AppendLine($"	    , Person.Email");
            query.AppendLine($"	    , Person.Telephone");
            query.AppendLine($"	    , Person.Address");
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
