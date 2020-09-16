using System.Collections.Generic;
using StockNet.Core.Interfaces;

namespace StockNet.Application.Common
{
    public class CandleStickComparer: IComparer<ICandleStick>
    {
        public int Compare(ICandleStick x, ICandleStick y)
        {
            return x.Date.CompareTo(y.Date);
        }
    }
}
