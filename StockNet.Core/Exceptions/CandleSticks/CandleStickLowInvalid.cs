namespace StockNet.Core.Exceptions.CandleSticks
{
    public class CandleStickLowInvalid : CandleStickInvalidException
    {
        public CandleStickLowInvalid() : base("Candle-Stick's low value should be a positive number.")
        {
        }
    }
}
