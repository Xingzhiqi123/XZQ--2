﻿using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XZQ.MESIntelligence.Department;

namespace XZQ.MESIntelligence.APJTeamOrGroup.Dto
{
    [AutoMapTo(typeof(Teamorgroup))]
    public class CreateAPJUserDtos
    {
        public string TeamorgroupCode { get; set; }//班组代码
        public string TeamorgroupName { get; set; }//班组名称
        public string TeamorgroupGrouping { get; set; }//班组分组
        public string Organization { get; set; }//组织
        public string TeamorgroupRemark { get; set; }//班组备注
        public string Linenumbers { get; set; }//行号
        public string StaffroupCode { get; set; }//员工代码
        public string StaffName { get; set; }//员工姓名
        public string StaffBit { get; set; }//性别
        public string Remark { get; set; }//备注
        public string Preparedby { get; set; } = "系统管理员";//制单人
        public DateTime UpdateDate { get; set; } = DateTime.Now;//制单日期
        public string Auditor { get; set; } = "系统管理员";//审核人
        public DateTime JinDate { get; set; } = DateTime.Now;//制单日期
    }
}
