using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HISWebAPI.Models
{
    public class Maintenance
    {
        public int SubCategoryID { get; set; }
        public int ItemID { get; set; }
        public int MaintenanceTypeID { get; set; }
        public int MaintenancePartID { get; set; }
        public string Remark { get; set; }
        public int EnterdUser { get; set; }
        public DateTime EnterdDate { get; set; }
    }
}
