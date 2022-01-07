using HISWebAPI.Common;
using HISWebAPI.DataAccess;
using HISWebAPI.Enum;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace HISWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MasterController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        MasterDA objMasterDA;


        public MasterController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        #region Data Set

        [Route("GetDataSet/{id}")]
        [HttpGet]
        public JsonResult GetDataSet(int id)
        {
            objMasterDA = new MasterDA(_configuration);
            DataTable dt = objMasterDA.GetDataSet(id); 
            return new JsonResult(dt);
        }

        #endregion
    }
}
