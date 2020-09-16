using System;
using System.Collections.Generic;
using StockNet.Application.Common.Interfaces;
using StockNet.Core.Entities;

namespace StockNet.Application.Instruments.Queries.GetAll
{
    public class GetAllInstrumentQueryResult : IQueryResult
    {
        public IEnumerable<Instrument> Instruments {get;set;}

        public GetAllInstrumentQueryResult(){
            Instruments = new List<Instrument>();
        }

        public static GetAllInstrumentQueryResult Create(){
            return new GetAllInstrumentQueryResult();
        }
    }
}
