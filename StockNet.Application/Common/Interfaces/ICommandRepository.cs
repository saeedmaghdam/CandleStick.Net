using System.Threading;
using System.Threading.Tasks;
using StockNet.Core.Abstracts;

namespace StockNet.Application.Common.Interfaces
{
    public interface ICommandRepository<TEntity>: IRepository<TEntity> 
        where TEntity : Entity
    {
        Task Add(TEntity entity, CancellationToken cancellationToken);
        Task Update(TEntity entity, CancellationToken cancellationToken);
        Task Delete(int entityId, CancellationToken cancellationToken);
    }
}
