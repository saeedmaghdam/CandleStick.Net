namespace StockNet.Core.Exceptions.CandleSticks
{
    public class CandleStickCloseLowerThanLowException : CandleStickInvalidException
    {
        public CandleStickCloseLowerThanLowException() : base("Candle-Stick's close value could not be lower than it's low value.")
        {
        }
    }
}
