using System;
using System.Threading;
using Autofac;
using NUnit.Framework;
using StockNet.Application.CandleSticks;
using StockNet.Core.Interfaces;

namespace StockNet.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var builder = new ContainerBuilder();
            new IoC.ApplicationModule().Load(builder);
            var container = builder.Build();

            var candleStickManager = container.Resolve<ICandleStickManager>();

            var command = candleStickManager.Commands.CreateCandleStickCommandHandler().CreateCommand();
            command.CandleStick = candleStickManager.Create(1, 2, 3, 4, 5, DateTime.Today);
            candleStickManager.Commands.CreateCandleStickCommandHandler().Handle(command, CancellationToken.None).Wait();

            Assert.Pass();
        }
    }
}