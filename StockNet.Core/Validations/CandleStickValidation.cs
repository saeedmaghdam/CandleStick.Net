using StockNet.Core.Abstracts;
using StockNet.Core.Exceptions.CandleSticks;

namespace StockNet.Core.Validations
{
    public class CandleStickValidation : Validation
    {
        private readonly long _high;
        private readonly long _open;
        private readonly long _close;
        private readonly long _low;

        public CandleStickValidation(long high, long open, long close, long low){
            _high = high;
            _open = open;
            _close = close;
            _low = low;
        }

        public override void Validate(){
            if (_open > _high)
                Exceptions.Add(new CandleStickOpenGreaterThanHighException());
            if (_open < _low)
                Exceptions.Add(new CandleStickOpenLowerThanLowException());
            if (_close > _high)
                Exceptions.Add(new CandleStickCloseGreaterThanHighException());
            if (_close < _low)
                Exceptions.Add(new CandleStickCloseLowerThanLowException());
            if (_high < _low)
                Exceptions.Add(new CandleStickHighLowerThanLowException());
            if (_high <= 0)
                Exceptions.Add(new CandleStickHighInvalid());
            if (_open <= 0)
                Exceptions.Add(new CandleStickOpenInvalid());
            if (_close <= 0)
                Exceptions.Add(new CandleStickCloseInvalid());
            if (_low <= 0)
                Exceptions.Add(new CandleStickLowInvalid());

            base.Validate();
        }
    }
}
