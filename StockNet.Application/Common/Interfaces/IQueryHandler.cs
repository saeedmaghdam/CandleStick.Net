using System.Threading;
using System.Threading.Tasks;

namespace StockNet.Application.Common.Interfaces
{
    public interface IQueryHandler<TQuery, TQueryResult> 
        where TQuery: IQueryObject
        where TQueryResult : IQueryResult
    {
        Task<TQueryResult> Handle(TQuery query, CancellationToken cancellationToken);
    }
}
