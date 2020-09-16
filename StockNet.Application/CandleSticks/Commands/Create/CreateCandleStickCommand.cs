using StockNet.Core.Entities;
using StockNet.Core.Interfaces;

namespace StockNet.Application.CandleSticks.Commands.Create
{
    public class CreateCandleStickCommand
    {
        public ICandleStick CandleStick
        {
            get;
            set;
        }
    }
}
