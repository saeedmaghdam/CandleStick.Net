using System;
using StockNet.Application.Common.Interfaces;

namespace StockNet.Application.CandleSticks.Queries.GetAfter
{
    public class GetAfterCandleStickQuery : IQueryObject
    {
        private readonly DateTime _date;

        public DateTime Date => _date;

        public GetAfterCandleStickQuery(DateTime date){
            _date = date;
        }

        public static GetAfterCandleStickQuery Create(DateTime date){
            return new GetAfterCandleStickQuery(date);
        }
    }
}
