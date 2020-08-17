using System.Collections.Generic;

using CluedIn.Core.Crawling;
using CluedIn.Crawling.DMS.Core;
using CluedIn.Crawling.DMS.Infrastructure.Factories;

namespace CluedIn.Crawling.DMS
{
    public class DMSCrawler : ICrawlerDataGenerator
    {
        private readonly IDMSClientFactory clientFactory;
        public DMSCrawler(IDMSClientFactory clientFactory)
        {
            this.clientFactory = clientFactory;
        }

        public IEnumerable<object> GetData(CrawlJobData jobData)
        {
            if (!(jobData is DMSCrawlJobData dmscrawlJobData))
            {
                yield break;
            }

            var client = clientFactory.CreateNew(dmscrawlJobData);

            //retrieve data from provider and yield objects
            
        }       
    }
}
