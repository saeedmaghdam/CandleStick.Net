using System;
using StockNet.Application.CandleSticks.Commands;
using StockNet.Application.CandleSticks.Queries;
using StockNet.Application.Common.Interfaces;
using StockNet.Core.Interfaces;

namespace StockNet.Application.CandleSticks
{
    public interface ICandleStickManager : IManager<ICandleStick>
    {
        ICandleStick Create(long high, long open, long close, long low, long volume, DateTime date);

        CandleStickCommandManager Commands
        {
            get;
        }

        CandleStickQueryManager Queries
        {
            get;
        }
    }
}
