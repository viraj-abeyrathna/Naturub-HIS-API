using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HISWebAPI.Models
{
    public class MobilePhone
    {
        public int ItemID { get; set; }
        public string ItemCode { get; set; }
        public int SubCategoryID { get; set; }
        public string SubCategory { get; set; }
        public int MainCategoryID { get; set; }
        public int DepartmentID { get; set; }
        public string Department { get; set; }
        public string IMEINumber1 { get; set; }
        public string IMEINumber2 { get; set; }
        public int SectionID { get; set; }
        public string Section { get; set; }
        public string FARBarcodeNo { get; set; }
        public string AuthorizedUser { get; set; }
        public DateTime IssueDate { get; set; }
        public string ModelName { get; set; }
        public string EnterdUser { get; set; }
        public int EnterdUserID { get; set; }
        public string LastModifiedUser { get; set; }
        public int LastModifiedUserID { get; set; }
    }
}
