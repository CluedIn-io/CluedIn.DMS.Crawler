using CluedIn.Crawling.DMS.Core;

namespace CluedIn.Crawling.DMS
{
    public class DMSCrawlerJobProcessor : GenericCrawlerTemplateJobProcessor<DMSCrawlJobData>
    {
        public DMSCrawlerJobProcessor(DMSCrawlerComponent component) : base(component)
        {
        }
    }
}
