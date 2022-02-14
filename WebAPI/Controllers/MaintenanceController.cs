using HISWebAPI.DataAccess;
using HISWebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HISWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MaintenanceController : Controller
    {
        private readonly IConfiguration _configuration;
        MaintenanceDA objMaintenanceDA;

        public MaintenanceController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [Route("SaveJobCard")]
        [HttpPost]
        public JsonResult SaveComputer(Maintenance obj)
        {
            objMaintenanceDA = new MaintenanceDA(_configuration);
            string JobCardNo = objMaintenanceDA.SaveJobCard(obj);
            return new JsonResult(JobCardNo);
        }
    }
}
