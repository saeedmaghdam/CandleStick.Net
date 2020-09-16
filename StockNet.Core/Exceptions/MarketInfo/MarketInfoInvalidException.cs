using System;

namespace StockNet.Core.Exceptions.MarketInfo
{
    public class MarketInfoInvalidException: Exception
    {
        public MarketInfoInvalidException(string message)
            : base(message)
        {
        }
    }
}
