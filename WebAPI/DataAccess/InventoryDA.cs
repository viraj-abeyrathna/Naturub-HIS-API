using HISWebAPI.Common;
using HISWebAPI.Enum;
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

        #endregion
    }
}
