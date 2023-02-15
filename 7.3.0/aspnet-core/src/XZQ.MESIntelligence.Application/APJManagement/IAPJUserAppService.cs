using Abp.Application.Services;
using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XZQ.MESIntelligence.APJManagement.Dto;
using XZQ.MESIntelligence.Department;

namespace XZQ.MESIntelligence.APJManagement
{
    public class APJUserAppService : AsyncCrudAppService<DepartmentMessage, APJUserDto, int, PagedAPJUserResultRequestDto, CreateAPJUserDto, APJUserDto>, IAPJUserAppService
    {
        private IRepository<DepartmentMessage, int> _repository;

        public APJUserAppService(IRepository<DepartmentMessage, int> repository) : base(repository)
        {
            _repository = repository;
        }
        protected override void MapToEntity(APJUserDto updateInput, DepartmentMessage entity)
        {
            entity.DepartmentName           =   updateInput.DepartmentName;
            entity.DepartmentCode           =   updateInput.DepartmentCode;
            entity.PrincipalCode            =   updateInput.PrincipalCode;
            entity.PrincipalName            =   updateInput.PrincipalName;
            entity.SuperiorDepartmentCode   =   updateInput.SuperiorDepartmentCode;
            entity.SuperiorDepartmentName   =   updateInput.SuperiorDepartmentName;
            entity.ProductionWorkshop       =   updateInput.ProductionWorkshop;
            entity.Production               =   updateInput.Production;
            entity.OrganizationName         =   updateInput.OrganizationName;
            entity.DataBool                 =   updateInput.DataBool;
        }
    }
}
