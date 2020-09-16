using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using StockNet.Application.CandleSticks.Queries.GetAfter;
using StockNet.Core.Interfaces;

namespace StockNet.Application.Common.Interfaces
{
    public interface ICandleStickRepository : ICommandRepository<ICandleStick>, IQueryRepository<ICandleStick>
    {
        Task<IEnumerable<ICandleStick>> GetCandlesAtOrAfter(GetAfterCandleStickQuery query, CancellationToken cancellationToken);
        Task<IEnumerable<ICandleStick>> GetCandlesAfter(GetAfterCandleStickQuery query, CancellationToken cancellationToken);
    }
}
