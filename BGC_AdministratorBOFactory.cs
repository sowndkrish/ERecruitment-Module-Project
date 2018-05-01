using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types;
using Erecruitment_BO;

namespace ERecruitmentFactoryBO
{
   public class BGC_AdministratorBOFactory
    {
        public static IBGCAdministratorBO createBGCAdministratorBO()
        {
            IBGCAdministratorBO objbgcadministratorbo = new BGC_AdministratorBO();
            return objbgcadministratorbo;
        }
        public static IBGCAdministratorBO createBGCAdministratorBO(int bgc_administrator_id, string status, DateTime status_change_date, int employee_id)
        {
            IBGCAdministratorBO objbgcadministratorbo = new BGC_AdministratorBO(bgc_administrator_id,status,status_change_date,employee_id);
            return objbgcadministratorbo;
        }
    }
}
