namespace StockNet.Core.Exceptions.CandleSticks
{
    public class CandleStickCloseGreaterThanHighException : CandleStickInvalidException
    {
        public CandleStickCloseGreaterThanHighException() : base("Candle-Stick's close value could not be greater than it's high value.")
        {
        }
    }
}
