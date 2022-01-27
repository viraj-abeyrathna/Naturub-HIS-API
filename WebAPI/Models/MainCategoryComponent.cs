using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HISWebAPI.Models
{
    public class MainCategoryComponent
    {
        public int MainCategoryComponentID { get; set; }
        public int ComponentID { get; set; }
        public string ComponentName { get; set; }
        public string Value { get; set; }
    }
}
