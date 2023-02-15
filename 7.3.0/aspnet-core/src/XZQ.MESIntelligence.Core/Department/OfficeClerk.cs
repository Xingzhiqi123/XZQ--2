using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XZQ.MESIntelligence.Department
{
    //职员信息
    public class OfficeClerk : Entity<int>
    {
        [Column("Id")]
        public override int Id { get; set; }
        public string StaffCode { get; set; }//员工代码
        public string StaffName { get; set; }//员工姓名 
        public string Gender { get; set; }//性别
        public string EmailAddress { get; set; }//电子邮箱 
    }
}

