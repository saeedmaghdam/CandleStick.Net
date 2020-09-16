using System;

namespace StockNet.Application.Providers.Exceptions
{
    public class CandleStickCannotInsertBeforeLastCandleStickInFrame : Exception
    {
        public CandleStickCannotInsertBeforeLastCandleStickInFrame() : base("Candle stick cannot occur before another candle stick in a frame"){

        }
    }
}
