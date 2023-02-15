using System.Threading.Tasks;
using Abp.Application.Services;
using XZQ.MESIntelligence.Sessions.Dto;

namespace XZQ.MESIntelligence.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
