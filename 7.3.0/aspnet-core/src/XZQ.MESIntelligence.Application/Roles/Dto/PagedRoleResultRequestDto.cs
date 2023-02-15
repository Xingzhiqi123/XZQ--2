using Abp.Application.Services.Dto;

namespace XZQ.MESIntelligence.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

