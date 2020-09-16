using System;
using System.Diagnostics;
using StockNet.Core.Abstracts;
using StockNet.Core.Validations;

namespace StockNet.Core.Entities
{
    [DebuggerDisplay ("{DebuggerDisplay}")]
    public class MarketInfo : Entity
    {
        private readonly long _previousLastPrice;
        private readonly long _lastPrice;
        private long _maxPrice;
        private long _minPrice;
        private long _nextMaxPrice;
        private long _nextMinPrice;
        private readonly DateTime _date;

        public string DebuggerDisplay => $"Time: {_date}, MaxPrice: {_maxPrice}, MinPrice: {_minPrice}, NextMinPrice: {_nextMinPrice}, NextMaxPrice: {_nextMaxPrice}";
        
        public long PreviousLastPrice => _previousLastPrice;

        public long LastPrice => _lastPrice;

        public long MinPrice => _minPrice;

        public long MaxPrice => _maxPrice;

        public long NextMinPrice => _nextMinPrice;

        public long NextMaxPrice => _nextMaxPrice;

        public DateTime Date=> _date;

        public MarketInfo(long previousLastPrice, long lastPrice, DateTime date){
            _date = date;
            
            new MarketInfoValidation(previousLastPrice, lastPrice).Validate();

            _previousLastPrice = previousLastPrice;
            _lastPrice = lastPrice;

            CalculateMinMaxPrices();
        }

        private void CalculateMinMaxPrices(){
            _minPrice = _previousLastPrice - (long)(_previousLastPrice * 0.05);
            _maxPrice = _previousLastPrice + (long)(_previousLastPrice * 0.05);

            _nextMinPrice = _lastPrice - (long)(_lastPrice * 0.05);
            _nextMaxPrice = _lastPrice + (long)(_lastPrice * 0.05);
        }
    }
}
