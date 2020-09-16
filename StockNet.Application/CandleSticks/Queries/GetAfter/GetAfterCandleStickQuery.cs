using System;
using StockNet.Application.Common.Interfaces;

namespace StockNet.Application.CandleSticks.Queries.GetAfter
{
    public class GetAfterCandleStickQuery : IQueryObject
    {
        public DateTime Date
        {
            get;
            set;
        }
    }
}
