using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading;
using System.Threading.Tasks;
using StockNet.Application.CandleSticks.Queries.GetAfter;
using StockNet.Application.Common.Interfaces;
using StockNet.Core.Entities;
using StockNet.Persistence.Abstracts;

namespace StockNet.Persistence
{
    public class CandleStickRepository : Repository, ICandleStickRepository
    {
        public async Task Add(CandleStick entity, CancellationToken cancellationToken)
        {
            var command = CreateCommand();

            command.CommandText = $"INSERT INTO CandleSticks VALUES(@High, @Open, @Close, @Low, @Volume, @Date);";

            command.Parameters.Add(new SqlParameter("@High", entity.High));
            command.Parameters.Add(new SqlParameter("@Open", entity.Open));
            command.Parameters.Add(new SqlParameter("@Close", entity.Close));
            command.Parameters.Add(new SqlParameter("@Low", entity.Low));
            command.Parameters.Add(new SqlParameter("@Volume", entity.Volume));
            command.Parameters.Add(new SqlParameter("@Date", entity.Date));

            var id = await ExecuteScalarAsync(command, cancellationToken);

            if (id != null)
                entity.Id = (int)id;
        }

        public async Task Delete(int entityId, CancellationToken cancellationToken)
        {
            var command = CreateCommand();

            command.CommandText = $"DELETE FROM CandleSticks WHERE Id = @Id";

            command.Parameters.Add(new SqlParameter("@Id", entityId));

            await ExecuteNonQueryAsync(command, cancellationToken);
        }

        public async Task<IEnumerable<CandleStick>> GetAll(CancellationToken cancellationToken)
        {
            var command = CreateCommand();

            command.CommandText = $"SELECT * FROM CandleSticks";

            var queryResult = new List<CandleStick>();
            using (var reader = await ExecuteReaderAsync(command, cancellationToken)){
                while(reader.Read()){
                    var candleStick = CandleStick.Create(
                        reader.GetInt32(1),
                        reader.GetInt64(2),
                        reader.GetInt64(3),
                        reader.GetInt64(4),
                        reader.GetInt64(5),
                        reader.GetDateTime(6)
                    );
                    candleStick.Id = reader.GetInt16(0);
                    
                    queryResult.Add(candleStick);
                }
            }

            return queryResult;
        }

        public async Task<CandleStick> GetById(int entityId, CancellationToken cancellationToken)
        {
            var command = CreateCommand();

            command.CommandText = $"SELECT * FROM CandleSticks WHERE Id = @Id";

            command.Parameters.Add(new SqlParameter("@Id", entityId));

            CandleStick entity;
            using (var reader = await ExecuteReaderAsync(command, cancellationToken)){
                if (!reader.Read())
                    return default(CandleStick);

                var candleStick = CandleStick.Create(
                    reader.GetInt32(1),
                    reader.GetInt64(2),
                    reader.GetInt64(3),
                    reader.GetInt64(4),
                    reader.GetInt64(5),
                    reader.GetDateTime(6)
                );
                candleStick.Id = reader.GetInt16(0);
                    
                entity = candleStick;
            }

            return entity;
        }

        public async Task<IEnumerable<CandleStick>> GetCandlesAfter(GetAfterCandleStickQuery query, CancellationToken cancellationToken)
        {
            var command = CreateCommand();

            command.CommandText = $"SELECT * FROM CandleSticks WHERE Date > @Date";

            command.Parameters.Add(new SqlParameter("@Date", query.Date));

            var queryResult = new List<CandleStick>();
            using (var reader = await ExecuteReaderAsync(command, cancellationToken)){
                while(reader.Read()){
                    var candleStick = CandleStick.Create(
                        reader.GetInt32(1),
                        reader.GetInt64(2),
                        reader.GetInt64(3),
                        reader.GetInt64(4),
                        reader.GetInt64(5),
                        reader.GetDateTime(6)
                    );
                    candleStick.Id = reader.GetInt16(0);
                    
                    queryResult.Add(candleStick);
                }
            }

            return queryResult;
        }

        public async Task<IEnumerable<CandleStick>> GetCandlesAtOrAfter(GetAfterCandleStickQuery query, CancellationToken cancellationToken)
        {
            var command = CreateCommand();

            command.CommandText = $"SELECT * FROM CandleSticks WHERE Date >= @Date";

            command.Parameters.Add(new SqlParameter("@Date", query.Date));

            var queryResult = new List<CandleStick>();
            using (var reader = await ExecuteReaderAsync(command, cancellationToken)){
                while(reader.Read()){
                    var candleStick = CandleStick.Create(
                        reader.GetInt32(1),
                        reader.GetInt64(2),
                        reader.GetInt64(3),
                        reader.GetInt64(4),
                        reader.GetInt64(5),
                        reader.GetDateTime(6)
                    );
                    candleStick.Id = reader.GetInt16(0);
                    
                    queryResult.Add(candleStick);
                }
            }

            return queryResult;
        }

        public async Task Update(CandleStick entity, CancellationToken cancellationToken)
        {
            var command = CreateCommand();

            command.CommandText = $"UPDATE CandleSticks SET High = @High, Open = @Open, Close = @Close, Low = @Low, Volume = @Volume, Date = @Date);";

            command.Parameters.Add(new SqlParameter("@Id", entity.Id));
            command.Parameters.Add(new SqlParameter("@High", entity.High));
            command.Parameters.Add(new SqlParameter("@Open", entity.Open));
            command.Parameters.Add(new SqlParameter("@Close", entity.Close));
            command.Parameters.Add(new SqlParameter("@Low", entity.Low));
            command.Parameters.Add(new SqlParameter("@Volume", entity.Volume));
            command.Parameters.Add(new SqlParameter("@Date", entity.Date));

            await ExecuteNonQueryAsync(command, cancellationToken);
        }
    }
}
