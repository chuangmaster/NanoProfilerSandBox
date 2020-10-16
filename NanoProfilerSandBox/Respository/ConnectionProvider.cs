using EF.Diagnostics.Profiling;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using EF.Diagnostics.Profiling.Data;

namespace NanoProfilerSandBox.Respository
{
    public class ConnectionProvider
    {
        public static IDbConnection Connection
        {
            get
            {
                var dbConnection = new SqlConnection(@"data source=(LocalDB)\MSSQLLocalDB;initial catalog=Northwind;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework");
                var dbProfiler = new DbProfiler(ProfilingSession.Current.Profiler);
                return new ProfiledDbConnection(dbConnection, dbProfiler);
            }
        }

    }
}