using System;

namespace StockNet.Core.Exceptions.Instruments
{
    public class InstrumentInvalidException : Exception
    {
        public InstrumentInvalidException() :
            base ("Instrument is not valid and it should have 12 characters.")
        {

        }
    }
}
