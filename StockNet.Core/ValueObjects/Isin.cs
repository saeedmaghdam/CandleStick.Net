using StockNet.Core.Validations;

namespace StockNet.Core.ValueObjects
{
    public class Isin
    {
        private readonly string _countryCode;
        private readonly string _securityIdentifier;
        private readonly string _checkDigit;

        public Isin(string isin){
            new IsinValidation(isin).Validate();

            _countryCode = isin.Substring(0, 2);
            _securityIdentifier = isin.Substring(2, 9);
            _checkDigit = isin.Substring(11, 2);
        }

        public string CountryCode => _countryCode;
        public string SecurityIdentifier => _securityIdentifier;
        public string CheckDigit => _checkDigit;

        public override string ToString()
        {
            return $"{_countryCode}{_securityIdentifier}{_checkDigit}";
        }
    }
}
