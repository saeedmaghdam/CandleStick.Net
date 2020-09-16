using Autofac;
using StockNet.Application.CandleSticks;

namespace StockNet.IoC
{
    public class ApplicationModule : IAutofacModule
    {
        public void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CandleStickManager>().As<ICandleStickManager>();
        }
    }
}