using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ADOLog4Net.EmployeeDAC
{
    public class Logobject
    { 
        public log4net.ILog  ConnectionString()
        {
            log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            return log;
        }


    }
}