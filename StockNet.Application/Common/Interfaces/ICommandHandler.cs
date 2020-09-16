using System.Threading;
using System.Threading.Tasks;

namespace StockNet.Application.Common.Interfaces
{
    public interface ICommandHandler<TCommand> where TCommand : class
    {
        Task Handle(TCommand command, CancellationToken cancellationToken);

        TCommand CreateCommand();
    }
}
