namespace StockNet.Core.Exceptions.CandleSticks
{
    public class CandleStickCloseInvalid : CandleStickInvalidException
    {
        public CandleStickCloseInvalid() : base("Candle-Stick's close value should be a positive number.")
        {
        }
    }
}
