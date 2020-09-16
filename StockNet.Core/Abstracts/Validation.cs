using System;
using System.Collections.Generic;
using StockNet.Core.Interfaces;

namespace StockNet.Core.Abstracts
{
    public abstract class Validation : IValidation
    {
        protected readonly List<Exception> Exceptions;

        public Validation(){
            this.Exceptions = new List<Exception>();
        }

        public virtual void Validate()
        {
            if (Exceptions.Count > 0)
                throw new AggregateException("There's an error in constructing candle stick, see exceptions for more information.", Exceptions);
        }
    }
}
