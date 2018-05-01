using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using ERecruitmentFactoryBO;
using Types;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Erecruitment_DLL
{
    class DataUtility
    {
        public static String getConnection()
        {
            String str = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
            return str;
        }
    }
}
