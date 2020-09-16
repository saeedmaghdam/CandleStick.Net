using System;
using StockNet.Application.Common.Interfaces;
using StockNet.Core.Entities;

namespace StockNet.Application.Providers
{
    public class FrameProvider : IFrameProvider
    {
        private readonly ICandleStickRepository _candleStickRepository;

        public FrameProvider(ICandleStickRepository candleStickRepository){
            this._candleStickRepository = candleStickRepository;
        }

        public IFrame CreateFrame()
        {
            return new Frame();
        }

        public IFrame CreateFrame(Instrument instrument, DateTime startDate, DateTime endDate)
        {
            var frame = new Frame();

            var candleSticks = _candleStickRepository.GetAll(new System.Threading.CancellationToken());

            frame.AddRange(candleSticks.Result);

            return frame;
        }

        public IFrame CreateFrameFrom(Instrument instrument, DateTime startDate)
        {
            throw new NotImplementedException();
        }

        public IFrame CreateFrameTo(Instrument instrument, DateTime endDate)
        {
            throw new NotImplementedException();
        }
    }
}
