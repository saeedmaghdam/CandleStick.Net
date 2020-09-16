using System.Collections.Generic;
using StockNet.Application.Common.Interfaces;
using StockNet.Core.Interfaces;

namespace StockNet.Application.CandleSticks.Queries.GetAfter
{
    public class GetAfterCandleStickQueryResult : IQueryResult
    {
        public IEnumerable<ICandleStick> CandleSticks {get;set;}

        public GetAfterCandleStickQueryResult(){
            CandleSticks = new List<ICandleStick>();
        }
    }
}
