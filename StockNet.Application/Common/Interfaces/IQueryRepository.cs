using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using StockNet.Core.Interfaces;

namespace StockNet.Application.Common.Interfaces
{
    public interface IQueryRepository<TEntity>: IRepository<TEntity> 
        where TEntity : IEntity
    {
        Task<IEnumerable<TEntity>> GetAll(CancellationToken cancellationToken);
        Task<TEntity> GetById(int entityId, CancellationToken cancellationToken);
    }
}