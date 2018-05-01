using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types;
using Erecruitment_BO;

namespace ERecruitmentFactoryBO
{
  public  class Employee_DetailsBOFactory
    {
        public static IEmployeeDetailsBO createEmployeeDetailsBO()
        {
            IEmployeeDetailsBO objemployeedetailsbo = new Employee_DetailsBO();
            return objemployeedetailsbo;
        }
        public static IEmployeeDetailsBO createEmployeeDetailsBO(int employee_id, string employee_name, DateTime dob, DateTime doj, string gender, string division, float ctc, string designation, int unit_head_id, int project_id, bool is_hr, bool is_new)
        {
            IEmployeeDetailsBO objemployeedetailsbo = new Employee_DetailsBO(employee_id,employee_name,dob,doj,gender,division,ctc,designation,unit_head_id,project_id,is_hr,is_new);
            return objemployeedetailsbo;
        }
    }
}
