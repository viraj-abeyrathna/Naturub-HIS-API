using HISWebAPI.Common;
using HISWebAPI.Enum;
using Microsoft.Extensions.Configuration;
using System;
using System.Data;
using System.Data.SqlClient;

namespace HISWebAPI.DataAccess
{
    public class MasterDA
    {
        Execute objExecute;
        private readonly IConfiguration _configuration;

        public MasterDA(IConfiguration configuration)
        {
            this._configuration = configuration;
        }

        #region Data Set
        public DataTable GetDataSet(int DataSetID)
        {
            objExecute = new Execute(_configuration);
            SqlParameter[] param = new SqlParameter[]
            {
                Execute.AddParameter("@DataSetID",DataSetID)
            };
            DataTable dt = (DataTable)objExecute.Executes("spGetDataSet", ReturnType.DataTable, param, CommandType.StoredProcedure);
            return dt;
        }

        #endregion

        #region Component
        public DataTable GetComponent(int ComponentID)
        {
            objExecute = new Execute(_configuration);
            SqlParameter[] param = new SqlParameter[]
            {
                Execute.AddParameter("@ComponentID",ComponentID)
            };
            DataTable dt = (DataTable)objExecute.Executes("spGetComponent", ReturnType.DataTable, param, CommandType.StoredProcedure);
            return dt;
        }
        #endregion

        #region MainCategory
        public DataTable GetMainCategory()
        {
            objExecute = new Execute(_configuration);
            DataTable dt = (DataTable)objExecute.Executes("spGetMainCategory", ReturnType.DataTable, CommandType.StoredProcedure);
            return dt;
        }
        #endregion

        #region SubCategory
        public DataTable SubCategory(int MainCategoryID)
        {
            objExecute = new Execute(_configuration);
            SqlParameter[] param = new SqlParameter[]
             {
                Execute.AddParameter("@MainCategoryID",MainCategoryID)
             };
            DataTable dt = (DataTable)objExecute.Executes("spGetSubCategory", ReturnType.DataTable, param, CommandType.StoredProcedure);
            return dt;
        }
        #endregion
    }
}
