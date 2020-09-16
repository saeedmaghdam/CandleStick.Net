using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading;
using System.Threading.Tasks;
using StockNet.Application.CandleSticks;
using StockNet.Application.CandleSticks.Queries.GetAfter;
using StockNet.Application.Common.Interfaces;
using StockNet.Core.Entities;
using StockNet.Core.Interfaces;
using StockNet.Persistence.Abstracts;

namespace StockNet.Persistence
{
    public class CandleStickRepository : Repository, ICandleStickRepository
    {
        private readonly ICandleStickManager _candleStickManager;

        public CandleStickRepository(ICandleStickManager candleStickManager)
        {
            this._candleStickManager = candleStickManager;
        }

        public async Task Add(ICandleStick model, CancellationToken cancellationToken)
        {
            var command = CreateCommand();

            command.CommandText = $"INSERT INTO CandleSticks VALUES(@High, @Open, @Close, @Low, @Volume, @Date);";

            command.Parameters.Add(new SqlParameter("@High", model.High));
            command.Parameters.Add(new SqlParameter("@Open", model.Open));
            command.Parameters.Add(new SqlParameter("@Close", model.Close));
            command.Parameters.Add(new SqlParameter("@Low", model.Low));
            command.Parameters.Add(new SqlParameter("@Volume", model.Volume));
            command.Parameters.Add(new SqlParameter("@Date", model.Date));

            var id = await ExecuteScalarAsync(command, cancellationToken);

            if (id != null)
                model.Id = (int)id;
        }

        public async Task Delete(int entityId, CancellationToken cancellationToken)
        {
            var command = CreateCommand();

            command.CommandText = $"DELETE FROM CandleSticks WHERE Id = @Id";

            command.Parameters.Add(new SqlParameter("@Id", entityId));

            await ExecuteNonQueryAsync(command, cancellationToken);
        }

        public async Task<IEnumerable<ICandleStick>> GetAll(CancellationToken cancellationToken)
        {
            var command = CreateCommand();

            command.CommandText = $"SELECT * FROM CandleSticks";

            var queryResult = new List<ICandleStick>();
            using (var reader = await ExecuteReaderAsync(command, cancellationToken)){
                while(reader.Read()){
                    var candleStick = _candleStickManager.Create(
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

        public async Task<ICandleStick> GetById(int entityId, CancellationToken cancellationToken)
        {
            var command = CreateCommand();

            command.CommandText = $"SELECT * FROM CandleSticks WHERE Id = @Id";

            command.Parameters.Add(new SqlParameter("@Id", entityId));

            ICandleStick entity;
            using (var reader = await ExecuteReaderAsync(command, cancellationToken)){
                if (!reader.Read())
                    return default(CandleStick);

                var candleStick = _candleStickManager.Create(
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

        public async Task<IEnumerable<ICandleStick>> GetCandlesAfter(GetAfterCandleStickQuery query, CancellationToken cancellationToken)
        {
            var command = CreateCommand();

            command.CommandText = $"SELECT * FROM CandleSticks WHERE Date > @Date";

            command.Parameters.Add(new SqlParameter("@Date", query.Date));

            var queryResult = new List<ICandleStick>();
            using (var reader = await ExecuteReaderAsync(command, cancellationToken)){
                while(reader.Read()){
                    var candleStick = _candleStickManager.Create(
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

        public async Task<IEnumerable<ICandleStick>> GetCandlesAtOrAfter(GetAfterCandleStickQuery query, CancellationToken cancellationToken)
        {
            var command = CreateCommand();

            command.CommandText = $"SELECT * FROM CandleSticks WHERE Date >= @Date";

            command.Parameters.Add(new SqlParameter("@Date", query.Date));

            var queryResult = new List<ICandleStick>();
            using (var reader = await ExecuteReaderAsync(command, cancellationToken)){
                while(reader.Read()){
                    var candleStick = _candleStickManager.Create(
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

        public async Task Update(ICandleStick entity, CancellationToken cancellationToken)
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
