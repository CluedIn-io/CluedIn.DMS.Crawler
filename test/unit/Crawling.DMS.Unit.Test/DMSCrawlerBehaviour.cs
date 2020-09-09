using CluedIn.Core.Crawling;
using CluedIn.Crawling;
using CluedIn.Crawling.DMS;
using CluedIn.Crawling.DMS.Infrastructure.Factories;
using Moq;
using Shouldly;
using Xunit;

namespace Crawling.DMS.Unit.Test
{
    public class DMSCrawlerBehaviour
    {
        private readonly ICrawlerDataGenerator _sut;

        public DMSCrawlerBehaviour()
        {
            var nameClientFactory = new Mock<IDMSClientFactory>();

            _sut = new DMSCrawler(nameClientFactory.Object);
        }

        [Fact]
        public void GetDataReturnsData()
        {
            var jobData = new CrawlJobData();

            _sut.GetData(jobData)
                .ShouldNotBeNull();
        }
    }
}
