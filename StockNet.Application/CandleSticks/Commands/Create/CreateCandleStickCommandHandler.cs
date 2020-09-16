using System.Threading;
using System.Threading.Tasks;
using StockNet.Application.Common.Interfaces;
using StockNet.Core.Interfaces;

namespace StockNet.Application.CandleSticks.Commands.Create
{
    public class CreateCandleStickCommandHandler : ICommandHandler<CreateCandleStickCommand>
    {
        private readonly ICandleStickRepository _repository;

        public CreateCandleStickCommandHandler(ICandleStickRepository repository)
        {
            this._repository = repository;
        }

        public async Task Handle(CreateCandleStickCommand request, CancellationToken cancellationToken)
        {
            await _repository.Add(request.CandleStick, cancellationToken);
        }

        public CreateCandleStickCommand CreateCommand()
        {
            return new CreateCandleStickCommand();
        }
    }
}
