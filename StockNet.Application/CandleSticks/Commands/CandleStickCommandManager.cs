using StockNet.Application.CandleSticks.Commands.Create;
using StockNet.Application.Common.Interfaces;
using StockNet.Core.Interfaces;

namespace StockNet.Application.CandleSticks.Commands
{
    public class CandleStickCommandManager
    {
        private readonly ICandleStickRepository _repository;
        private readonly ICandleStick _candleStick;

        public CandleStickCommandManager(ICandleStickRepository repository, ICandleStick candleStick)
        {
            this._repository = repository;
            this._candleStick = candleStick;
        }

        public CreateCandleStickCommandHandler CreateCandleStickCommandHandler() => new CreateCandleStickCommandHandler(_repository);
    }
}
