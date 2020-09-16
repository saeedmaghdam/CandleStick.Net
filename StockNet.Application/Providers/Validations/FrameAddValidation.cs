using StockNet.Application.Providers.Exceptions;
using StockNet.Core.Interfaces;

namespace StockNet.Application.Providers.Validations
{
    public class FrameAddValidation : Common.Interfaces.IValidation
    {
        private readonly IFrame _frame;
        private readonly ICandleStick _candleStick;

        public FrameAddValidation(IFrame frame, ICandleStick candleStick){
            this._frame = frame;
            this._candleStick = candleStick;
        }

        public void Validate()
        {
            if (_candleStick.Date > _frame.GetByIndexReverse(0).Date)
                throw new CandleStickCannotInsertBeforeLastCandleStickInFrame();
        }
    }
}
