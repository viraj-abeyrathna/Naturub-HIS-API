using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HISWebAPI.Models
{
    public class Computer
    {
        public int MainCategoryID { get; set; }
        public int SubCategoryID { get; set; }
        public string FARCode { get; set; }
        public string ComputerName { get; set; }
        public string IPAddress { get; set; }
        public int DepartmentID { get; set; }
        public int SectionID { get; set; }
        public string LoginUser { get; set; }
        public string User { get; set; }
        public string OperatingSystemID { get; set; }
        public string VirusGuardID { get; set; }
        public string ProcessorID { get; set; }
        public string RAMID { get; set; }
        public string Capacity { get; set; }
        public string ModelName { get; set; }
        public string Remark { get; set; }
    }
}
