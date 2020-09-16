using System;

namespace StockNet.Core.Interfaces
{
    public interface ICandleStick : IEntity, IComparable<ICandleStick>
    {
        long High
        {
            get;
        }
        long Open
        {
            get;
        }
        long Close
        {
            get;
        }
        long Low
        {
            get;
        }
        long Volume
        {
            get;
        }
        DateTime Date
        {
            get;
        }
    }
}
