using StockNet.Core.Interfaces;

namespace StockNet.Application.Common.Interfaces
{
    public interface IManager<TEntity> 
        where TEntity : IEntity
    {
    }
}
