using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using XZQ.MESIntelligence.Configuration.Dto;

namespace XZQ.MESIntelligence.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : MESIntelligenceAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
