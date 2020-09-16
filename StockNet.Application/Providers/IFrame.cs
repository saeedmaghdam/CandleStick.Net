using System.Collections.Generic;
using StockNet.Core.Entities;

namespace StockNet.Application.Providers
{
    public interface IFrame
    {
        void Add(CandleStick candleStick);
        void AddRange(IEnumerable<CandleStick> candleSticks);
        CandleStick GetByIndex(int i);
        CandleStick GetByIndexReverse(int i);
        IEnumerable<CandleStick> GetAll();
    }
}
