using HISWebAPI.DataAccess;
using HISWebAPI.Models;
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

        [Route("GetComputerModels")]
        [HttpGet]
        public JsonResult GetComputerModels() {
            objInventoryDA = new InventoryDA(_configuration);
            DataTable dt = objInventoryDA.GetComputerModels();
            return new JsonResult(dt);
        }

        [Route("GetOperatingSystem")]
        [HttpGet]
        public JsonResult GetOperatingSystem()
        {
            objInventoryDA = new InventoryDA(_configuration);
            DataTable dt = objInventoryDA.GetOperatingSystem();
            return new JsonResult(dt);
        }

        [Route("GetVirusGuard")]
        [HttpGet]
        public JsonResult GetVirusGuard() {
            objInventoryDA = new InventoryDA(_configuration);
            DataTable dt = objInventoryDA.GetVirusGuard();
            return new JsonResult(dt);
        }

        [Route("GetProcessor")]
        [HttpGet]
        public JsonResult GetProcessor()
        {
            objInventoryDA = new InventoryDA(_configuration);
            DataTable dt = objInventoryDA.GetProcessor();
            return new JsonResult(dt);
        }

        [Route("GetRAM")]
        [HttpGet]
        public JsonResult GetRAM()
        {
            objInventoryDA = new InventoryDA(_configuration);
            DataTable dt = objInventoryDA.GetRAM();
            return new JsonResult(dt);
        }

        [Route("SaveComputer")]
        [HttpPost]
        public JsonResult SaveComputer(Computer obj)
        {
            objInventoryDA = new InventoryDA(_configuration);
            DataRow dr = objInventoryDA.SaveComputer(obj);
            return new JsonResult(dr);
        }

        #endregion
    }
}
