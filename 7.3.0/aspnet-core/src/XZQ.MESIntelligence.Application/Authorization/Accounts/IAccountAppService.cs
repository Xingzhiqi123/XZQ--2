using System.Threading.Tasks;
using Abp.Application.Services;
using XZQ.MESIntelligence.Authorization.Accounts.Dto;

namespace XZQ.MESIntelligence.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
