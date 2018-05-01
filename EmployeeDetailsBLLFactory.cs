using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERecruitment_BLL;
using Types;

namespace ERecruitmentFactoryBLL
{
   public class EmployeeDetailsBLLFactory
    {
        public static IEmployeeDetailsBLL createEmployeeDetailsBLL()
        {
            IEmployeeDetailsBLL objemployeedetailsbll = new EmployeeDetailsBLL();
            return objemployeedetailsbll;
        }
    }
}
