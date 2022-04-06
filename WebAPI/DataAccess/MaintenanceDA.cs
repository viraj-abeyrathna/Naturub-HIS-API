using HISWebAPI.Common;
using HISWebAPI.Enum;
using HISWebAPI.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;

namespace HISWebAPI.DataAccess
{
    public class MaintenanceDA 
    {
        Execute objExecute;
        private readonly IConfiguration _configuration;

        public MaintenanceDA(IConfiguration configuration)
        {
            this._configuration = configuration;
        }

        public string SaveJobCard(Maintenance obj)
        {
            string ItemCode = "";
            objExecute = new Execute(_configuration);

            using (TransactionScope scope = new TransactionScope(TransactionScopeOption.Required, new System.TimeSpan(0, 15, 0)))
            {
                SqlParameter[] paramItem = new SqlParameter[]
                {
                        Execute.AddParameter("@ItemID",obj.ItemID),
                        Execute.AddParameter("@SubCategoryID",obj.SubCategoryID),
                        Execute.AddParameter("@MaintenanceTypeID",obj.MaintenanceTypeID),
                        Execute.AddParameter("@MaintenancePartID",obj.MaintenancePartID), 
                        Execute.AddParameter("@Remark",obj.Remark),
                        Execute.AddParameter("@UserID",obj.EnterdUser)
                        
                };

                DataRow dr = (DataRow)objExecute.Executes("Maintenance.spSaveJobCard", ReturnType.DataRow, paramItem, CommandType.StoredProcedure);

                ItemCode = dr["JobCardNo"].ToString();
                scope.Complete();
            }

            return ItemCode;
        }

        public DataTable GetJobCard(int jobCardID)
        {
            objExecute = new Execute(_configuration);
            SqlParameter[] param = new SqlParameter[]
           {
                    Execute.AddParameter("@JobCardID",jobCardID)
           };
            DataTable dt = (DataTable)objExecute.Executes("Maintenance.spGetJobCard", ReturnType.DataTable, param, CommandType.StoredProcedure);
            return dt;
        }
        
    }
}
