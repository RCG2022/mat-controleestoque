using Dapper;
using MAT.ControleEstoque.Data.Configurations;
using System.Data;
using System.Data.SqlClient;

namespace MAT.ControleEstoque.Data.Core
{
    public class DbService : IDbService
    {
        private readonly DbConfig _configuration;

        private const string CONNECTION_STRING_ERROR = "A conexão do Sql Serverr não foi informada";
        private const string GENERIC_ERROR = "Houve um problema no serviço de banco de dados.";

        public string Schema => _configuration.Schema;

        public DbService(DbConfig configuration)
        {
            _configuration = configuration;
            if (string.IsNullOrEmpty(_configuration.ConnectionString))
                throw new ArgumentNullException(CONNECTION_STRING_ERROR);

        }

        public IDbConnection CreateConnection() => new SqlConnection(_configuration.ConnectionString);

        public IEnumerable<TOutput> ExecuteQueryRequest<TOutput>(Request queryRequest)
        {
            var result = default(IEnumerable<TOutput>);
            using var connection = CreateConnection();

            try
            {
                connection.Open();
                result = connection.Query<TOutput>(
                    queryRequest.Sql,
                    queryRequest.DynamicParameters);

                if (result is null || result.AsList().Count == 0)
                    return null;
            }
            catch (Exception ex)
            {
                throw new Exception(GENERIC_ERROR, ex);
            }
            finally
            {
                connection.Close();
            }

            return result;
        }

        public TOutput ExecuteQueryFirstOrDefault<TOutput>(Request queryRequest)
        {
            var result = default(TOutput);
            using var connection = CreateConnection();

            try
            {
                connection.Open();
                result = connection.QueryFirstOrDefault<TOutput>(
                    queryRequest.Sql,
                    queryRequest.DynamicParameters);
            }
            catch (Exception ex)
            {
                throw new Exception(GENERIC_ERROR, ex);
            }
            finally
            {
                connection.Close();
            }

            return result;
        }

        public void ExecuteCommandRequest(Request commandRequest)
        {
            using var connection = CreateConnection();

            try
            {
                connection.Open();
                using var transaction = connection.BeginTransaction();

                try
                {
                    connection.Execute(
                        commandRequest.Sql,
                        commandRequest.DynamicParameters,
                        transaction);

                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(GENERIC_ERROR, ex);
            }
            finally
            {
                connection.Close();
            }
        }

        public void ExecuteCommandRequest(IEnumerable<Request> commandRequests)
        {
            using var connection = CreateConnection();

            try
            {
                connection.Open();
                using var transaction = connection.BeginTransaction();

                try
                {
                    foreach (var commandRequest in commandRequests)
                    {
                        connection.Execute(
                            commandRequest.Sql,
                            commandRequest.DynamicParameters,
                            transaction);
                    }

                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(GENERIC_ERROR, ex);
            }
            finally
            {
                connection.Close();
            }
        }

        public int ExecuteCommandRowsRequest(IEnumerable<Request> commandRequests)
        {
            int affectedLines = 0;
            using var connection = CreateConnection();

            try
            {
                connection.Open();
                using var transaction = connection.BeginTransaction();

                try
                {

                    foreach (var commandRequest in commandRequests)
                    {
                        affectedLines += connection.Execute(
                            commandRequest.Sql,
                            commandRequest.DynamicParameters,
                            transaction);
                    }

                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(GENERIC_ERROR, ex);
            }
            finally
            {
                connection.Close();
            }

            return affectedLines;
        }

        public void ExecuteProcedureRequest(
            IEnumerable<Request> commandRequests,
            IDbTransaction? transaction = null,
            int? commandTimeout = null
            )
        {
            using var connection = CreateConnection();

            try
            {
                connection.Open();
                foreach (var commandRequest in commandRequests)
                {
                    connection.Execute(
                        commandRequest.Sql,
                        commandRequest.DynamicParameters,
                        transaction,
                        commandTimeout,
                        CommandType.StoredProcedure
                        );
                }
            }
            catch (Exception ex)
            {
                throw new Exception(GENERIC_ERROR, ex);
            }
            finally
            {
                connection.Close();
            }
        }

        public IEnumerable<TOutput> ExecuteProcedureRequest<TOutput>(
            Request commandRequest,
            IDbTransaction? transaction = null,
            int? commandTimeout = null
            )
        {
            var result = default(IEnumerable<TOutput>);
            using var connection = CreateConnection();

            try
            {
                connection.Open();
                result = connection.Query<TOutput>(
                    commandRequest.Sql,
                    commandRequest.DynamicParameters,
                    transaction,
                    true,
                    commandTimeout,
                    CommandType.StoredProcedure
                    );
            }
            catch (Exception ex)
            {
                throw new Exception(GENERIC_ERROR, ex);
            }
            finally
            {
                connection.Close();
            }

            return result;
        }

    }
}
