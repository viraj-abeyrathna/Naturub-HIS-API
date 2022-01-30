using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HISWebAPI.Models
{
    public class Ups
    {
        public int ItemID { get; set; }
        public string ItemCode { get; set; }
        public int SubCategoryID { get; set; }
        public string SubCategory { get; set; }
        public int MainCategoryID { get; set; }
        public int DepartmentID { get; set; }
        public string Department { get; set; }
        public int SectionID { get; set; }
        public string Section { get; set; }
        public string FARBarcodeNo { get; set; }
        public string SerialNo { get; set; }
        public int BrandID { get; set; }
        public int CapacityID { get; set; }
        public string Remark { get; set; }
        public string EnterdUser { get; set; }
        public int EnterdUserID { get; set; }
        public string LastModifiedUser { get; set; }
        public int LastModifiedUserID { get; set; }


    }
}
