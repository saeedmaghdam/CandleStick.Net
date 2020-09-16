using System;
using StockNet.Application.Common.Interfaces;
using StockNet.Core.Entities;

namespace StockNet.Application.Providers
{
    public interface IFrameProvider : IProvider
    {
        IFrame CreateFrame();
        IFrame CreateFrameFrom(Instrument instrument, DateTime startDate);
        IFrame CreateFrameTo(Instrument instrument, DateTime endDate);
        IFrame CreateFrame(Instrument instrument, DateTime startDate, DateTime endDate);
    }
}
