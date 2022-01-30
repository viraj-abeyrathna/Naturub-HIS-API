using HISWebAPI.Common;
using HISWebAPI.Enum;
using HISWebAPI.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Transactions;

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
        //public DataTable GetItemsByMainCategory(int MainCategoryID, int ItemID)
        //{
        //    objExecute = new Execute(_configuration);
        //    SqlParameter[] param = new SqlParameter[]
        //   {
        //        Execute.AddParameter("@MainCategoryID",MainCategoryID),
        //        Execute.AddParameter("@ItemID",ItemID)
        //   };
        //    DataTable dt = (DataTable)objExecute.Executes("spGetItemsByMainCategory", ReturnType.DataTable, param, CommandType.StoredProcedure);
        //    return dt;
        //}
        #endregion

        #region Computer

        public DataTable GetComputer(int ItemID) {
            objExecute = new Execute(_configuration);
            SqlParameter[] param = new SqlParameter[]
           { 
                    Execute.AddParameter("@ItemID",ItemID)
           };
            DataTable dt = (DataTable)objExecute.Executes("Computer.spGetItem", ReturnType.DataTable, param, CommandType.StoredProcedure);
            return dt;
        }

        public DataTable GetComputerModels()
        {
            objExecute = new Execute(_configuration);
            DataTable dt = (DataTable)objExecute.Executes("Computer.spGetModel", ReturnType.DataTable, CommandType.StoredProcedure);
            return dt;
        }

        public DataTable GetOperatingSystem()
        {
            objExecute = new Execute(_configuration);
            DataTable dt = (DataTable)objExecute.Executes("Computer.spGetOperatingSystem", ReturnType.DataTable, CommandType.StoredProcedure);
            return dt;
        }

        public DataTable GetProcessor()
        {
            objExecute = new Execute(_configuration);
            DataTable dt = (DataTable)objExecute.Executes("Computer.spGetProcessor", ReturnType.DataTable, CommandType.StoredProcedure);
            return dt;
        }

        public DataTable GetRAM()
        {
            objExecute = new Execute(_configuration);
            DataTable dt = (DataTable)objExecute.Executes("Computer.spGetRAM", ReturnType.DataTable, CommandType.StoredProcedure);
            return dt;
        }

        public string SaveComputer(Computer obj)
        {
            string ItemCode = "";
            objExecute = new Execute(_configuration); 

            using (TransactionScope scope = new TransactionScope(TransactionScopeOption.Required, new System.TimeSpan(0, 15, 0)))
            {
                SqlParameter[] paramItem = new SqlParameter[]
                {
                        Execute.AddParameter("@ComputerName",obj.ComputerName),
                        Execute.AddParameter("@IPAddress",obj.IPAddress),
                        Execute.AddParameter("@MainCategoryID",obj.MainCategoryID),
                        Execute.AddParameter("@SubCategoryID",obj.SubCategoryID),
                        Execute.AddParameter("@SectionID",obj.SectionID),
                        Execute.AddParameter("@FARBarcodeNo",obj.FARBarcodeNo),
                        Execute.AddParameter("@LoginUser",obj.LoginUser),
                        Execute.AddParameter("@AuthorizedUser",obj.AuthorizedUser),
                        Execute.AddParameter("@ModelName",obj.ModelName),
                        Execute.AddParameter("@OperatingSystemID",obj.OperatingSystemID),
                        Execute.AddParameter("@IsVirusGuardActive",obj.IsVirusGuardActive),
                        Execute.AddParameter("@ProcessorID",obj.ProcessorID),
                        Execute.AddParameter("@RAMID",obj.RAMID),
                        Execute.AddParameter("@Capacity",obj.Capacity), 
                        Execute.AddParameter("@Remark",obj.Remark), 
                        Execute.AddParameter("@EnterdUserID",obj.EnterdUserID)
                };

                DataRow dr = (DataRow)objExecute.Executes("Computer.spSave", ReturnType.DataRow, paramItem, CommandType.StoredProcedure);

                ItemCode = dr["ItemCode"].ToString();
                scope.Complete();
            }

            return ItemCode;
        }

        #endregion

        #region Ups
        public DataTable GetUps(int ItemID)
        {
            objExecute = new Execute(_configuration);
            SqlParameter[] param = new SqlParameter[]
           {
                    Execute.AddParameter("@ItemID",ItemID)
           };
            DataTable dt = (DataTable)objExecute.Executes("UPS.spGetItem", ReturnType.DataTable, param, CommandType.StoredProcedure);
            return dt;
        }

        public DataTable GetCapacity()
        {
            objExecute = new Execute(_configuration);
            DataTable dt = (DataTable)objExecute.Executes("UPS.spGetCapacity", ReturnType.DataTable, CommandType.StoredProcedure);
            return dt;
        }

        public string SaveUps(Ups obj)
        {
            string ItemCode = "";
            objExecute = new Execute(_configuration);

            using (TransactionScope scope = new TransactionScope(TransactionScopeOption.Required, new System.TimeSpan(0, 15, 0)))
            {
                SqlParameter[] paramItem = new SqlParameter[]
                {
 
                        Execute.AddParameter("@MainCategoryID",obj.MainCategoryID),
                        Execute.AddParameter("@SubCategoryID",obj.SubCategoryID),
                        Execute.AddParameter("@SectionID",obj.SectionID),
                        Execute.AddParameter("@BrandID",obj.BrandID),
                        Execute.AddParameter("@FARBarcodeNo",obj.FARBarcodeNo),
                        Execute.AddParameter("@CapacityID",obj.CapacityID),
                        Execute.AddParameter("@SerialNo",obj.SerialNo),
                        Execute.AddParameter("@Remark",obj.Remark),
                        Execute.AddParameter("@EnterdUserID",obj.EnterdUserID)
                };

                DataRow dr = (DataRow)objExecute.Executes("UPS.spSaveItem", ReturnType.DataRow, paramItem, CommandType.StoredProcedure);

                ItemCode = dr["ItemCode"].ToString();
                scope.Complete();
            }

            return ItemCode;
        }

        #endregion


        #region AccessPoint
        public DataTable GetAccessPoint(int ItemID)
        {
            objExecute = new Execute(_configuration);
            SqlParameter[] param = new SqlParameter[]
           {
                    Execute.AddParameter("@ItemID",ItemID)
           };
            DataTable dt = (DataTable)objExecute.Executes("AccessPoint.spGetItem", ReturnType.DataTable, param, CommandType.StoredProcedure);
            return dt;
        }

        public string SaveAccessPoint(AccessPoint obj)
        {
            string ItemCode = "";
            objExecute = new Execute(_configuration);

            using (TransactionScope scope = new TransactionScope(TransactionScopeOption.Required, new System.TimeSpan(0, 15, 0)))
            {
                SqlParameter[] paramItem = new SqlParameter[]
                {

                        Execute.AddParameter("@MainCategoryID",obj.MainCategoryID),
                        Execute.AddParameter("@SubCategoryID",obj.SubCategoryID),
                        Execute.AddParameter("@SectionID",obj.SectionID),
                        Execute.AddParameter("@BrandID",obj.BrandID),
                        Execute.AddParameter("@IPAddress",obj.IPAddress),
                        Execute.AddParameter("@ModelName",obj.ModelName),
                        Execute.AddParameter("@FARBarcodeNo",obj.FARBarcodeNo),
                        Execute.AddParameter("@SerialNo",obj.SerialNo),
                        Execute.AddParameter("@Remark",obj.Remark),
                        Execute.AddParameter("@EnterdUserID",obj.EnterdUserID)
                };

                DataRow dr = (DataRow)objExecute.Executes("AccessPoint.spSaveItem", ReturnType.DataRow, paramItem, CommandType.StoredProcedure);

                ItemCode = dr["ItemCode"].ToString();
                scope.Complete();
            }

            return ItemCode;
        }
        #endregion

        #region CCTV
        public DataTable GetCCTV(int ItemID)
        {
            objExecute = new Execute(_configuration);
            SqlParameter[] param = new SqlParameter[]
           {
                    Execute.AddParameter("@ItemID",ItemID)
           };
            DataTable dt = (DataTable)objExecute.Executes("CCTV.spGetItem", ReturnType.DataTable, param, CommandType.StoredProcedure);
            return dt;
        }
        #endregion

        #region CCTV
        public DataTable GetDVR(int ItemID)
        {
            objExecute = new Execute(_configuration);
            SqlParameter[] param = new SqlParameter[]
           {
                    Execute.AddParameter("@ItemID",ItemID)
           };
            DataTable dt = (DataTable)objExecute.Executes("DVR.spGetItem", ReturnType.DataTable, param, CommandType.StoredProcedure);
            return dt;
        }
        #endregion

    }
}
