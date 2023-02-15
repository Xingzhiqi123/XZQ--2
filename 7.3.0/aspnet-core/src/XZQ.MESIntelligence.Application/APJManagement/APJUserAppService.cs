using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XZQ.MESIntelligence.APJManagement.Dto;

namespace XZQ.MESIntelligence.APJManagement
{
    public interface IAPJUserAppService : IAsyncCrudAppService<APJUserDto, int, PagedAPJUserResultRequestDto, CreateAPJUserDto, APJUserDto>
    {
    }
}
