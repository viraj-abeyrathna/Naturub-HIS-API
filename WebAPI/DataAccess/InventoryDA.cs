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
                        Execute.AddParameter("@MainCategoryID",obj.MainCategoryID),
                        Execute.AddParameter("@SubCategoryID",obj.SubCategoryID),    
                        Execute.AddParameter("@SectionID",obj.SectionID),  
                        Execute.AddParameter("@EnterdUserID",obj.Remark)
                };

                DataRow dr = (DataRow)objExecute.Executes("Computer.spSave", ReturnType.DataRow, paramItem, CommandType.StoredProcedure);

                ItemCode = dr["ItemCode"].ToString(); 
            }

            return ItemCode;
        }

        #endregion
    }
}
