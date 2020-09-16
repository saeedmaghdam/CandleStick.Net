using StockNet.Core.Interfaces;

namespace StockNet.Application.Common.Interfaces
{
    public interface IRepository<TEntity>
        where TEntity : IEntity
    {
    }
}
