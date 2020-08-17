using System.Collections.Generic;
using CluedIn.Crawling.DMS.Core;

namespace CluedIn.Crawling.DMS.Integration.Test
{
  public static class DMSConfiguration
  {
    public static Dictionary<string, object> Create()
    {
      return new Dictionary<string, object>
            {
                { DMSConstants.KeyName.ApiKey, "demo" }
            };
    }
  }
}
