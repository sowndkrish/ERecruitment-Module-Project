using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERecruitmentDALFactory;
using ERecruitmentFactoryBO;
using Types;

namespace ERecruitment_BLL
{
   public class EmployeeDetailsBLL:IEmployeeDetailsBLL
    {
        public int createEmployeeDetails(IEmployeeDetailsBO obj)
        {
            int ret = 0;
            IEmployeeDetailsDAL objempdetailsdal = ERecruitmentDALFactory.EmployeeDetailsDALFactory.createEmployeeDetailsDAL();

            objempdetailsdal.createEmployeeDetails(obj) ;
            return ret;
        }
        public void viewEmployeeDetails()
        {
            IEmployeeDetailsDAL objempdetailsdal = ERecruitmentDALFactory.EmployeeDetailsDALFactory.createEmployeeDetailsDAL();
            objempdetailsdal.viewEmployeeDetails();
        }
        public int updateEmployeeDetails(IEmployeeDetailsBO obj)
        {
            int ret = 0;
            IEmployeeDetailsDAL objempdetailsdal = ERecruitmentDALFactory.EmployeeDetailsDALFactory.createEmployeeDetailsDAL();

            return ret;
        }
    }
}
