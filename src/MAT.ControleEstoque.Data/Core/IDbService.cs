using System.Data;

namespace MAT.ControleEstoque.Data.Core
{
    public interface IDbService
    {
        string Schema { get; }

        IDbConnection CreateConnection();

        public IEnumerable<TOutput> ExecuteQueryRequest<TOutput>(Request queryRequest);

        public TOutput ExecuteQueryFirstOrDefault<TOutput>(Request queryRequest);

        public void ExecuteCommandRequest(Request commandRequests);

        public void ExecuteCommandRequest(IEnumerable<Request> commandRequests);

        public int ExecuteCommandRowsRequest(IEnumerable<Request> commandRequests);

        void ExecuteProcedureRequest(
            IEnumerable<Request> commandRequests,
            IDbTransaction? transaction = null,
            int? commandTimeout = null
            );

        IEnumerable<TOutput> ExecuteProcedureRequest<TOutput>(
            Request commandRequest,
            IDbTransaction? transaction = null,
            int? commandTimeout = null
            );
    }
}
