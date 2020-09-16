using System.Threading;
using System.Threading.Tasks;
using StockNet.Core.Interfaces;

namespace StockNet.Application.Common.Interfaces
{
    public interface ICommandRepository<TEntity>: IRepository<TEntity> 
        where TEntity : IEntity
    {
        Task Add(TEntity entity, CancellationToken cancellationToken);
        Task Update(TEntity entity, CancellationToken cancellationToken);
        Task Delete(int entityId, CancellationToken cancellationToken);
    }
}
