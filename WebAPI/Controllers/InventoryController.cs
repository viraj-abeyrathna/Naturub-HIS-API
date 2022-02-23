using HISWebAPI.DataAccess;
using HISWebAPI.Models;
using Microsoft.AspNetCore.Authorization;
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
    [Authorize]
    public class InventoryController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        InventoryDA objInventoryDA;

        public InventoryController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        #region Computer

        //[Route("GetComputer/{ItemID}")]
        [HttpGet("GetComputer/{ItemID}")]
        [Authorize]
        public JsonResult GetComputer(int ItemID)
        {
            objInventoryDA = new InventoryDA(_configuration);
            DataTable dt = objInventoryDA.GetComputer(ItemID);
            return new JsonResult(dt);
        }

        [Route("GetComputerModels")]
        [HttpGet]
        public JsonResult GetComputerModels()
        {
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

        [Route("GetIPAddress/{IPAddress}")]
        [HttpGet]
        public JsonResult GetIPAddress(string IPAddress)
        {
            objInventoryDA = new InventoryDA(_configuration);
            DataTable dt = objInventoryDA.GetIPAddress(IPAddress);
            return new JsonResult(dt);
        }

        [Route("SaveComputer")]
        [HttpPost]
        public JsonResult SaveComputer(Computer obj)
        {
            objInventoryDA = new InventoryDA(_configuration);
            string ItemCode = objInventoryDA.SaveComputer(obj);
            return new JsonResult(ItemCode);
        }

        [Route("UpdateComputer")]
        [HttpPost]
        public JsonResult UpdateComputer(Computer obj)
        {
            objInventoryDA = new InventoryDA(_configuration);
            string ItemCode = objInventoryDA.UpdateComputer(obj);
            return new JsonResult(ItemCode);
        }


        #endregion


        #region UPS

        [Route("GetUps/{ItemID}")]
        [HttpGet]
        public JsonResult GetUps(int ItemID)
        {
            objInventoryDA = new InventoryDA(_configuration);
            DataTable dt = objInventoryDA.GetUps(ItemID);
            return new JsonResult(dt);
        }


        [Route("GetCapacity")]
        [HttpGet]
        public JsonResult GetCapacity()
        {
            objInventoryDA = new InventoryDA(_configuration);
            DataTable dt = objInventoryDA.GetCapacity();
            return new JsonResult(dt);
        }

        [Route("SaveUps")]
        [HttpPost]
        public JsonResult SaveUps(Ups obj)
        {
            objInventoryDA = new InventoryDA(_configuration);
            string ItemCode = objInventoryDA.SaveUps(obj);
            return new JsonResult(ItemCode);
        }

        #endregion

        #region AccessPoint

        [Route("GetAccessPoint/{ItemID}")]
        [HttpGet]
        public JsonResult GetAccessPoint(int ItemID)
        {
            objInventoryDA = new InventoryDA(_configuration);
            DataTable dt = objInventoryDA.GetAccessPoint(ItemID);
            return new JsonResult(dt);
        }

        [Route("SaveAccessPoint")]
        [HttpPost]
        public JsonResult SaveAccessPoint(AccessPoint obj)
        {
            objInventoryDA = new InventoryDA(_configuration);
            string ItemCode = objInventoryDA.SaveAccessPoint(obj);
            return new JsonResult(ItemCode);
        }

        #endregion

        #region CCTV

        [Route("GetCCTV/{ItemID}")]
        [HttpGet]
        public JsonResult GetCCTV(int ItemID)
        {
            objInventoryDA = new InventoryDA(_configuration);
            DataTable dt = objInventoryDA.GetCCTV(ItemID);
            return new JsonResult(dt);
        }

        [Route("SaveCctv")]
        [HttpPost]
        public JsonResult SaveCctv(Cctvc obj)
        {
            objInventoryDA = new InventoryDA(_configuration);
            string ItemCode = objInventoryDA.SaveCctv(obj);
            return new JsonResult(ItemCode);
        }


        #endregion

        #region DVR
        [Route("GetDVR/{ItemID}")]
        [HttpGet]
        public JsonResult GetDVR(int ItemID)
        {
            objInventoryDA = new InventoryDA(_configuration);
            DataTable dt = objInventoryDA.GetDVR(ItemID);
            return new JsonResult(dt);
        }

        [Route("GetDvrType")]
        [HttpGet]
        public JsonResult GetDvrType()
        {
            objInventoryDA = new InventoryDA(_configuration);
            DataTable dt = objInventoryDA.GetDvrType();
            return new JsonResult(dt);
        }

        [Route("SaveDvr")]
        [HttpPost]
        public JsonResult SaveDvr(Dvr obj)
        {
            objInventoryDA = new InventoryDA(_configuration);
            string ItemCode = objInventoryDA.SaveDvr(obj);
            return new JsonResult(ItemCode);
        }
        #endregion


        #region Ethernet-Switch
        [Route("GetEthernetSwitch/{ItemID}")]
        [HttpGet]
        public JsonResult GetEthernetSwitch(int ItemID)
        {
            objInventoryDA = new InventoryDA(_configuration);
            DataTable dt = objInventoryDA.GetEthernetSwitch(ItemID);
            return new JsonResult(dt);
        }


        [Route("SaveEthernetSwitch")]
        [HttpPost]
        public JsonResult SaveEthernetSwitch(EthernetSwitch obj)
        {
            objInventoryDA = new InventoryDA(_configuration);
            string ItemCode = objInventoryDA.SaveEthernetSwitch(obj);
            return new JsonResult(ItemCode);
        }

        #endregion

        #region Mobile-Phone
        [Route("GetMobilePhone/{ItemID}")]
        [HttpGet]
        public JsonResult GetMobilePhone(int ItemID)
        {
            objInventoryDA = new InventoryDA(_configuration);
            DataTable dt = objInventoryDA.GetMobilePhone(ItemID);
            return new JsonResult(dt);
        }

        #endregion



    }
}
