using Abp.Application.Services;
using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XZQ.MESIntelligence.APJManagement.Dto;
using XZQ.MESIntelligence.APJManagement;
using XZQ.MESIntelligence.Department;
using XZQ.MESIntelligence.APJTeamOrGroup.Dto;
using CreateAPJUserDtos = XZQ.MESIntelligence.APJTeamOrGroup.Dto.CreateAPJUserDtos;

namespace XZQ.MESIntelligence.APJTeamOrGroup
{
    public class APJUserAppServices : AsyncCrudAppService<Teamorgroup, APJUserDtos, int, PagedAPJUserResultRequestDtos, CreateAPJUserDtos, APJUserDtos>, IAPJUserAppServices
    {
        private IRepository<Teamorgroup, int> _repository;

        public APJUserAppServices(IRepository<Teamorgroup, int> repository) : base(repository)
        {
            _repository = repository;
        }

        protected override void MapToEntity(APJUserDtos updateInput, Teamorgroup entity)
        {
            entity.TeamorgroupCode           =   updateInput.TeamorgroupCode;
            entity.TeamorgroupName           =   updateInput.TeamorgroupName;
            entity.TeamorgroupGrouping            =   updateInput.TeamorgroupGrouping;
            entity.Organization            =   updateInput.Organization;
            entity.TeamorgroupRemark   =   updateInput.TeamorgroupRemark;
            entity.Linenumbers   =   updateInput.Linenumbers;
            entity.StaffroupCode       =   updateInput.StaffroupCode;
            entity.StaffName               =   updateInput.StaffName;
            entity.StaffBit         =   updateInput.StaffBit;
            entity.Remark                 =   updateInput.Remark;
            entity.Preparedby                 =   updateInput.Preparedby;
            entity.UpdateDate                 =   updateInput.UpdateDate;
            entity.Auditor                 =   updateInput.Auditor;
            entity.JinDate                 =   updateInput.JinDate;
        }
    }
}
