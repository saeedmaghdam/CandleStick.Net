namespace StockNet.Core.Exceptions.CandleSticks
{
    public class CandleStickHighInvalid : CandleStickInvalidException
    {
        public CandleStickHighInvalid() : base("Candle-Stick's high value should be a positive number.")
        {
        }
    }
}
