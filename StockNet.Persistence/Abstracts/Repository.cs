using System.Data.SqlClient;
using System.Threading;
using System.Threading.Tasks;

namespace StockNet.Persistence.Abstracts
{
    public abstract class Repository
    {
        public SqlCommand CreateCommand(){
            return new SqlCommand();
        }

        public async Task<object> ExecuteScalarAsync(SqlCommand command, CancellationToken cancellationToken){
            return await command.ExecuteScalarAsync(cancellationToken);
        }

        public async Task ExecuteNonQueryAsync(SqlCommand command, CancellationToken cancellationToken){
            await command.ExecuteNonQueryAsync(cancellationToken);
        }

        public async Task<SqlDataReader> ExecuteReaderAsync(SqlCommand command, CancellationToken cancellationToken){
            return await command.ExecuteReaderAsync(cancellationToken);
        }
    }
}
