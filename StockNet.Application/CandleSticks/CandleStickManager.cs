using System;
using System.Net.Http.Headers;
using StockNet.Application.CandleSticks.Commands;
using StockNet.Application.CandleSticks.Queries;
using StockNet.Application.Common.Interfaces;
using StockNet.Core.Entities;
using StockNet.Core.Interfaces;

namespace StockNet.Application.CandleSticks
{
    public class CandleStickManager : ICandleStickManager
    {
        private readonly ICandleStickRepository _repository;
        private readonly ICandleStick _candleStick;

        public CandleStickManager(ICandleStickRepository repository, ICandleStick candleStick)
        {
            this._repository = repository;
            this._candleStick = candleStick;
        }

        public ICandleStick Create(long high, long open, long close, long low, long volume, DateTime date) => new CandleStick(high, open, close, low, volume, date);
        public CandleStickCommandManager Commands => new CandleStickCommandManager(_repository, _candleStick);
        public CandleStickQueryManager Queries => new CandleStickQueryManager(_repository);
    }
}
