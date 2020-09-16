namespace StockNet.Core.Exceptions.MarketInfo
{
    public class MarketInfoPreviousLastPriceInvalidException : MarketInfoInvalidException
    {
        public MarketInfoPreviousLastPriceInvalidException()
            :base("Market info's previous last price should be a positive number")
        {

        }
    }
}
