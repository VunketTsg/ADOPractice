using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ADOLog4Net.EmployeeDAC
{
    public class CommonUtil
    {
        public static string GetConnectionString()
        {
            // read the data from web.config 
            return System.Configuration.ConfigurationManager.ConnectionStrings["TestNorthwind2"].ConnectionString;
        }
    }
}