using System;
using System.Diagnostics;
using StockNet.Core.Abstracts;
using StockNet.Core.Interfaces;
using StockNet.Core.Validations;

namespace StockNet.Core.Entities
{
    [DebuggerDisplay ("{DebuggerDisplay}")]
    public class CandleStick : Entity, ICandleStick
    {
        private readonly long _high;
        private readonly long _open;
        private readonly long _close;
        private readonly long _low;
        private readonly long _volume;
        private readonly DateTime _date;

        public string DebuggerDisplay => $"Time: {_date}, High: {_high}, Open: {_open}, Close: {_close}, Low: {_low}, Volume: {_volume}";

        public long High => _high;

        public long Open => _open;

        public long Close => _close;

        public long Low => _low;

        public long Volume => _volume;

        public DateTime Date => _date;

        public CandleStick(long high, long open, long close, long low, long volume, DateTime date) 
        {
            this._date = date;
            
            new CandleStickValidation(high, open, close, low).Validate();
            
            this._high = high;
            this._open = open;
            this._close = close;
            this._low = low;
            this._volume = volume;
        }

        public int CompareTo(ICandleStick candleStick)
        {
            return this._date.CompareTo(candleStick.Date);
        }
    }
}
