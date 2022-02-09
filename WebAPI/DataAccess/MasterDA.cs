using HISWebAPI.Common;
using HISWebAPI.Enum;
using HISWebAPI.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
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

        //#region Data Set
        //public DataTable GetDataSet(int DataSetID)
        //{
        //    objExecute = new Execute(_configuration);
        //    SqlParameter[] param = new SqlParameter[]
        //    {
        //        Execute.AddParameter("@DataSetID",DataSetID)
        //    };
        //    DataTable dt = (DataTable)objExecute.Executes("spGetDataSet", ReturnType.DataTable, param, CommandType.StoredProcedure);
        //    return dt;
        //}

        //#endregion

        //#region Component
        //public DataTable GetComponent(int ComponentID)
        //{
        //    objExecute = new Execute(_configuration);
        //    SqlParameter[] param = new SqlParameter[]
        //    {
        //        Execute.AddParameter("@ComponentID",ComponentID)
        //    };
        //    DataTable dt = (DataTable)objExecute.Executes("spGetComponent", ReturnType.DataTable, param, CommandType.StoredProcedure);
        //    return dt;
        //}
        //#endregion

        #region Department

        public DataTable GetDepartment() {
            objExecute = new Execute(_configuration);
            DataTable dt = (DataTable)objExecute.Executes("Master.spGetDepartment", ReturnType.DataTable, CommandType.StoredProcedure);
            return dt;
        }

        #endregion

        #region Section

        public DataTable GetSection(int DepartmentID)
        {
            objExecute = new Execute(_configuration);
            SqlParameter[] param = new SqlParameter[]
             {
                Execute.AddParameter("@DepartmentID",DepartmentID)
             };
            DataTable dt = (DataTable)objExecute.Executes("Master.spGetSection", ReturnType.DataTable, param,CommandType.StoredProcedure);
            return dt;
        }

        #endregion

        #region MainCategory
        public DataTable GetMainCategory()
        {
            objExecute = new Execute(_configuration);
            DataTable dt = (DataTable)objExecute.Executes("Master.spGetMainCategory", ReturnType.DataTable, CommandType.StoredProcedure);
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
            DataTable dt = (DataTable)objExecute.Executes("Master.spGetSubCategory", ReturnType.DataTable, param, CommandType.StoredProcedure);
            return dt;
        }
        #endregion

        #region Brand
        public DataTable GetBrand(int MainCategoryID)
        {
            objExecute = new Execute(_configuration);
            SqlParameter[] param = new SqlParameter[]
             {
                Execute.AddParameter("@MainCategoryID",MainCategoryID)
             };
            DataTable dt = (DataTable)objExecute.Executes("Master.spGetBrand", ReturnType.DataTable, param, CommandType.StoredProcedure);
            return dt;
        }
        #endregion

        #region Maintenance

        public DataTable GetMaintenanceType() {
            objExecute = new Execute(_configuration); 
            DataTable dt = (DataTable)objExecute.Executes("Master.spGetMaintenanceType", ReturnType.DataTable, CommandType.StoredProcedure);
            return dt;
        }

        public DataTable GetMaintenancePart(int subCategoryID) {
            objExecute = new Execute(_configuration);
            SqlParameter[] param = new SqlParameter[]
             {
                Execute.AddParameter("@SubCategoryID",subCategoryID)
             };
            DataTable dt = (DataTable)objExecute.Executes("Master.spGetMaintenancePart", ReturnType.DataTable, param, CommandType.StoredProcedure);
            return dt;
        }
        #endregion

        //#region Main Category Component

        //public List<MainCategoryComponent> GetMainCategoryComponent(int MainCategoryID)
        //{
        //    List<MainCategoryComponent> lst = new List<MainCategoryComponent>();

        //    objExecute = new Execute(_configuration);
        //    SqlParameter[] param = new SqlParameter[]
        //     {
        //        Execute.AddParameter("@MainCategoryID",MainCategoryID)
        //     };
        //    DataTable dt = (DataTable)objExecute.Executes("spGetMainCategoryComponent", ReturnType.DataTable, param, CommandType.StoredProcedure);

        //    foreach (DataRow dataRow in dt.Rows)
        //    {
        //        MainCategoryComponent obj = new MainCategoryComponent();
        //        obj.MainCategoryComponentID = Convert.ToInt32(dataRow["MainCategoryComponentID"]);
        //        obj.ComponentID = Convert.ToInt32(dataRow["ComponentID"]);
        //        obj.ComponentName = dataRow["ComponentName"].ToString();

        //        lst.Add(obj);
        //    }

        //    return lst;
        //}
        //#endregion
    }
}
