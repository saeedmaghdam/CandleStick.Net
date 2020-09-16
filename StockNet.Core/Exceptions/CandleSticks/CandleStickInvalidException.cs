using System;

namespace StockNet.Core.Exceptions.CandleSticks {
    public class CandleStickInvalidException: Exception {
        public CandleStickInvalidException(string message)
            : base(message)
        {
        }
    }
}