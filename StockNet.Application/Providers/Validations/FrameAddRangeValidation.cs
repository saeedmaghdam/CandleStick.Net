using System.Collections.Generic;
using System.Linq;
using StockNet.Application.Providers.Exceptions;
using StockNet.Core.Interfaces;

namespace StockNet.Application.Providers.Validations
{
    public class FrameAddRangeValidation : Common.Interfaces.IValidation
    {
        private readonly IFrame _frame;
        private readonly IEnumerable<ICandleStick> _candleSticks;

        public FrameAddRangeValidation(IFrame frame, IEnumerable<ICandleStick> candleSticks){
            this._frame = frame;
            this._candleSticks = candleSticks;
        }

        public void Validate()
        {
            if (_frame.GetByIndexReverse(0).CompareTo(_candleSticks.ToList().Last()) <= 0)
                throw new CandleStickCannotInsertBeforeLastCandleStickInFrame();
        }
    }
}
