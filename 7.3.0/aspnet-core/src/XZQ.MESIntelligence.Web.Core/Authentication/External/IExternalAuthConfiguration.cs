using System.Collections.Generic;

namespace XZQ.MESIntelligence.Authentication.External
{
    public interface IExternalAuthConfiguration
    {
        List<ExternalLoginProviderInfo> Providers { get; }
    }
}
