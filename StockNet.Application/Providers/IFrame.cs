using System.Collections.Generic;
using StockNet.Core.Interfaces;

namespace StockNet.Application.Providers
{
    public interface IFrame
    {
        void Add(ICandleStick candleStick);
        void AddRange(IEnumerable<ICandleStick> candleSticks);
        ICandleStick GetByIndex(int i);
        ICandleStick GetByIndexReverse(int i);
        IEnumerable<ICandleStick> GetAll();
    }
}
