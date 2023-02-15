using Abp.AutoMapper;
using XZQ.MESIntelligence.Authentication.External;

namespace XZQ.MESIntelligence.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
