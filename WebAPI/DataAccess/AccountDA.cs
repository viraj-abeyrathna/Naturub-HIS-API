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
    public class AccountDA
    {
        Execute objExecute;
        private readonly IConfiguration _configuration;

        public AccountDA(IConfiguration configuration)
        {
            this._configuration = configuration;
        }

        public DataTable GetUser(string userName)
        {
            objExecute = new Execute(_configuration);
            SqlParameter[] param = new SqlParameter[]
           {
                    Execute.AddParameter("@UserName",userName)
           };
            DataTable dt = (DataTable)objExecute.Executes("UserMaintanance.spGetUser", ReturnType.DataTable, param, CommandType.StoredProcedure);
            return dt;
        }
    }
}
