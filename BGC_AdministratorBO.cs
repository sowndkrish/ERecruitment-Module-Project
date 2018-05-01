using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types;

namespace Erecruitment_BO
{
   public class BGC_AdministratorBO:IBGCAdministratorBO
    {
        int bgc_administrator_id;
        string status;
        DateTime status_change_date;
        int employee_id;
        public int BGC_Administrator_Id 
        {
            get
            {
                return bgc_administrator_id;
            }
            set
            {
                bgc_administrator_id = value;
            }        
        }
        public string Status
        {
            get
            {
                return status;
            }
            set
            {
                status = value;
            }
        }
        public DateTime Status_Change_Date
        {
            get
            {
                return status_change_date;
            }
            set
            {
                status_change_date = value;
            }
        }
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
        public BGC_AdministratorBO()
        { }
        public BGC_AdministratorBO(int bgc_administrator_id, string status, DateTime status_change_date,int employee_id)
        {
            this.bgc_administrator_id = bgc_administrator_id;
            this.status = status;
            this.status_change_date = status_change_date;
            this.employee_id = employee_id;
        }
    }
}
