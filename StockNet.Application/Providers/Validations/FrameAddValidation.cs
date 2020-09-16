using StockNet.Application.Providers.Exceptions;
using StockNet.Application.Common.Interfaces;
using StockNet.Core.Entities;

namespace StockNet.Application.Providers.Validations
{
    public class FrameAddValidation : IValidation
    {
        private readonly IFrame _frame;
        private readonly CandleStick _candleStick;

        public FrameAddValidation(IFrame frame, CandleStick candleStick){
            _frame = frame;
            _candleStick = candleStick;
        }

        public void Validate()
        {
            if (_candleStick.Date > _frame.GetByIndexReverse(0).Date)
                throw new CandleStickCannotInsertBeforeLastCandleStickInFrame();
        }
    }
}
