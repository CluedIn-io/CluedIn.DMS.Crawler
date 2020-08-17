using Castle.Windsor;
using CluedIn.Core;
using CluedIn.Core.Providers;
using CluedIn.Crawling.DMS.Infrastructure.Factories;
using Moq;

namespace CluedIn.Provider.DMS.Unit.Test.DMSProvider
{
    public abstract class DMSProviderTest
    {
        protected readonly ProviderBase Sut;

        protected Mock<IDMSClientFactory> NameClientFactory;
        protected Mock<IWindsorContainer> Container;

        protected DMSProviderTest()
        {
            Container = new Mock<IWindsorContainer>();
            NameClientFactory = new Mock<IDMSClientFactory>();
            var applicationContext = new ApplicationContext(Container.Object);
            Sut = new DMS.DMSProvider(applicationContext, NameClientFactory.Object);
        }
    }
}
