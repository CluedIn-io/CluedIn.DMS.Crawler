using CluedIn.Core;
using CluedIn.Crawling.DMS.Core;

using ComponentHost;

namespace CluedIn.Crawling.DMS
{
    [Component(DMSConstants.CrawlerComponentName, "Crawlers", ComponentType.Service, Components.Server, Components.ContentExtractors, Isolation = ComponentIsolation.NotIsolated)]
    public class DMSCrawlerComponent : CrawlerComponentBase
    {
        public DMSCrawlerComponent([NotNull] ComponentInfo componentInfo)
            : base(componentInfo)
        {
        }
    }
}

