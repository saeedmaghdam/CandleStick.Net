using System;
using System.Threading;
using System.Threading.Tasks;
using StockNet.Core.Entities;

namespace StockNet.Application.Common.Interfaces
{
    public interface IInstrumentRepository : IQueryRepository<Instrument>
    {
        
    }
}
