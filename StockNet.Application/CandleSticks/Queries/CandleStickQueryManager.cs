using System;
using StockNet.Application.CandleSticks.Queries.GetAfter;
using StockNet.Application.Common.Interfaces;

namespace StockNet.Application.CandleSticks.Queries
{
    public class CandleStickQueryManager
    {
        private readonly ICandleStickRepository _repository;

        public CandleStickQueryManager(ICandleStickRepository repository)
        {
            this._repository = repository;
        }

        public GetAfterCandleStickQuery GetAfterCandleStickQueryInstance(DateTime date) => new GetAfterCandleStickQuery();

        public GetAfterCandleStickQueryHandler GetAfterCandleStickQueryHandler() => new GetAfterCandleStickQueryHandler(_repository);
    }
}
