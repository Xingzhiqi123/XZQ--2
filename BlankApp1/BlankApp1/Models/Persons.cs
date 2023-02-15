using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlankApp1.Models
{
    public class Persons : ModelBase
    {
        private int Id;
        public int ID { get { return Id; } set { Id = value; OnPropertyChanged("ID"); } }

        private string teamorgroupCode;
        public string TeamorgroupCode { get { return teamorgroupCode; } set { teamorgroupCode = value; OnPropertyChanged("TeamorgroupCode"); } }//班组代码


        private string teamorgroupName;
        public string TeamorgroupName { get { return teamorgroupName; } set { teamorgroupName = value; OnPropertyChanged("TeamorgroupName"); } }//班组代码

        private string teamorgroupGrouping;
        public string TeamorgroupGrouping { get { return teamorgroupGrouping; } set { teamorgroupGrouping = value; OnPropertyChanged("TeamorgroupGrouping"); } }//班组代码

        private string organization;
        public string Organization { get { return organization; } set { organization = value; OnPropertyChanged("Organization"); } }//班组代码

        private string teamorgroupRemark;
        public string TeamorgroupRemark { get { return teamorgroupRemark; } set { teamorgroupRemark = value; OnPropertyChanged("TeamorgroupRemark"); } }//班组代码

        private string linenumbers;
        public string Linenumbers { get { return linenumbers; } set { linenumbers = value; OnPropertyChanged("Linenumbers"); } }//班组代码

        private string staffroupCode;
        public string StaffroupCode { get { return staffroupCode; } set { staffroupCode = value; OnPropertyChanged("StaffroupCode"); } }//班组代码

        private string staffName;
        public string StaffName { get { return staffName; } set { staffName = value; OnPropertyChanged("StaffName"); } }//班组代码

        private string staffBit;
        public string StaffBit { get { return staffBit; } set { staffBit = value; OnPropertyChanged("StaffBit"); } }//班组代码

        private string remark;
        public string Remark { get { return remark; } set { remark = value; OnPropertyChanged("Remark"); } }//班组代码

        private string preparedby;
        public string Preparedby { get { return preparedby; } set { preparedby = value; OnPropertyChanged("Preparedby"); } }//班组代码

        private DateTime updateDate;
        public DateTime UpdateDate { get { return updateDate; } set { updateDate = value; OnPropertyChanged("UpdateDate"); } }//班组代码

        private string auditor;
        public string Auditor { get { return auditor; } set { auditor = value; OnPropertyChanged("Auditor"); } }//班组代码

        private DateTime jinDate;
        public DateTime JinDate { get { return jinDate; } set { jinDate = value; OnPropertyChanged("JinDate"); } }//班组代码  
    }

    public class Results
    {
        public int totalCount { get; set; }

        public List<Persons> items { get; set; }
    }

    public class Roots
    {
        public Results result { get; set; }
        public string targetUrl { get; set; }
        public string success { get; set; }
        public string error { get; set; }
        public string unAuthorizedRequest { get; set; }
        public string __abp { get; set; }
    }
}
