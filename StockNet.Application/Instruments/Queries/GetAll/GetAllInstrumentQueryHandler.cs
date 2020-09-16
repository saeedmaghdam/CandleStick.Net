using System;
using System.Threading;
using System.Threading.Tasks;
using StockNet.Application.Common.Interfaces;

namespace StockNet.Application.Instruments.Queries.GetAll
{
    public class GetAllInstrumentQueryHandler : IQueryHandler<GetAllInstrumentQuery, GetAllInstrumentQueryResult>
    {
        IInstrumentRepository _repository;

        public GetAllInstrumentQueryHandler(IInstrumentRepository repository){
            _repository = repository;
        }

        public async Task<GetAllInstrumentQueryResult> Handle(GetAllInstrumentQuery query, CancellationToken cancellationToken)
        {
            var result = GetAllInstrumentQueryResult.Create();

            result.Instruments =  await _repository.GetAll(cancellationToken);

            return result;
        }
    }
}
