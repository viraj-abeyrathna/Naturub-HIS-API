﻿using HISWebAPI.Common;
using HISWebAPI.Enum;
using HISWebAPI.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace HISWebAPI.DataAccess
{
    public class InventoryDA
    {
        Execute objExecute;
        private readonly IConfiguration _configuration;

        public InventoryDA(IConfiguration configuration)
        {
            this._configuration = configuration;
        }

        #region Common
        public DataTable GetItemsByMainCategory(int MainCategoryID, int ItemID)
        {
            objExecute = new Execute(_configuration);
            SqlParameter[] param = new SqlParameter[]
           {
                Execute.AddParameter("@MainCategoryID",MainCategoryID),
                Execute.AddParameter("@ItemID",ItemID)
           };
            DataTable dt = (DataTable)objExecute.Executes("spGetItemsByMainCategory", ReturnType.DataTable, param, CommandType.StoredProcedure);
            return dt;
        }
        #endregion

        #region Computer
        public DataTable GetComputerModels()
        {
            objExecute = new Execute(_configuration); 
            DataTable dt = (DataTable)objExecute.Executes("spGetComputerModels", ReturnType.DataTable, CommandType.StoredProcedure);
            return dt;
        }

        public DataTable GetOperatingSystem()
        {
            objExecute = new Execute(_configuration);
            DataTable dt = (DataTable)objExecute.Executes("spGetOperatingSystem", ReturnType.DataTable, CommandType.StoredProcedure);
            return dt;
        }

        public DataTable GetVirusGuard()
        {
            objExecute = new Execute(_configuration);
            DataTable dt = (DataTable)objExecute.Executes("spGetVirusGuard", ReturnType.DataTable, CommandType.StoredProcedure);
            return dt;
        }

        public DataTable GetProcessor() {
            objExecute = new Execute(_configuration);
            DataTable dt = (DataTable)objExecute.Executes("spGetProcessor", ReturnType.DataTable, CommandType.StoredProcedure);
            return dt;
        }

        public DataTable GetRAM() {
            objExecute = new Execute(_configuration);
            DataTable dt = (DataTable)objExecute.Executes("spGetRAM", ReturnType.DataTable, CommandType.StoredProcedure);
            return dt;
        }

        public DataRow SaveComputer(Computer obj) {
            objExecute = new Execute(_configuration);
            SqlParameter[] param = new SqlParameter[]
           {
                Execute.AddParameter("@MainCategoryID",obj.MainCategoryID),
                Execute.AddParameter("@SubCategoryID",obj.SubCategoryID),
                Execute.AddParameter("@FARCode",obj.FARCode),
                Execute.AddParameter("@ComputerName",obj.ComputerName),
                Execute.AddParameter("@IPAddress",obj.IPAddress),
                Execute.AddParameter("@DepartmentID",obj.DepartmentID),
                Execute.AddParameter("@SectionID",obj.SectionID),
                Execute.AddParameter("@LoginUser",obj.LoginUser),
                Execute.AddParameter("@User",obj.User),
                Execute.AddParameter("@OperatingSystemID",obj.OperatingSystemID),
                Execute.AddParameter("@VirusGuardID",obj.VirusGuardID),
                Execute.AddParameter("@ProcessorID",obj.ProcessorID),
                Execute.AddParameter("@RAMID",obj.RAMID),
                Execute.AddParameter("@Capacity",obj.Capacity),
                Execute.AddParameter("@ModelName",obj.ModelName),
                Execute.AddParameter("@Remark",obj.Remark)
           };
            DataRow dr = (DataRow)objExecute.Executes("spSaveComputer", ReturnType.DataRow, param, CommandType.StoredProcedure);
            return dr;
        }

        #endregion
    }
}
