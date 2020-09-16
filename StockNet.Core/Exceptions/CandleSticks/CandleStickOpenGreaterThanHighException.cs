namespace StockNet.Core.Exceptions.CandleSticks
{
    public class CandleStickOpenGreaterThanHighException : CandleStickInvalidException
    {
        public CandleStickOpenGreaterThanHighException() : base("Candle-Stick's open value could not be greater than it's high value.")
        {
        }
    }
}
