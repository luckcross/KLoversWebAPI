using KLoversWebService.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLoversWebService.Utils
{
    public static class ProcedureUtils
    {
        public static int ExecuteProcedure(KLoversDBContext db, string procName, params SqlParameter[] parameters)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("EXEC ");
            sb.Append(procName);

            SqlParameter currentParameter = null;
            for (int i = 0; i < parameters.Length; i++)
            {
                currentParameter = parameters[i];
                if (i > 0)
                    sb.Append(",");
                sb.Append(" @");
                sb.Append(currentParameter.ParameterName);
                if (currentParameter.Direction == ParameterDirection.Output)
                    sb.Append(" OUT");
            }

            int result = db.Database.ExecuteSqlCommand(sb.ToString(), parameters);
            return result;
        }
    }
}
