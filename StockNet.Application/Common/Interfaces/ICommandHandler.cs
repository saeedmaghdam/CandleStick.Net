using System.Threading;
using System.Threading.Tasks;

namespace StockNet.Application.Common.Interfaces
{
    public interface ICommandHandler<ICommand> where ICommand: ICommandObject
    {
        Task Handle(ICommand command, CancellationToken cancellationToken);
    }
}
