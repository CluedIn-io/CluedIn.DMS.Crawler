using CluedIn.Crawling.DMS.Core;

namespace CluedIn.Crawling.DMS.Infrastructure.Factories
{
    public interface IDMSClientFactory
    {
        DMSClient CreateNew(DMSCrawlJobData dmsCrawlJobData);
    }
}
