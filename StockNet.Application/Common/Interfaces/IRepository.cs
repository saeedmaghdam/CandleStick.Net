using StockNet.Core.Abstracts;

namespace StockNet.Application.Common.Interfaces
{
    public interface IRepository<TEntity>
        where TEntity : Entity
    {
    }
}
