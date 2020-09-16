using System.Threading;
using System.Threading.Tasks;
using StockNet.Application.Common.Interfaces;
using StockNet.Core.Entities;

namespace StockNet.Application.CandleSticks.Commands.Create
{
    public class CreateCandleStickCommandHandler : ICommandHandler<CreateCandleStickCommand>
    {
        private readonly ICandleStickRepository _repository;

        public CreateCandleStickCommandHandler(ICandleStickRepository repository){
            _repository = repository;
        }

        public async Task Handle(CreateCandleStickCommand command, CancellationToken cancellationToken)
        {
            var candleStick = CandleStick.Create(command.High, command.Open, command.Close, command.Low, command.Volume, command.Date);

            await _repository.Add(candleStick, cancellationToken);
        }
    }
}
