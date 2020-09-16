using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using StockNet.Core.Abstracts;

namespace StockNet.Application.Common.Interfaces
{
    public interface IQueryRepository<TEntity>: IRepository<TEntity> 
        where TEntity : Entity
    {
        Task<IEnumerable<TEntity>> GetAll(CancellationToken cancellationToken);
        Task<TEntity> GetById(int entityId, CancellationToken cancellationToken);
    }
}