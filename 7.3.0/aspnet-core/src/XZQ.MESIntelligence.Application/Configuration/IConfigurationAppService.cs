using System.Threading.Tasks;
using XZQ.MESIntelligence.Configuration.Dto;

namespace XZQ.MESIntelligence.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
