namespace StockNet.Core.Exceptions.CandleSticks
{
    public class CandleStickOpenLowerThanLowException : CandleStickInvalidException
    {
        public CandleStickOpenLowerThanLowException() : base("Candle-Stick's open value could not be lower than it's low value.")
        {
        }
    }
}
