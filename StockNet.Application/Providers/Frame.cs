using System.Collections;
using System.Collections.Generic;
using System.Linq;
using StockNet.Application.Common;
using StockNet.Core.Entities;
using StockNet.Core.Interfaces;

namespace StockNet.Application.Providers
{
    public class Frame : IFrame
    {
        private readonly List<ICandleStick> _candleSticks;
        private int _count;

        public Frame(){
            _candleSticks = new List<ICandleStick>();
            _count = 0;
        }

        public void Add(ICandleStick candleStick)
        {
            new Validations.FrameAddValidation(this, candleStick).Validate();

            _candleSticks.Add(candleStick);
            _count++;
        }

        public void AddRange(IEnumerable<ICandleStick> candleSticks)
        {
            candleSticks.ToList().Sort(new CandleStickComparer());

            new Validations.FrameAddRangeValidation(this, candleSticks).Validate();

            _candleSticks.AddRange(candleSticks);
            _count += candleSticks.Count();
        }

        public IEnumerable<ICandleStick> GetAll()
        {
            return _candleSticks.AsEnumerable();
        }

        public ICandleStick GetByIndex(int i)
        {
            if (i < _count)
                return _candleSticks[i];
            
            return null;
        }

        public ICandleStick GetByIndexReverse(int i)
        {
            if (i < _count)
                return _candleSticks[_count - i - 1];

            return null;
        }
    }
}
