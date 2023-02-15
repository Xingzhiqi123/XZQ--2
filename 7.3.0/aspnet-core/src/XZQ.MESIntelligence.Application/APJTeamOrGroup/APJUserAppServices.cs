using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XZQ.MESIntelligence.APJManagement.Dto;
using XZQ.MESIntelligence.APJTeamOrGroup.Dto;

namespace XZQ.MESIntelligence.APJTeamOrGroup
{
    public interface IAPJUserAppServices : IAsyncCrudAppService<APJUserDtos, int, PagedAPJUserResultRequestDtos, CreateAPJUserDtos, APJUserDtos>
    {
    }
}
