using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using StockNet.Application.CandleSticks.Queries.GetAfter;
using StockNet.Core.Entities;

namespace StockNet.Application.Common.Interfaces
{
    public interface ICandleStickRepository : ICommandRepository<CandleStick>, IQueryRepository<CandleStick>
    {
        Task<IEnumerable<CandleStick>> GetCandlesAtOrAfter(GetAfterCandleStickQuery query, CancellationToken cancellationToken);
        Task<IEnumerable<CandleStick>> GetCandlesAfter(GetAfterCandleStickQuery query, CancellationToken cancellationToken);
    }
}
