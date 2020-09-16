using System;
using System.Collections.Generic;
using StockNet.Application.Common.Abstracts;
using StockNet.Application.Common.Interfaces;
using StockNet.Core.Entities;

namespace StockNet.Application.CandleSticks.Queries.GetAfter
{
    public class GetAfterCandleStickQueryResult : IQueryResult
    {
        public IEnumerable<CandleStick> CandleSticks {get;set;}

        public GetAfterCandleStickQueryResult(){
            CandleSticks = new List<CandleStick>();
        }

        public static GetAfterCandleStickQueryResult Create(){
            return new GetAfterCandleStickQueryResult();
        }
    }
}
