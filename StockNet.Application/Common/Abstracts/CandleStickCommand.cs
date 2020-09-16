using System;
using StockNet.Application.Common.Interfaces;

namespace StockNet.Application.Common.Abstracts
{
    public abstract class CandleStickCommand : ICommandObject
    {
        private readonly long _high;
        private readonly long _open;
        private readonly long _close;
        private readonly long _low;
        private readonly long _volume;
        private readonly DateTime _date;

        public long High => _high;

        public long Open => _open;

        public long Close => _close;

        public long Low => _low;

        public long Volume => _volume;

        public DateTime Date => _date;

        public CandleStickCommand(long high, long open, long close, long low, long volume, DateTime date){
            _high = high;
            _open = open;
            _close = close;
            _low = low;
            _volume = volume;
            _date = date;
        }
    }
}
