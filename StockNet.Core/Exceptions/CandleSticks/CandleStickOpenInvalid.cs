namespace StockNet.Core.Exceptions.CandleSticks
{
    public class CandleStickOpenInvalid : CandleStickInvalidException
    {
        public CandleStickOpenInvalid() : base("Candle-Stick's open value should be a positive number.")
        {
        }
    }
}
