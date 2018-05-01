using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types
{
    public interface IEmployeeDetailsBO
    {
        int Employee_Id { get; set; }
      string Employee_Name { get; set; }
        DateTime DOB { get; set; }
        DateTime DOJ { get; set; }
        string Gender { get; set; }
        string Division { get; set; }
        float CTC { get; set; }
        string Designation { get; set; }
        int Unit_Head_Id { get; set; }
        int Project_Id { get; set; }
        bool Is_Hr { get; set; }
        bool Is_New { get; set; }
    }
}
