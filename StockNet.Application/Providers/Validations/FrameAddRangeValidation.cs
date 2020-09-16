using System.Collections.Generic;
using System.Linq;
using StockNet.Application.Common.Interfaces;
using StockNet.Application.Providers.Exceptions;
using StockNet.Core.Entities;

namespace StockNet.Application.Providers.Validations
{
    public class FrameAddRangeValidation : IValidation
    {
        private readonly IFrame _frame;
        private readonly IEnumerable<CandleStick> _candleSticks;

        public FrameAddRangeValidation(IFrame frame, IEnumerable<CandleStick> candleSticks){
            _frame = frame;
            _candleSticks = candleSticks;
        }

        public void Validate()
        {
            if (_frame.GetByIndexReverse(0).CompareTo(_candleSticks.ToList().Last()) <= 0)
                throw new CandleStickCannotInsertBeforeLastCandleStickInFrame();
        }
    }
}
