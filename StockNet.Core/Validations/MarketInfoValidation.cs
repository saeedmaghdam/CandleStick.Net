using StockNet.Core.Exceptions.MarketInfo;
using StockNet.Core.Abstracts;

namespace StockNet.Core.Validations
{
    public class MarketInfoValidation : Validation
    {
        private readonly long _previousLastPrice;
        private readonly long _lastPrice;

        public MarketInfoValidation(long previousLastPrice, long lastPrice){
            _previousLastPrice = previousLastPrice;
            _lastPrice = lastPrice;
        }

        public override void Validate()
        {
            if (_previousLastPrice <= 0)
                Exceptions.Add(new MarketInfoPreviousLastPriceInvalidException());
            if (_lastPrice <= 0)
                Exceptions.Add(new MarketInfoLastPriceInvalidException());

            base.Validate();
        }
    }
}
