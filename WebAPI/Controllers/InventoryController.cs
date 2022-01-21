using HISWebAPI.DataAccess;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace HISWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventoryController : Controller
    {
        private readonly IConfiguration _configuration;

        InventoryDA objInventoryDA;

        public InventoryController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        #region Computer
        [Route("GetComputer/{ItemID}")]
        [HttpGet]
        public JsonResult GetComputer(int ItemID)
        { 
            objInventoryDA = new InventoryDA(_configuration);
            DataTable dt = objInventoryDA.GetItemsByMainCategory(1, ItemID);
            return new JsonResult(dt);
        }
        #endregion
    }
}
