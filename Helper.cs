using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Student_Management_System
{
    public static class Helper
    {
        public static string CnnVal(string StudentDB)
        {
            return ConfigurationManager.ConnectionStrings[StudentDB].ConnectionString;
        }
    }
}
