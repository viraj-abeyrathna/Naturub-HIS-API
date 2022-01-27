using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HISWebAPI.Models
{
    public class Computer
    {
        public int ItemID { get; set; }
        public string ItemCode { get; set; }
        public string ComputerName { get; set; }
        public string IPAddress { get; set; }
        public int SubCategoryID { get; set; }
        public string SubCategory { get; set; }
        public int MainCategoryID { get; set; }
        public int DepartmentID { get; set; }
        public string Department { get; set; }
        public int SectionID { get; set; }
        public string Section { get; set; }
        public string FARBarcodeNo { get; set; }
        public string LoginUser { get; set; }
        public string AuthorizedUser { get; set; }
        public string ModelName { get; set; }
        public string OperatingSystemID { get; set; }
        public string OperatingSystem { get; set; }
        public bool IsVirusGuardActive { get; set; }
        public string VirusGuard { get; set; }
        public int ProcessorID { get; set; }
        public string Processor { get; set; }
        public int RAMID { get; set; }
        public string RAM { get; set; }
        public string Capacity { get; set; }
        public string Remark { get; set; }
        public string EnterdUser { get; set; }
        public int EnterdUserID { get; set; }
        public string LastModifiedUser { get; set; }
        public int LastModifiedUserID { get; set; }
    }
}
