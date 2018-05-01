using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types;
using Erecruitment_DLL;

namespace ERecruitmentDALFactory
{
   public class EmployeeDetailsDALFactory
    {
        public static IEmployeeDetailsDAL createEmployeeDetailsDAL()
        {
            IEmployeeDetailsDAL objemployeedetailsdal = new EmployeeDetailsDLL();
            return objemployeedetailsdal;
        }
    }
}
