using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlankApp1.Models
{
    public class Person : ModelBase
    {
        private int Id;
        public int ID { get { return Id; } set { Id = value; OnPropertyChanged("ID"); } }

        private string departmentCode;
        public string DepartmentCode { get { return departmentCode; }set { departmentCode = value; OnPropertyChanged("DepartmentCode"); } }//部门代码

        private string departmentName;
        public string DepartmentName { get { return departmentName; } set { departmentName = value; OnPropertyChanged("DepartmentName"); } }//部门名称

        private string principalCode;
        public string PrincipalCode { get { return principalCode; } set { principalCode = value; OnPropertyChanged("PrincipalCode"); } }//负责人代码

        private string principalName;
        public string PrincipalName { get { return principalName; } set { principalName = value; OnPropertyChanged("PrincipalName"); } }//负责人名称

        private string superiorDepartmentCode;
        public string SuperiorDepartmentCode { get { return superiorDepartmentCode; } set { superiorDepartmentCode = value; OnPropertyChanged("SuperiorDepartmentCode"); } }//上级部门代码

        private string superiorDepartmentName;
        public string SuperiorDepartmentName { get { return superiorDepartmentName; } set { superiorDepartmentName = value; OnPropertyChanged("SuperiorDepartmentName"); } }//上级部门名称

        private string productionWorkshop;
        public string ProductionWorkshop { get { return productionWorkshop; } set { productionWorkshop = value; OnPropertyChanged("ProductionWorkshop"); } }//生产车间

        private string production;
        public string Production { get { return production; } set { production = value; OnPropertyChanged("Production"); } }//产线

        private string organizationName;
        public string OrganizationName { get { return organizationName; } set { organizationName = value; OnPropertyChanged("OrganizationName"); } }//组织名称

        private string dataBool;
        public string DataBool { get { return dataBool; } set { dataBool = value; OnPropertyChanged("DataBool"); } }//数据状态
    }

    public class Result
    {
        public int totalCount { get; set; }

        public List<Person> items { get; set; }
    }

    public class Root
    {
        public Result result { get; set; }
        public string targetUrl { get; set; }
        public string success { get; set; }
        public string error { get; set; }
        public string unAuthorizedRequest { get; set; }
        public string __abp { get; set; }
    }
}
