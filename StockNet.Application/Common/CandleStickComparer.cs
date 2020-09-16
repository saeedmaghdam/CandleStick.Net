using System.Collections.Generic;
using StockNet.Core.Entities;

namespace StockNet.Application.Common
{
    public class CandleStickComparer: IComparer<CandleStick>
    {
        public int Compare(CandleStick x, CandleStick y)
        {
            return x.Date.CompareTo(y.Date);
        }
    }
}
