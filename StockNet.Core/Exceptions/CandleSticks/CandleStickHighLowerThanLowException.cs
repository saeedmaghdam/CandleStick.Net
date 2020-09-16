namespace StockNet.Core.Exceptions.CandleSticks
{
    public class CandleStickHighLowerThanLowException : CandleStickInvalidException
    {
        public CandleStickHighLowerThanLowException() : base("Candle-Stick's high value could not be lower than it's low value.")
        {
        }
    }
}
