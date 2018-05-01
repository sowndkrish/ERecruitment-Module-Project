using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types;

namespace Erecruitment_BO
{
   public class Employee_DetailsBO:IEmployeeDetailsBO
    {
        int employee_id;
        string employee_name;
        DateTime dob;
        DateTime doj;
        string gender;
        string division;
        float ctc;
        string designation;
        int unit_head_id;
        int project_id;
        bool is_hr;
        bool is_new;
        public int Employee_Id
        {
            get
            {
                return employee_id;
            }
            set
            {
                employee_id = value;
            }
        }
        public string Employee_Name
        {
            get
            {
                return employee_name;
            }
            set
            {
                employee_name = value;
            }
        }
        public DateTime DOB
        {
            get
            {
                return dob;
            }
            set
            {
                dob = value;
            }
        }
        public DateTime DOJ
        {
            get
            {
                return doj;
            }
            set
            {
                doj = value;
            }
        }
        public string Gender
        {
            get
            {
                return gender;
            }
            set
            {
                gender = value;
            }
        }
        public string Division
        {
            get
            {
                return division;
            }
            set
            {
                division = value;
            }
        }
        public float CTC
        {
            get
            {
                return ctc;
            }
            set
            {
                ctc = value;
            }
        }
        public string Designation
        {
            get
            {
                return designation;
            }
            set
            {
                designation = value;
            }
        }
        public int Unit_Head_Id
        {
            get
            {
                return unit_head_id;
            }
            set
            {
                unit_head_id = value;
            }
        }
        public int Project_Id
        {
            get
            {
                return project_id;
            }
            set
            {
                project_id = value;
            }
        }
        public bool Is_Hr
        {
            get
            {
                return is_hr;
            }
            set
            {
                is_hr = value;
            }
        }
        public bool Is_New
        {
            get
            {
                return is_new;
            }
            set
            {
                is_new = value;
            }
        }
        public Employee_DetailsBO()
        { }
        public Employee_DetailsBO(int employee_id,string employee_name,DateTime dob,DateTime doj,string gender,string division,float ctc,string designation,int unit_head_id,int project_id,bool is_hr,bool is_new)
        {
            this.employee_id = employee_id;
            this.employee_name = employee_name;
            this.dob = dob;
            this.doj = doj;
            this.gender = gender;
            this.division = division;
            this.ctc = ctc;
            this.designation = designation;
            this.unit_head_id = unit_head_id;
            this.project_id = project_id;
            this.is_hr = is_hr;
            this.is_new = is_new;
        }
    }
}
