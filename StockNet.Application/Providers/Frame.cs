using System.Collections;
using System.Collections.Generic;
using System.Linq;
using StockNet.Application.Common;
using StockNet.Core.Entities;

namespace StockNet.Application.Providers
{
    public class Frame : IFrame
    {
        private readonly List<CandleStick> _candleSticks;
        private CandleStick _lastCandleStick;
        private int _count;

        public Frame(){
            _candleSticks = new List<CandleStick>();
            _count = 0;
        }

        public void Add(CandleStick candleStick)
        {
            new Validations.FrameAddValidation(this, candleStick).Validate();

            _candleSticks.Add(candleStick);
            _lastCandleStick = candleStick;
            _count++;
        }

        public void AddRange(IEnumerable<CandleStick> candleSticks)
        {
            candleSticks.ToList().Sort(new CandleStickComparer());

            new Validations.FrameAddRangeValidation(this, candleSticks).Validate();

            _candleSticks.AddRange(candleSticks);
            _lastCandleStick = candleSticks.Last();
            _count += candleSticks.Count();
        }

        public IEnumerable<CandleStick> GetAll()
        {
            return _candleSticks.AsEnumerable();
        }

        public CandleStick GetByIndex(int i)
        {
            if (i < _count)
                return _candleSticks[i];
            
            return null;
        }

        public CandleStick GetByIndexReverse(int i)
        {
            if (i < _count)
                return _candleSticks[_count - i - 1];

            return null;
        }
    }
}
