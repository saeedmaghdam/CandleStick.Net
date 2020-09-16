using StockNet.Core.Abstracts;
using StockNet.Core.Exceptions.Instruments;

namespace StockNet.Core.Validations
{
    public class IsinValidation : Validation
    {
        private readonly string _isin;

        public IsinValidation(string isin){
            _isin = isin;
        }

        public override void Validate()
        {
            if (_isin.Length != 12)
                Exceptions.Add(new InstrumentInvalidException());

            base.Validate();
        }
    }
}
