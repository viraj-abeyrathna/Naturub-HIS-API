using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HISWebAPI.Models
{
    public class JobCard
    {
        public int JobCardID { get; set; }
        public string JobCardNo { get; set; }
        public string ItemCode { get; set; }
        public string ItemDesc { get; set; }
        public string MaintenanceType { get; set; }
        public string MaintenancePart { get; set; }
        public string MainCategory { get; set; }
        public string SubCategory { get; set; }
        public string Remark { get; set; }
        public string EnterdUser { get; set; }
    }
}
