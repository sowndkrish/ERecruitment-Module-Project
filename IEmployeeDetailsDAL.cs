using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types
{
    public interface IEmployeeDetailsDAL
    {
        int createEmployeeDetails(IEmployeeDetailsBO obj);
        void viewEmployeeDetails();
        int updateEmployeeDetails(IEmployeeDetailsBO obj);
    }
}
