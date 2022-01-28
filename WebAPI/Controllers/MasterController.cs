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
  

        #region Department

        [Route("GetDepartment")]
        [HttpGet]
        public JsonResult GetDepartment()
        {
            objMasterDA = new MasterDA(_configuration);
            DataTable dt = objMasterDA.GetDepartment();
            return new JsonResult(dt);
        }

        #endregion

        #region Section

        [Route("GetSection/{DepartmentID}")]
        [HttpGet]
        public JsonResult GetSection(int DepartmentID)
        {
            objMasterDA = new MasterDA(_configuration);
            DataTable dt = objMasterDA.GetSection(DepartmentID);
            return new JsonResult(dt);
        }

        #endregion

        #region MainCategory

        [Route("GetMainCategory")]
        [HttpGet]
        public JsonResult GetMainCategory()
        {
            objMasterDA = new MasterDA(_configuration);
            DataTable dt = objMasterDA.GetMainCategory();
            return new JsonResult(dt);
        }

        #endregion

        #region SubCategory

        [Route("GetSubCategory/{MainCategoryID}")]
        [HttpGet]
        public JsonResult SubCategory(int MainCategoryID)
        {
            objMasterDA = new MasterDA(_configuration);
            DataTable dt = objMasterDA.SubCategory(MainCategoryID);
            return new JsonResult(dt);
        }

        #endregion
    }
}
