using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XZQ.MESIntelligence.Department;

namespace XZQ.MESIntelligence.APJManagement.Dto
{
    [AutoMapTo(typeof(DepartmentMessage))]
    public class CreateAPJUserDto
    {
        public string DepartmentCode { get; set; }//部门代码
        public string DepartmentName { get; set; }//部门名称
        public string PrincipalCode { get; set; }//负责人代码
        public string PrincipalName { get; set; }//负责人名称
        public string SuperiorDepartmentCode { get; set; }//上级部门代码
        public string SuperiorDepartmentName { get; set; }//上级部门名称
        public string ProductionWorkshop { get; set; }//生产车间
        public string Production { get; set; }//产线
        public string OrganizationName { get; set; }//组织名称
        public string DataBool { get; set; }//数据状态
    }
}
