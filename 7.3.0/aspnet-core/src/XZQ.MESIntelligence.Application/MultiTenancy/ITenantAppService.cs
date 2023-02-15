using Abp.Application.Services;
using XZQ.MESIntelligence.MultiTenancy.Dto;

namespace XZQ.MESIntelligence.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

