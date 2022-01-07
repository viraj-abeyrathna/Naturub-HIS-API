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
    public class MasterDA
    {
        Execute objExecute; 
        private readonly IConfiguration _configuration;

        public MasterDA(IConfiguration configuration)
        {
            this._configuration = configuration;
        }

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
    }
}
