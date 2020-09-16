using System;
using StockNet.Application.Common.Abstracts;

namespace StockNet.Application.CandleSticks.Commands.Create
{
    public class CreateCandleStickCommand : CandleStickCommand
    {
        public CreateCandleStickCommand(long high, long open, long close, long low, long volume, DateTime date): base(high, open, close, low, volume, date) {}

        public static CreateCandleStickCommand Create(long high, long open, long close, long low, long volume, DateTime date){
            return new CreateCandleStickCommand(high, open, close, low, volume, date);
        }
    }
}
