using Autofac;

namespace StockNet.IoC
{
    public interface IAutofacModule
    {
        void Load(ContainerBuilder builder);
    }
}
