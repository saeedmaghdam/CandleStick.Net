namespace StockNet.Core.Exceptions.MarketInfo
{
    public class MarketInfoLastPriceInvalidException : MarketInfoInvalidException
    {
        public MarketInfoLastPriceInvalidException()
            :base("Market info's last price should be a positive number")
        {

        }
    }
}
